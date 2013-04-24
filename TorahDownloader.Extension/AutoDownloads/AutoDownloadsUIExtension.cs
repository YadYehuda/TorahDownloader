using System.Windows.Forms;
using TorahDownloader.Core.Extensions;
using TorahDownloader.Extension.AutoDownloads.UI;

namespace TorahDownloader.Extension.AutoDownloads
{
    public class AutoDownloadsUIExtension: IUIExtension
    {
        #region IUIExtension Members

        public Control[] CreateSettingsView()
        {
            return new Control[] { new Jobs() };
        }

        public void PersistSettings(Control[] settingsView)
        {
            Jobs jobs = (Jobs)settingsView[0];

            Settings.Default.MaxJobs = jobs.MaxJobs;
            Settings.Default.WorkOnlyOnSpecifiedTimes = jobs.WorkOnlyOnSpecifiedTimes;
            Settings.Default.TimesToWork = jobs.TimesToWork;
            Settings.Default.MaxRateOnTime = jobs.MaxRate;
            Settings.Default.AutoStart = jobs.AutoStart;
            Settings.Default.Save();
        }

        #endregion
    }
}
