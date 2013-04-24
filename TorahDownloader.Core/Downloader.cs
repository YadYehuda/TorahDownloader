using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using TorahDownloader.Core.Common;
using TorahDownloader.Core.Concurrency;
using TorahDownloader.Core.Properties;

namespace TorahDownloader.Core
{
	public class Downloader
	{
		private string localFile;
		private Thread mainThread;
		private List<Thread> threads;
		private Dictionary<string, object> extentedProperties = new Dictionary<string, object>();

		private IProtocolProvider defaultDownloadProvider;
		private ISegmentCalculator segmentCalculator;
		private IMirrorSelector mirrorSelector;

		private Downloader(ResourceLocation rl, ResourceLocation[] mirrors, string localFile)
		{
			this.threads = new List<Thread>();
			this.ResourceLocation = rl;
			if (mirrors == null)
			{
				this.Mirrors = new List<ResourceLocation>();
			}
			else
			{
				this.Mirrors = new List<ResourceLocation>(mirrors);
			}
			this.localFile = localFile;

			extentedProperties = new Dictionary<string, object>();

			defaultDownloadProvider = rl.BindProtocolProviderInstance(this);

			segmentCalculator = new MinSizeSegmentCalculator();
			this.MirrorSelector = new SequentialMirrorSelector();
		}

		public Downloader(ResourceLocation rl, ResourceLocation[] mirrors, string localFile, int segmentCount) :
			this(rl, mirrors, localFile)
		{
			SetState(DownloaderState.NeedToPrepare);

			this.CreatedDateTime = DateTime.Now;
			this.RequestedSegments = segmentCount;
			this.Segments = new List<Segment>();
		}

		public Downloader(ResourceLocation rl, ResourceLocation[] mirrors, string localFile, List<Segment> segments, RemoteFileInfo remoteInfo, int requestedSegmentCount, DateTime createdDateTime) :
			this(rl, mirrors, localFile)
		{
			if (segments.Count > 0)
			{
				SetState(DownloaderState.Prepared);
			}
			else
			{
				SetState(DownloaderState.NeedToPrepare);
			}

			this.CreatedDateTime = createdDateTime;
			this.RemoteFileInfo = remoteInfo;
			this.RequestedSegments = requestedSegmentCount;
			this.Segments = segments;
		}

		#region Properties

		public event EventHandler Ending;

		public event EventHandler InfoReceived;

		public event EventHandler StateChanged;

		public event EventHandler<SegmentEventArgs> RestartingSegment;

		public event EventHandler<SegmentEventArgs> SegmentStoped;

		public event EventHandler<SegmentEventArgs> SegmentStarting;

		public event EventHandler<SegmentEventArgs> SegmentStarted;

		public event EventHandler<SegmentEventArgs> SegmentFailed;

		public Dictionary<string, object> ExtendedProperties
		{
			get { return extentedProperties; }
		}

		public ResourceLocation ResourceLocation { get; private set; }

		public List<ResourceLocation> Mirrors { get; private set; }

		public long FileSize
		{
			get 
			{
				if (RemoteFileInfo == null)
				{
					return 0;
				}
				return RemoteFileInfo.FileSize;
			}
		}

		public DateTime CreatedDateTime { get; private set; }

		public int RequestedSegments { get; private set; }

		public string LocalFile
		{
			get
			{
				return this.localFile;
			}
		}

		public double Progress
		{
			get
			{
				int count = Segments.Count;

				if (count == 0) return 0;

				double progress = Segments.Sum(seg => seg.Progress);
				return progress / count;
			}
		}

		public double Rate
		{
			get
			{
				return Segments.Sum(seg => seg.Rate);
			}
		}

		public long Transfered
		{
			get
			{
				return Segments.Sum(seg => seg.Transfered);
			}
		}

		public TimeSpan Left
		{
			get
			{
				double rate = this.Rate;

				if (rate == 0) return TimeSpan.MaxValue;

				double missingTransfer = Segments.Sum(seg => seg.MissingTransfer);
				return TimeSpan.FromSeconds(missingTransfer / rate);
			}
		}

		public List<Segment> Segments { get; private set; }

		public Exception LastError { get; set; }

		public DownloaderState State { get; private set; }

		public bool IsWorking()
		{
			DownloaderState state = this.State;
			return (state == DownloaderState.Preparing ||
				state == DownloaderState.WaitingForReconnect ||
				state == DownloaderState.Working);
		}

		public RemoteFileInfo RemoteFileInfo { get; private set; }

		public string StatusMessage { get; set; }

		public ISegmentCalculator SegmentCalculator
		{
			get { return segmentCalculator; }
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}

				segmentCalculator = value;
			}
		}

		public IMirrorSelector MirrorSelector
		{
			get { return mirrorSelector; }
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}

				mirrorSelector = value;
				mirrorSelector.Init(this);
			}
		}

		#endregion

		private void SetState(DownloaderState value)
		{
			State = value;

			OnStateChanged();
		}

		private void StartToPrepare()
		{
			mainThread = new Thread(new ParameterizedThreadStart(StartDownloadThreadProc));
			mainThread.Start(RequestedSegments);
		}

		private void StartPrepared()
		{
			mainThread = new Thread(new ThreadStart(RestartDownload));
			mainThread.Start();
		}

		protected virtual void OnRestartingSegment(Segment segment)
		{
			if (RestartingSegment != null)
			{
				RestartingSegment(this, new SegmentEventArgs(this, segment));
			}
		}

		protected virtual void OnSegmentStoped(Segment segment)
		{
			if (SegmentStoped != null)
			{
				SegmentStoped(this, new SegmentEventArgs(this, segment));
			}
		}

		protected virtual void OnSegmentFailed(Segment segment)
		{
			if (SegmentFailed != null)
			{
				SegmentFailed(this, new SegmentEventArgs(this, segment));
			}
		}

		protected virtual void OnSegmentStarting(Segment segment)
		{
			if (SegmentStarting != null)
			{
				SegmentStarting(this, new SegmentEventArgs(this, segment));
			}
		}

		protected virtual void OnSegmentStarted(Segment segment)
		{
			if (SegmentStarted != null)
			{
				SegmentStarted(this, new SegmentEventArgs(this, segment));
			}
		}

		protected virtual void OnStateChanged()
		{
			if (StateChanged != null)
			{
				StateChanged(this, EventArgs.Empty);
			}
		}

		protected virtual void OnEnding()
		{
			if (Ending != null)
			{
				Ending(this, EventArgs.Empty);
			}
		}

		protected virtual void OnInfoReceived()
		{
			if (InfoReceived != null)
			{
				InfoReceived(this, EventArgs.Empty);
			}
		}

		public IDisposable LockSegments()
		{
			return new ObjectLocker(this.Segments);
		}

		public void WaitForConclusion()
		{
			if (!IsWorking())
			{
				if (mainThread != null && mainThread.IsAlive)
				{
					mainThread.Join(TimeSpan.FromSeconds(1));
				}
			}

			while (IsWorking())
			{
				Thread.Sleep(100);
			}

			Debug.WriteLine(this.State.ToString());
		}

		public void Pause()
		{
			if (State == DownloaderState.Preparing || State == DownloaderState.WaitingForReconnect)
			{
				Segments.Clear();

				mainThread.Abort();
				mainThread = null;
				SetState(DownloaderState.NeedToPrepare);
				return;
			}

			if (State == DownloaderState.Working)
			{
				SetState(DownloaderState.Pausing);

				while (!AllWorkersStopped(5))
					;

				lock (threads)
				{
					threads.Clear();
				}

				mainThread.Abort();
				mainThread = null;

				if (RemoteFileInfo != null && !RemoteFileInfo.AcceptRanges)
				{
					// reset the segment
					Segments[0].StartPosition = 0;
				}

				SetState(DownloaderState.Paused);
			}
		}

		public void Start()
		{
			if (State == DownloaderState.NeedToPrepare)
			{
				SetState(DownloaderState.Preparing);

				StartToPrepare();
			}
			else if (
				State != DownloaderState.Preparing &&
				State != DownloaderState.Pausing &&
				State != DownloaderState.Working &&
				State != DownloaderState.WaitingForReconnect)
			{
				SetState(DownloaderState.Preparing);

				StartPrepared();
			}
		}

		private void AllocLocalFile()
		{
			FileInfo fileInfo = new FileInfo(this.LocalFile);
			if (!Directory.Exists(fileInfo.DirectoryName))
			{
				Directory.CreateDirectory(fileInfo.DirectoryName);
			}

			if (fileInfo.Exists)
			{
				// auto rename the file...
				int count = 1;

				string fileExitWithoutExt = Path.GetFileNameWithoutExtension(this.LocalFile);
				string ext = Path.GetExtension(this.LocalFile);

				string newFileName;

				do
				{
					newFileName = fileInfo.DirectoryName.GetWithDirectorySeparator()
						+ fileExitWithoutExt + String.Format("({0})", count++) + ext;
				}
				while (File.Exists(newFileName));

				this.localFile = newFileName;
			}

			using (FileStream fs = new FileStream(this.LocalFile, FileMode.Create, FileAccess.Write))
			{
				fs.SetLength(Math.Max(this.FileSize, 0));
			}
		}

		private void StartDownloadThreadProc(object objSegmentCount)
		{
			SetState(DownloaderState.Preparing);

			int segmentCount = Math.Min((int)objSegmentCount, Settings.Default.MaxSegments);
			Stream inputStream = null;
			int currentTry = 0;

			do
			{
				LastError = null;

				if (State == DownloaderState.Pausing)
				{
					SetState(DownloaderState.NeedToPrepare);
					return;
				}

				SetState(DownloaderState.Preparing);

				currentTry++;
				try
				{
					RemoteFileInfo = defaultDownloadProvider.GetFileInfo(this.ResourceLocation, out inputStream);
					break;
				}
				catch (ThreadAbortException)
				{
					SetState(DownloaderState.NeedToPrepare);
					return;
				}
				catch (Exception ex)
				{
					LastError = ex;
					if (currentTry < Settings.Default.MaxRetries)
					{
						SetState(DownloaderState.WaitingForReconnect);
						Thread.Sleep(TimeSpan.FromSeconds(Settings.Default.RetryDelay));
					}
					else
					{
						SetState(DownloaderState.NeedToPrepare);
						return;
					}
				}
			}
			while (true);

			try
			{
				LastError = null;
				StartSegments(segmentCount, inputStream);
			}
			catch (ThreadAbortException)
			{
				throw;
			}
			catch (Exception ex)
			{
				LastError = ex;
				SetState(DownloaderState.EndedWithError);
			}
		}

		private void StartSegments(int segmentCount, Stream inputStream)
		{
			// notifies
			OnInfoReceived();

			// allocates the file on disk
			AllocLocalFile();

			long segmentSize;

			CalculatedSegment[] calculatedSegments;

			if (!RemoteFileInfo.AcceptRanges)
			{
				calculatedSegments = new CalculatedSegment[] { new CalculatedSegment(0, RemoteFileInfo.FileSize) };
			}
			else
			{
				calculatedSegments = this.SegmentCalculator.GetSegments(segmentCount, RemoteFileInfo);
			}

			lock (threads) threads.Clear();
			lock (Segments) Segments.Clear();

			for (int i = 0; i < calculatedSegments.Length; i++)
			{
				Segment segment = new Segment();
				if (i == 0)
				{
					segment.InputStream = inputStream;
				}

				segment.Index = i;
				segment.InitialStartPosition = calculatedSegments[i].StartPosition;
				segment.StartPosition = calculatedSegments[i].StartPosition;
				segment.EndPosition = calculatedSegments[i].EndPosition;

				Segments.Add(segment);
			}

			RunSegments();
		}

		private void RestartDownload()
		{
			int currentTry = 0;
			Stream stream;
			RemoteFileInfo newInfo;

			try
			{
				do
				{
					LastError = null;

					SetState(DownloaderState.Preparing);

					currentTry++;
					try
					{
						newInfo = defaultDownloadProvider.GetFileInfo(this.ResourceLocation, out stream);

						break;
					}
					catch (Exception ex)
					{
						LastError = ex;
						if (currentTry < Settings.Default.MaxRetries)
						{
							SetState(DownloaderState.WaitingForReconnect);
							Thread.Sleep(TimeSpan.FromSeconds(Settings.Default.RetryDelay));
						}
						else
						{
							return;
						}
					}
				}
				while (true);
			}
			finally
			{
				SetState(DownloaderState.Prepared);
			}

			try
			{
				// check if the file changed on the server
				if (!newInfo.AcceptRanges ||
					newInfo.LastModified > RemoteFileInfo.LastModified ||
					newInfo.FileSize != RemoteFileInfo.FileSize)
				{
					this.RemoteFileInfo = newInfo;
					StartSegments(this.RequestedSegments, stream);
				}
				else
				{
					if (stream != null)
					{
						stream.Dispose();
					}

					RunSegments();
				}
			}
			catch (ThreadAbortException)
			{
				throw;
			}
			catch (Exception ex)
			{
				LastError = ex;
				SetState(DownloaderState.EndedWithError);
			}
		}

		private void RunSegments()
		{
			SetState(DownloaderState.Working);

			// TODO comparar o remote file Info se esta igual, se o download saiu de paused/prepared
			// e nao veio da thread que le o fileinfo

			using (FileStream fs = new FileStream(this.LocalFile, FileMode.Open, FileAccess.Write))
			{
				for (int i = 0; i < this.Segments.Count; i++)
				{
					Segments[i].OutputStream = fs;
					StartSegment(Segments[i]);
				}

				do
				{
					while (!AllWorkersStopped(1000))
						;
				}
				while (RestartFailedSegments());
			}

			for (int i = 0; i < this.Segments.Count; i++)
			{
				if (Segments[i].State == SegmentState.Error)
				{
					SetState(DownloaderState.EndedWithError);
					return;
				}
			}

			if (this.State != DownloaderState.Pausing)
			{
				OnEnding();
			}

			SetState(DownloaderState.Ended);
		}

		private bool RestartFailedSegments()
		{
			bool hasErrors = false;
			double delay = 0;

			for (int i = 0; i < this.Segments.Count; i++)
			{
				if (Segments[i].State == SegmentState.Error &&
					Segments[i].LastErrorDateTime != DateTime.MinValue &&
					(Settings.Default.MaxRetries == 0 ||
					Segments[i].CurrentTry < Settings.Default.MaxRetries))
				{
					hasErrors = true;
					TimeSpan ts = DateTime.Now - Segments[i].LastErrorDateTime;

					if (ts.TotalSeconds >= Settings.Default.RetryDelay)
					{
						Segments[i].CurrentTry++;
						StartSegment(Segments[i]);
						OnRestartingSegment(Segments[i]);
					}
					else
					{
						delay = Math.Max(delay, Settings.Default.RetryDelay * 1000 - ts.TotalMilliseconds);
					}
				}
			}

			Thread.Sleep((int)delay);

			return hasErrors;
		}

		private void StartSegment(Segment newSegment)
		{
			Thread segmentThread = new Thread(new ParameterizedThreadStart(SegmentThreadProc));
			segmentThread.Start(newSegment);

			lock (threads)
			{
				threads.Add(segmentThread);
			}
		}

		private bool AllWorkersStopped(int timeOut)
		{
			bool allFinished = true;

			Thread[] workers;

			lock (threads)
			{
				workers = threads.ToArray();
			}

			foreach (Thread t in workers)
			{
				bool finished = t.Join(timeOut);
				allFinished = allFinished & finished;

				if (finished)
				{
					lock (threads)
					{
						threads.Remove(t);
					}
				}
			}

			return allFinished;
		}

		private void SegmentThreadProc(object objSegment)
		{
			Segment segment = (Segment)objSegment;

			segment.LastError = null;

			try
			{
				if (segment.EndPosition > 0 && segment.StartPosition >= segment.EndPosition)
				{
					segment.State = SegmentState.Finished;

					// raise the event
					OnSegmentStoped(segment);

					return;
				}

				int buffSize = 8192;
				byte[] buffer = new byte[buffSize];

				segment.State = SegmentState.Connecting;

				// raise the event 
				OnSegmentStarting(segment);

				if (segment.InputStream == null)
				{
					// get the next URL (It can the the main url or some mirror)
					ResourceLocation location = this.MirrorSelector.GetNextResourceLocation();
					// get the protocol provider for that mirror
					IProtocolProvider provider = location.BindProtocolProviderInstance(this);

					while (location != this.ResourceLocation)
					{
						Stream tempStream;

						// get the remote file info on mirror
						RemoteFileInfo tempRemoteInfo = provider.GetFileInfo(location, out tempStream);
						if (tempStream != null) tempStream.Dispose();

						// check if the file on mirror is the same
						if (tempRemoteInfo.FileSize == RemoteFileInfo.FileSize &&
							tempRemoteInfo.AcceptRanges == RemoteFileInfo.AcceptRanges)
						{
							// if yes, stop looking for the mirror
							break;
						}

						lock (Mirrors)
						{
							// the file on the mirror is not the same, so remove from the mirror list
							Mirrors.Remove(location);
						}

						// the file on the mirror is different
						// so get other mirror to use in the segment
						location = this.MirrorSelector.GetNextResourceLocation();
						provider = location.BindProtocolProviderInstance(this);
					}

					// get the input stream from start position
					segment.InputStream = provider.CreateStream(location, segment.StartPosition, segment.EndPosition);

					// change the segment URL to the mirror URL
					segment.CurrentURL = location.URL;
				}
				else
				{
					//  change the segment URL to the main URL
					segment.CurrentURL = this.ResourceLocation.URL;
				}

				using (segment.InputStream)
				{
					// raise the event
					OnSegmentStarted(segment);

					// change the segment state
					segment.State = SegmentState.Downloading;
					segment.CurrentTry = 0;

					long readSize;

					do
					{
						// reads the buffer from input stream
						readSize = segment.InputStream.Read(buffer, 0, buffSize);

						// check if the segment has reached the end
						if (segment.EndPosition > 0 &&
							segment.StartPosition + readSize > segment.EndPosition)
						{
							// adjust the 'readSize' to write only necessary bytes
							readSize = (segment.EndPosition - segment.StartPosition);
							if (readSize <= 0)
							{
								segment.StartPosition = segment.EndPosition;
								break;
							}
						}

						// locks the stream to avoid that other threads changes
						// the position of stream while this thread is writing into the stream
						lock (segment.OutputStream)
						{
							segment.OutputStream.Position = segment.StartPosition;
							segment.OutputStream.Write(buffer, 0, (int)readSize);
						}

						// increase the start position of the segment and also calculates the rate
						segment.IncreaseStartPosition(readSize);

						// check if the stream has reached its end
						if (segment.EndPosition > 0 && segment.StartPosition >= segment.EndPosition)
						{
							segment.StartPosition = segment.EndPosition;
							break;
						}

						// check if the user have requested to pause the download
						if (State == DownloaderState.Pausing)
						{
							segment.State = SegmentState.Paused;
							break;
						}

						//Thread.Sleep(1500);
					}
					while (readSize > 0);

					if (segment.State == SegmentState.Downloading)
					{
						segment.State = SegmentState.Finished;

						// try to create other segment, 
						// splitting the missing bytes from one existing segment
						AddNewSegmentIfNeeded();
					}
				}

				// raise the event
				OnSegmentStoped(segment);
			}
			catch (Exception ex)
			{
				// store the error information
				segment.State = SegmentState.Error;
				segment.LastError = ex;

				Debug.WriteLine(ex.ToString());

				// raise the event
				OnSegmentFailed(segment);
			}
			finally
			{
				// clean up the segment
				segment.InputStream = null;
			}
		}

		private void AddNewSegmentIfNeeded()
		{
			lock (Segments)
			{
				for (int i = 0; i < Segments.Count; i++)
				{
					Segment oldSegment = Segments[i];
					if (oldSegment.State == SegmentState.Downloading &&
						oldSegment.Left.TotalSeconds > Settings.Default.MinSegmentLeftToStartNewSegment &&
						oldSegment.MissingTransfer / 2 >= Settings.Default.MinSegmentSize)
					{
						// get the half of missing size of oldSegment
						long newSize = oldSegment.MissingTransfer / 2;

						// create a new segment allocation the half old segment
						Segment newSegment = new Segment();
						newSegment.Index = Segments.Count;
						newSegment.StartPosition = oldSegment.StartPosition + newSize;
						newSegment.InitialStartPosition = newSegment.StartPosition;
						newSegment.EndPosition = oldSegment.EndPosition;
						newSegment.OutputStream = oldSegment.OutputStream;

						// removes bytes from old segments
						oldSegment.EndPosition = oldSegment.EndPosition - newSize;

						// add the new segment to the list
						Segments.Add(newSegment);

						StartSegment(newSegment);

						break;
					}
				}
			}
		}
	}
}
