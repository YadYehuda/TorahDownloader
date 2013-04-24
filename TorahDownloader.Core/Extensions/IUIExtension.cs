using System.Windows.Forms;

namespace TorahDownloader.Core.Extensions
{
	public interface IUIExtension
	{
		Control[] CreateSettingsView();

		void PersistSettings(Control[] settingsView);
	}
}
