using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using TorahDownloader.Core;
using TorahDownloader.Extension.SpeedLimit;
using TorahDownloader.Properties;
using TorahDownloader.SingleInstancing;

namespace TorahDownloader.UI
{
	public partial class MainForm : MetroForm, ISingleInstanceEnforcer
	{
		SpeedLimitExtension speedLimit;

		public MainForm()
		{
			InitializeComponent();
			
			this.toolStripMain.Renderer = new NoBorderToolStripRenderer();

			downloadList1.SelectionChange += new EventHandler(downloadList1_SelectionChange);
			downloadList1.UpdateUI();

			speedLimit = (SpeedLimitExtension)App.Instance.GetExtensionByType(typeof(SpeedLimitExtension));
		}

		void downloadList1_SelectionChange(object sender, EventArgs e)
		{
			int cnt = downloadList1.SelectedCount;

			bool isSelected = cnt > 0;
			bool isSelectedOnlyOne = cnt == 1;

			removeToolStripMenuItem.Enabled = isSelected;
			removeCompletedToolStripMenuItem.Enabled = isSelected;

			toolStart.Enabled = isSelected;
			toolPause.Enabled = isSelected;
			toolRemove.Enabled = isSelected;

			copyURLToClipboardToolStripMenuItem1.Enabled = isSelectedOnlyOne;

			toolMoveSelectionsDown.Enabled = isSelected;
			toolMoveSelectionsUp.Enabled = isSelected;
		}

		private void tmrRefresh_Tick(object sender, EventArgs e)
		{
			string strRate;

			if (speedLimit.CurrentEnabled)
			{
				strRate = String.Format("[{0:0.##} kbps] {1:0.##} kbps",
					speedLimit.CurrentMaxRate / 1024.0,
					DownloadManager.Instance.TotalDownloadRate / 1024.0);
			}
			else
			{
				strRate = String.Format("{0:0.##} kbps", DownloadManager.Instance.TotalDownloadRate / 1024.0);
			}

			toolStripScheduler.Checked = downloadList1.SchedulerStarted();

			toolStripLblRateTxt.Text = strRate;

			notifyIcon.Text = String.Concat(this.Text, "\n", toolStripLblRate.Text, " ", strRate);

			downloadList1.UpdateList();
		}

		#region ISingleInstanceEnforcer Members

		public void OnMessageReceived(MessageEventArgs e)
		{
			string[] args = (string[])e.Message;

			if (args.Length == 2 && args[0] == "/sw")
			{
				this.BeginInvoke((MethodInvoker) delegate { downloadList1.NewDownloadFromData(args[1]); });
			}
			else
			{
				//downloadList1.AddDownloadURLs(ResourceLocation.FromURLArray(args), 1, null, 0);
			}
		}

		public void OnNewInstanceCreated(EventArgs e)
		{
			this.Focus();
		}

		#endregion

		private void LoadViewSettings()
		{
			downloadList1.LoadSettingsView();

			toolStripMain.Visible = Settings.Default.ViewToolbar;

			gridToolStripMenuItem.Checked = Settings.Default.ViewGrid;
			segmentsToolStripMenuItem.Checked = Settings.Default.ViewTransDetails;
			toolbarToolStripMenuItem.Checked = Settings.Default.ViewToolbar;
		}

		public void ShowHideForm()
		{
			if (this.Visible)
			{
				HideForm();
			}
			else
			{
				ShowForm();
				LoadViewSettings();
			}
		}

		public void ShowForm()
		{
			this.ShowInTaskbar = true;
			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
		}

		public void HideForm()
		{
			this.ShowInTaskbar = false;
			this.Visible = false;
		}

		#region toolbar buttons
		private void toolNewDownload_Click(object sender, EventArgs e)
		{
			downloadList1.NewFileDownload(null, true);
		}

		private void toolStart_Click(object sender, EventArgs e)
		{
			downloadList1.StartSelections();
		}

		private void toolPause_Click(object sender, EventArgs e)
		{
			downloadList1.Pause();
		}

		private void toolPauseAll_Click(object sender, EventArgs e)
		{
			downloadList1.PauseAll();
		}

		private void toolRemove_Click(object sender, EventArgs e)
		{
			downloadList1.RemoveSelections();
		}

		private void toolRemoveCompleted_Click(object sender, EventArgs e)
		{
			downloadList1.RemoveCompleted();
		}

		private void toolOptions_Click(object sender, EventArgs e)
		{
			using (OptionsForm options = new OptionsForm())
			{
				options.ShowDialog();
			}
		}

		private void toolAbout_Click(object sender, EventArgs e)
		{
			using (AboutForm about = new AboutForm())
			{
				about.ShowDialog();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void newBatchDownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			downloadList1.NewBatchDownload();
		}

		private void viewMenuClickClick(object sender, EventArgs e)
		{
			ToolStripMenuItem menu = ((ToolStripMenuItem)sender);
			menu.Checked = !menu.Checked;

			Settings.Default.ViewGrid = gridToolStripMenuItem.Checked;
			Settings.Default.ViewToolbar = toolbarToolStripMenuItem.Checked;
			Settings.Default.ViewTransDetails = segmentsToolStripMenuItem.Checked;

			LoadViewSettings();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Save();
		}

		private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowHideForm();
		}

		private void showHideToolStripMenuItem_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ShowHideForm();
			}
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			downloadList1.SelectAll();
		}

		private void toolStripScheduler_Click(object sender, EventArgs e)
		{
			downloadList1.StartScheduler(toolStripScheduler.Checked);
		}

		private void toolMoveSelectionsUp_Click(object sender, EventArgs e)
		{
			downloadList1.MoveSelectionsUp();
		}

		private void toolMoveSelectionsDown_Click(object sender, EventArgs e)
		{
			downloadList1.MoveSelectionsDown();
		}
		#endregion

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadViewSettings();

			notifyIcon.Icon = this.Icon;
			notifyIcon.Text = this.Text;
			notifyIcon.Visible = true;
		}

		private void setCustomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			((SpeedLimitUIExtension)speedLimit.UIExtension).ShowSpeedLimitDialog();
		}

		private void enableSpeedLimitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			speedLimit.Parameters.Enabled = enableSpeedLimitToolStripMenuItem.Checked;
		}

		private void cntxMenuDownLimit_Opening(object sender, CancelEventArgs e)
		{
			speedLimit.Parameters.Enabled = enableSpeedLimitToolStripMenuItem.Checked;
		}
	}
}
