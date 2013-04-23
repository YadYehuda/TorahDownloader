using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	#region ResolvingProtocolProviderEventArgs
	public class ResolvingProtocolProviderEventArgs : EventArgs
	{
		#region Constructor

		public ResolvingProtocolProviderEventArgs(IProtocolProvider provider,
			string url)
		{
			this.URL = url;
			this.ProtocolProvider = provider;
		}

		#endregion

		#region Properties

		public string URL { get; private set; }

		public IProtocolProvider ProtocolProvider { get; set; }

		#endregion
	}
	#endregion

	#region DownloaderEventArgs
	public class DownloaderEventArgs : EventArgs
	{
		#region Constructor

		public DownloaderEventArgs(Downloader download)
		{
			this.Downloader = download;
		}

		public DownloaderEventArgs(Downloader download, bool willStart)
			: this(download)
		{
			this.WillStart = willStart;
		}

		#endregion

		#region Properties

		public Downloader Downloader { get; private set; }

		public bool WillStart { get; private set; }

		#endregion
	}
	#endregion

	#region SegmentEventArgs
	public class SegmentEventArgs : DownloaderEventArgs
	{
		#region Constructor

		public SegmentEventArgs(Downloader d, Segment segment)
			: base(d)
		{
			this.Segment = segment;
		}

		#endregion

		#region Properties

		public Segment Segment { get; set; }

		#endregion
	}
	#endregion
}
