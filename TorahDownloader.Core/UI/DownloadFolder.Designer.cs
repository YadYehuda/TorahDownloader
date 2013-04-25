namespace TorahDownloader.Core.UI
{
	partial class DownloadFolder
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSelAV = new MetroFramework.Controls.MetroButton();
			this.txtSaveTo = new MetroFramework.Controls.MetroTextBox();
			this.lblText = new MetroFramework.Controls.MetroLabel();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// btnSelAV
			// 
			this.btnSelAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelAV.Highlight = false;
			this.btnSelAV.Location = new System.Drawing.Point(327, 21);
			this.btnSelAV.Name = "btnSelAV";
			this.btnSelAV.Size = new System.Drawing.Size(26, 23);
			this.btnSelAV.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnSelAV.StyleManager = null;
			this.btnSelAV.TabIndex = 2;
			this.btnSelAV.Text = "...";
			this.btnSelAV.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnSelAV.Click += new System.EventHandler(this.btnSelAV_Click);
			// 
			// txtSaveTo
			// 
			this.txtSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveTo.CustomBackground = false;
			this.txtSaveTo.CustomForeColor = false;
			this.txtSaveTo.FontSize = MetroFramework.MetroTextBoxSize.Small;
			this.txtSaveTo.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
			this.txtSaveTo.Location = new System.Drawing.Point(3, 22);
			this.txtSaveTo.Multiline = false;
			this.txtSaveTo.Name = "txtSaveTo";
			this.txtSaveTo.SelectedText = "";
			this.txtSaveTo.Size = new System.Drawing.Size(321, 20);
			this.txtSaveTo.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSaveTo.StyleManager = null;
			this.txtSaveTo.TabIndex = 1;
			this.txtSaveTo.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSaveTo.UseStyleColors = false;
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.BackColor = System.Drawing.SystemColors.Control;
			this.lblText.CustomBackground = false;
			this.lblText.CustomForeColor = false;
			this.lblText.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.lblText.FontWeight = MetroFramework.MetroLabelWeight.Light;
			this.lblText.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.lblText.Location = new System.Drawing.Point(3, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(155, 19);
			this.lblText.Style = MetroFramework.MetroColorStyle.Blue;
			this.lblText.StyleManager = null;
			this.lblText.TabIndex = 0;
			this.lblText.Text = "Default download folder:";
			this.lblText.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lblText.UseStyleColors = false;
			// 
			// DownloadFolder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnSelAV);
			this.Controls.Add(this.txtSaveTo);
			this.Controls.Add(this.lblText);
			this.Name = "DownloadFolder";
			this.Size = new System.Drawing.Size(356, 50);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnSelAV;
		private MetroFramework.Controls.MetroTextBox txtSaveTo;
		private MetroFramework.Controls.MetroLabel lblText;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}
