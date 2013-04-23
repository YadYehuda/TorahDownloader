namespace TorahDownloader.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuBarStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyURLToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.cntxMenuDownLimit = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.setCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enableSpeedLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripLblRate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripLblRateTxt = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolNewDownload = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripScheduler = new System.Windows.Forms.ToolStripButton();
			this.toolPause = new System.Windows.Forms.ToolStripButton();
			this.toolPauseAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolRemove = new System.Windows.Forms.ToolStripButton();
			this.toolRemoveCompleted = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMoveSelectionsUp = new System.Windows.Forms.ToolStripButton();
			this.toolMoveSelectionsDown = new System.Windows.Forms.ToolStripButton();
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.downloadList1 = new TorahDownloader.UI.DownloadList();
			this.menuBarStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.cntxMenuDownLimit.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuBarStrip
			// 
			this.menuBarStrip.BackColor = System.Drawing.Color.Transparent;
			this.menuBarStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuBarStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuBarStrip.Location = new System.Drawing.Point(3, 0);
			this.menuBarStrip.Name = "menuBarStrip";
			this.menuBarStrip.Size = new System.Drawing.Size(176, 24);
			this.menuBarStrip.Stretch = false;
			this.menuBarStrip.TabIndex = 0;
			this.menuBarStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDownloadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newDownloadToolStripMenuItem
			// 
			this.newDownloadToolStripMenuItem.Name = "newDownloadToolStripMenuItem";
			this.newDownloadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.newDownloadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.newDownloadToolStripMenuItem.Text = "New Download...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removeCompletedToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllToolStripMenuItem,
            this.copyURLToClipboardToolStripMenuItem1,
            this.toolStripSeparator6,
            this.optionsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.toolRemove_Click);
			// 
			// removeCompletedToolStripMenuItem
			// 
			this.removeCompletedToolStripMenuItem.Name = "removeCompletedToolStripMenuItem";
			this.removeCompletedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
			this.removeCompletedToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.removeCompletedToolStripMenuItem.Text = "Remove Completed";
			this.removeCompletedToolStripMenuItem.Click += new System.EventHandler(this.toolRemoveCompleted_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(234, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// copyURLToClipboardToolStripMenuItem1
			// 
			this.copyURLToClipboardToolStripMenuItem1.Name = "copyURLToClipboardToolStripMenuItem1";
			this.copyURLToClipboardToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyURLToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
			this.copyURLToClipboardToolStripMenuItem1.Text = "Copy URL to Clipboard";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(234, 6);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.optionsToolStripMenuItem.Text = "Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.toolOptions_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segmentsToolStripMenuItem,
            this.toolbarToolStripMenuItem,
            this.gridToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// segmentsToolStripMenuItem
			// 
			this.segmentsToolStripMenuItem.Name = "segmentsToolStripMenuItem";
			this.segmentsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.segmentsToolStripMenuItem.Text = "Segments";
			this.segmentsToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
			// 
			// toolbarToolStripMenuItem
			// 
			this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
			this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.toolbarToolStripMenuItem.Text = "Toolbar";
			this.toolbarToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
			// 
			// gridToolStripMenuItem
			// 
			this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
			this.gridToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.gridToolStripMenuItem.Text = "Grid";
			this.gridToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.ContextMenuStrip = this.cntxMenuDownLimit;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblRate,
            this.toolStripLblRateTxt});
			this.statusStrip1.Location = new System.Drawing.Point(20, 458);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(774, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// cntxMenuDownLimit
			// 
			this.cntxMenuDownLimit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCustomToolStripMenuItem,
            this.enableSpeedLimitToolStripMenuItem});
			this.cntxMenuDownLimit.Name = "cntxMenuDownLimit";
			this.cntxMenuDownLimit.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.cntxMenuDownLimit.ShowCheckMargin = true;
			this.cntxMenuDownLimit.ShowImageMargin = false;
			this.cntxMenuDownLimit.Size = new System.Drawing.Size(175, 48);
			this.cntxMenuDownLimit.Opening += new System.ComponentModel.CancelEventHandler(this.cntxMenuDownLimit_Opening);
			// 
			// setCustomToolStripMenuItem
			// 
			this.setCustomToolStripMenuItem.Name = "setCustomToolStripMenuItem";
			this.setCustomToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.setCustomToolStripMenuItem.Text = "Set Custom...";
			this.setCustomToolStripMenuItem.Click += new System.EventHandler(this.setCustomToolStripMenuItem_Click);
			// 
			// enableSpeedLimitToolStripMenuItem
			// 
			this.enableSpeedLimitToolStripMenuItem.CheckOnClick = true;
			this.enableSpeedLimitToolStripMenuItem.Name = "enableSpeedLimitToolStripMenuItem";
			this.enableSpeedLimitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.enableSpeedLimitToolStripMenuItem.Text = "Enable Speed Limit";
			this.enableSpeedLimitToolStripMenuItem.Click += new System.EventHandler(this.enableSpeedLimitToolStripMenuItem_Click);
			// 
			// toolStripLblRate
			// 
			this.toolStripLblRate.Name = "toolStripLblRate";
			this.toolStripLblRate.Size = new System.Drawing.Size(33, 17);
			this.toolStripLblRate.Text = "Rate:";
			// 
			// toolStripLblRateTxt
			// 
			this.toolStripLblRateTxt.Name = "toolStripLblRateTxt";
			this.toolStripLblRateTxt.Size = new System.Drawing.Size(41, 17);
			this.toolStripLblRateTxt.Text = "0 kbps";
			// 
			// toolStripMain
			// 
			this.toolStripMain.BackColor = System.Drawing.Color.Transparent;
			this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewDownload,
            this.toolStripSeparator2,
            this.toolStart,
            this.toolStripScheduler,
            this.toolPause,
            this.toolPauseAll,
            this.toolStripSeparator3,
            this.toolRemove,
            this.toolRemoveCompleted,
            this.toolStripSeparator4,
            this.toolMoveSelectionsUp,
            this.toolMoveSelectionsDown});
			this.toolStripMain.Location = new System.Drawing.Point(179, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStripMain.Size = new System.Drawing.Size(554, 25);
			this.toolStripMain.TabIndex = 2;
			// 
			// toolNewDownload
			// 
			this.toolNewDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolNewDownload.Image")));
			this.toolNewDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolNewDownload.Name = "toolNewDownload";
			this.toolNewDownload.Size = new System.Drawing.Size(108, 22);
			this.toolNewDownload.Text = "New Download";
			this.toolNewDownload.Click += new System.EventHandler(this.toolNewDownload_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStart
			// 
			this.toolStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStart.Image")));
			this.toolStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStart.Name = "toolStart";
			this.toolStart.Size = new System.Drawing.Size(23, 22);
			this.toolStart.Text = "Start";
			this.toolStart.Click += new System.EventHandler(this.toolStart_Click);
			// 
			// toolStripScheduler
			// 
			this.toolStripScheduler.CheckOnClick = true;
			this.toolStripScheduler.Image = ((System.Drawing.Image)(resources.GetObject("toolStripScheduler.Image")));
			this.toolStripScheduler.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripScheduler.Name = "toolStripScheduler";
			this.toolStripScheduler.Size = new System.Drawing.Size(144, 22);
			this.toolStripScheduler.Text = "Scheduled Downloads";
			this.toolStripScheduler.ToolTipText = "Toggle Auto-Downloads On/Off";
			this.toolStripScheduler.Click += new System.EventHandler(this.toolStripScheduler_Click);
			// 
			// toolPause
			// 
			this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolPause.Image = ((System.Drawing.Image)(resources.GetObject("toolPause.Image")));
			this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolPause.Name = "toolPause";
			this.toolPause.Size = new System.Drawing.Size(23, 22);
			this.toolPause.Text = "Pause";
			this.toolPause.Click += new System.EventHandler(this.toolPause_Click);
			// 
			// toolPauseAll
			// 
			this.toolPauseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolPauseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolPauseAll.Image")));
			this.toolPauseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolPauseAll.Name = "toolPauseAll";
			this.toolPauseAll.Size = new System.Drawing.Size(23, 22);
			this.toolPauseAll.Text = "Pause All";
			this.toolPauseAll.Click += new System.EventHandler(this.toolPauseAll_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolRemove
			// 
			this.toolRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolRemove.Image")));
			this.toolRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolRemove.Name = "toolRemove";
			this.toolRemove.Size = new System.Drawing.Size(23, 22);
			this.toolRemove.Text = "Remove";
			this.toolRemove.Click += new System.EventHandler(this.toolRemove_Click);
			// 
			// toolRemoveCompleted
			// 
			this.toolRemoveCompleted.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveCompleted.Image")));
			this.toolRemoveCompleted.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolRemoveCompleted.Name = "toolRemoveCompleted";
			this.toolRemoveCompleted.Size = new System.Drawing.Size(132, 22);
			this.toolRemoveCompleted.Text = "Remove Completed";
			this.toolRemoveCompleted.Click += new System.EventHandler(this.toolRemoveCompleted_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolMoveSelectionsUp
			// 
			this.toolMoveSelectionsUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolMoveSelectionsUp.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsUp.Image")));
			this.toolMoveSelectionsUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolMoveSelectionsUp.Name = "toolMoveSelectionsUp";
			this.toolMoveSelectionsUp.Size = new System.Drawing.Size(23, 22);
			this.toolMoveSelectionsUp.Text = "Move Selection(s) Up";
			this.toolMoveSelectionsUp.Click += new System.EventHandler(this.toolMoveSelectionsUp_Click);
			// 
			// toolMoveSelectionsDown
			// 
			this.toolMoveSelectionsDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolMoveSelectionsDown.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsDown.Image")));
			this.toolMoveSelectionsDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolMoveSelectionsDown.Name = "toolMoveSelectionsDown";
			this.toolMoveSelectionsDown.Size = new System.Drawing.Size(23, 22);
			this.toolMoveSelectionsDown.Text = "Move Selection(s) Down";
			this.toolMoveSelectionsDown.Click += new System.EventHandler(this.toolMoveSelectionsDown_Click);
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Interval = 1500;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.downloadList1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(774, 373);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(20, 60);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(774, 398);
			this.toolStripContainer1.TabIndex = 4;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuBarStrip);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMain);
			// 
			// downloadList1
			// 
			this.downloadList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.downloadList1.Location = new System.Drawing.Point(0, 0);
			this.downloadList1.Name = "downloadList1";
			this.downloadList1.Size = new System.Drawing.Size(774, 373);
			this.downloadList1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 500);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip = this.menuBarStrip;
			this.MinimumSize = new System.Drawing.Size(500, 450);
			this.Name = "MainForm";
			this.Text = "TorahDownloads.com Shiur Downloader";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuBarStrip.ResumeLayout(false);
			this.menuBarStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.cntxMenuDownLimit.ResumeLayout(false);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuBarStrip;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newDownloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripButton toolNewDownload;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStart;
		private System.Windows.Forms.ToolStripButton toolPause;
		private System.Windows.Forms.ToolStripButton toolPauseAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolRemove;
		private System.Windows.Forms.Timer tmrRefresh;
		internal System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripMenuItem segmentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripLblRate;
		private System.Windows.Forms.ToolStripStatusLabel toolStripLblRateTxt;
		private System.Windows.Forms.ToolStripButton toolRemoveCompleted;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolMoveSelectionsUp;
		private System.Windows.Forms.ToolStripButton toolMoveSelectionsDown;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeCompletedToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyURLToClipboardToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripScheduler;
		private System.Windows.Forms.ContextMenuStrip cntxMenuDownLimit;
		private System.Windows.Forms.ToolStripMenuItem setCustomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enableSpeedLimitToolStripMenuItem;
		private DownloadList downloadList1;
	}
}