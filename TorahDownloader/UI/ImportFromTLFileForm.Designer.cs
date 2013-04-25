namespace TorahDownloader.UI
{
	partial class ImportFromTLFileForm
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
			this.btnPreview = new MetroFramework.Controls.MetroButton();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.fileChooser1 = new TorahDownloader.Core.UI.FileChooser();
			this.scheduledDownloadEnabler1 = new TorahDownloader.Extension.AutoDownloads.UI.ScheduledDownloadEnabler();
			this.downloadFolder1 = new TorahDownloader.Core.UI.DownloadFolder();
			this.SuspendLayout();
			// 
			// btnPreview
			// 
			this.btnPreview.Highlight = false;
			this.btnPreview.Location = new System.Drawing.Point(23, 354);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(131, 23);
			this.btnPreview.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnPreview.StyleManager = null;
			this.btnPreview.TabIndex = 3;
			this.btnPreview.Text = "Preview Download List";
			this.btnPreview.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Highlight = false;
			this.btnOK.Location = new System.Drawing.Point(321, 354);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnOK.StyleManager = null;
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Highlight = false;
			this.btnCancel.Location = new System.Drawing.Point(402, 354);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnCancel.StyleManager = null;
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// fileChooser1
			// 
			this.fileChooser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.fileChooser1.Color = MetroFramework.MetroColorStyle.Blue;
			this.fileChooser1.CustomBackground = false;
			this.fileChooser1.DefaultExt = "tdl";
			this.fileChooser1.Filter = "TorahDownloads List|*.tdl";
			this.fileChooser1.LabelText = "Choose download list file:";
			this.fileChooser1.Location = new System.Drawing.Point(23, 63);
			this.fileChooser1.Name = "fileChooser1";
			this.fileChooser1.Size = new System.Drawing.Size(454, 50);
			this.fileChooser1.Style = MetroFramework.MetroColorStyle.Blue;
			this.fileChooser1.StyleManager = null;
			this.fileChooser1.TabIndex = 2;
			this.fileChooser1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// scheduledDownloadEnabler1
			// 
			this.scheduledDownloadEnabler1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scheduledDownloadEnabler1.Location = new System.Drawing.Point(23, 177);
			this.scheduledDownloadEnabler1.Name = "scheduledDownloadEnabler1";
			this.scheduledDownloadEnabler1.Size = new System.Drawing.Size(454, 163);
			this.scheduledDownloadEnabler1.TabIndex = 1;
			// 
			// downloadFolder1
			// 
			this.downloadFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.downloadFolder1.Color = MetroFramework.MetroColorStyle.Blue;
			this.downloadFolder1.CustomBackground = false;
			this.downloadFolder1.LabelText = "Save downloaded files in:";
			this.downloadFolder1.Location = new System.Drawing.Point(23, 119);
			this.downloadFolder1.Name = "downloadFolder1";
			this.downloadFolder1.Size = new System.Drawing.Size(454, 52);
			this.downloadFolder1.Style = MetroFramework.MetroColorStyle.Blue;
			this.downloadFolder1.StyleManager = null;
			this.downloadFolder1.TabIndex = 0;
			this.downloadFolder1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// ImportFromTLFileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 400);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnPreview);
			this.Controls.Add(this.fileChooser1);
			this.Controls.Add(this.scheduledDownloadEnabler1);
			this.Controls.Add(this.downloadFolder1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "ImportFromTLFileForm";
			this.Resizable = false;
			this.Text = "Start Download";
			this.ResumeLayout(false);

		}

		#endregion

		private Core.UI.DownloadFolder downloadFolder1;
		private Extension.AutoDownloads.UI.ScheduledDownloadEnabler scheduledDownloadEnabler1;
		private Core.UI.FileChooser fileChooser1;
		private MetroFramework.Controls.MetroButton btnPreview;
		private MetroFramework.Controls.MetroButton btnOK;
		private MetroFramework.Controls.MetroButton btnCancel;
	}
}