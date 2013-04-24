using System;
using System.Windows.Forms;
using TorahDownloader.Core.UI;

namespace TorahDownloader.Extension.AutoDownloads.UI
{
    public partial class ScheduledDownloadEnabler : UserControl
    {
        public ScheduledDownloadEnabler()
        {
            InitializeComponent();
        }

        private void ScheduledDownloadEnabler_Load(object sender, EventArgs e)
        {
            numMaxJobs.Value = Settings.Default.MaxJobs;

            UpdateUI();
        }

        private void chkStartScheduler_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void chkOverrideMaxActive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            chkDisableWorkOnlyAt.Enabled = chkStartScheduler.Checked && Settings.Default.WorkOnlyOnSpecifiedTimes;
            chkOverrideMaxActive.Enabled = chkStartScheduler.Checked;
            numMaxJobs.Enabled = chkStartScheduler.Checked && chkOverrideMaxActive.Checked;
            panel1.Enabled = chkStartScheduler.Checked;
        }

        public void ApplySettings()
        {
            if (chkStartScheduler.Checked)
            {
                bool needToSave = false;

                if (chkOverrideMaxActive.Checked)
                {
                    Settings.Default.MaxJobs = (int)numMaxJobs.Value;
                    needToSave = true;
                }
                if (chkDisableWorkOnlyAt.Checked)
                {
                    Settings.Default.WorkOnlyOnSpecifiedTimes = false;
                    needToSave = true;
                }

                if (needToSave)
                {
                    Settings.Default.Save();
                }

                AutoDownloadsExtension scheduler = (AutoDownloadsExtension)AppManager.Instance.
                    Application.GetExtensionByType(typeof(AutoDownloadsExtension));
                scheduler.Active = true;
            }
        }
    }
}
