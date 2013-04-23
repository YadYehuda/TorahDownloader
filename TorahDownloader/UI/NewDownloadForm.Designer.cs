namespace TorahDownloader.UI
{
	partial class NewDownloadForm
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
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnChooseFile = new MetroFramework.Controls.MetroButton();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaveLocation = new System.Windows.Forms.TextBox();
			this.btnSaveLocation = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.Location = new System.Drawing.Point(23, 76);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(314, 20);
			this.txtFileName.TabIndex = 0;
			// 
			// btnChooseFile
			// 
			this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChooseFile.AutoSize = true;
			this.btnChooseFile.Highlight = false;
			this.btnChooseFile.Location = new System.Drawing.Point(343, 74);
			this.btnChooseFile.Name = "btnChooseFile";
			this.btnChooseFile.Size = new System.Drawing.Size(72, 23);
			this.btnChooseFile.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnChooseFile.StyleManager = null;
			this.btnChooseFile.TabIndex = 1;
			this.btnChooseFile.Text = "Browse ...";
			this.btnChooseFile.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Path to Download List (*.tdl)";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "tdl";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "TorahDownloads List|*.tdl";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyMusic;
			// 
			// btnOK
			// 
			this.btnOK.Highlight = true;
			this.btnOK.Location = new System.Drawing.Point(259, 299);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnOK.StyleManager = null;
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Highlight = false;
			this.btnCancel.Location = new System.Drawing.Point(340, 299);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnCancel.StyleManager = null;
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Location to save downloaded files";
			// 
			// txtSaveLocation
			// 
			this.txtSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveLocation.Location = new System.Drawing.Point(23, 129);
			this.txtSaveLocation.Name = "txtSaveLocation";
			this.txtSaveLocation.Size = new System.Drawing.Size(314, 20);
			this.txtSaveLocation.TabIndex = 6;
			// 
			// btnSaveLocation
			// 
			this.btnSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveLocation.AutoSize = true;
			this.btnSaveLocation.Highlight = false;
			this.btnSaveLocation.Location = new System.Drawing.Point(343, 127);
			this.btnSaveLocation.Name = "btnSaveLocation";
			this.btnSaveLocation.Size = new System.Drawing.Size(72, 23);
			this.btnSaveLocation.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnSaveLocation.StyleManager = null;
			this.btnSaveLocation.TabIndex = 7;
			this.btnSaveLocation.Text = "Browse ...";
			this.btnSaveLocation.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
			// 
			// NewDownloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 345);
			this.Controls.Add(this.btnSaveLocation);
			this.Controls.Add(this.txtSaveLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnChooseFile);
			this.Controls.Add(this.txtFileName);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "NewDownloadForm";
			this.Text = "New Download";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFileName;
		private MetroFramework.Controls.MetroButton btnChooseFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private MetroFramework.Controls.MetroButton btnOK;
		private MetroFramework.Controls.MetroButton btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaveLocation;
		private MetroFramework.Controls.MetroButton btnSaveLocation;
	}
}