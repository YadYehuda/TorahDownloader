using System.Windows.Forms;
using TorahDownloader.Core.Extensions;
using TorahDownloader.Core.Properties;

namespace TorahDownloader.Core.UI
{
	public class CoreUIExtension : IUIExtension
	{
		#region IUIExtension Members

		public Control[] CreateSettingsView()
		{
			return new Control[] { new Connection(), new DownloadFolder() };
		}

		public void PersistSettings(System.Windows.Forms.Control[] settingsView)
		{
			Connection connection = (Connection)settingsView[0];
			DownloadFolder downloadFolder = (DownloadFolder)settingsView[1];

			Settings.Default.MaxRetries = connection.MaxRetries;
			Settings.Default.MinSegmentSize = connection.MinSegmentSize;
			Settings.Default.RetryDelay = connection.RetryDelay;
			Settings.Default.MaxSegments = connection.MaxSegments;

			Settings.Default.DownloadFolder = downloadFolder.Folder;

			Settings.Default.Save();
		}

		#endregion
	}
}
