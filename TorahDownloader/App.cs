using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using TorahDownloader.Core.Extensions;
using TorahDownloader.Core.UI;
using TorahDownloader.SingleInstancing;
using TorahDownloader.Extension.AutoDownloads;
using TorahDownloader.Extension.SpeedLimit;
using TorahDownloader.Extension.Protocols;

namespace TorahDownloader
{
	[Serializable]
	public class App : IApp
	{
		#region Singleton

		private static App instance = new App();

		public static App Instance
		{
			get
			{
				return instance;
			}
		}

		private App()
		{
			AppManager.Instance.Initialize(this);

			Extensions = new List<IExtension>();

			Extensions.Add(new CoreExtension());

			Extensions.Add(new AutoDownloadsExtension());
			Extensions.Add(new SpeedLimitExtension());
			Extensions.Add(new HttpFtpProtocolExtension());
		}

		#endregion

		#region Fields

		private SingleInstanceTracker tracker = null;
		private bool disposed = false;

		#endregion

		#region Properties

		public Form MainForm
		{
			get
			{
				return (UI.MainForm)tracker.Enforcer;
			}
		}

		public NotifyIcon NotifyIcon
		{
			get
			{
				return ((UI.MainForm)MainForm).notifyIcon;
			}
		}

		public List<IExtension> Extensions { get; private set; }

		#endregion

		#region Methods

		public IExtension GetExtensionByType(Type type)
		{
			foreach (IExtension e in Extensions)
			{
				if (e.GetType() == type)
				{
					return e;
				}
			}

			return null;
		}

		private ISingleInstanceEnforcer GetSingleInstanceEnforcer()
		{
			return new UI.MainForm();
		}

		public void InitExtensions()
		{
			foreach (IExtension e in Extensions)
			{
				if (e is IInitializable)
				{
					((IInitializable)e).Init();
				}
			}

		}
		public void Dispose()
		{
			if (!disposed)
			{
				disposed = true;
				foreach (IExtension e in Extensions)
				{
					if (e is IDisposable)
					{
						try
						{
							((IDisposable)e).Dispose();
						}
						catch (Exception ex)
						{
							Debug.WriteLine(ex.ToString());
						}
					}
				}
			}
		}

		public void Start(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				// Attempt to create a tracker
				tracker = new SingleInstanceTracker("TorahDownloader", new SingleInstanceEnforcerRetriever(GetSingleInstanceEnforcer));

				// If this is the first instance of the application, run the main form
				if (tracker.IsFirstInstance)
				{
					try
					{
						UI.MainForm form = (UI.MainForm)tracker.Enforcer;

						//form.downloadList1.AddDownloadURLs(ResourceLocation.FromURLArray(args), 1, null, 0);

						if (Array.IndexOf<string>(args, "/as") >= 0)
						{
							form.WindowState = FormWindowState.Minimized;
						}

						form.Load += delegate(object sender, EventArgs e)
						{
							InitExtensions();

							if (form.WindowState == FormWindowState.Minimized)
							{
								form.HideForm();
							}

							if (args.Length > 0)
							{
								form.OnMessageReceived(new MessageEventArgs(args));
							}
						};

						form.FormClosing += delegate(object sender, FormClosingEventArgs e)
						{
							Dispose();
						};

						Application.Run(form);
					}
					finally
					{
						Dispose();
					}
				}
				else
				{
					// This is not the first instance of the application, so do nothing but send a message to the first instance
					if (args.Length > 0)
					{
						tracker.SendMessageToFirstInstance(args);
					}
				}
			}
			catch (SingleInstancingException ex)
			{
				MessageBox.Show("Could not create a SingleInstanceTracker object:\n" + ex.Message + "\nApplication will now terminate.\n" + ex.InnerException.ToString());

				return;
			}
			finally
			{
				if (tracker != null)
					tracker.Dispose();
			}
		}

		#endregion
	}
}
