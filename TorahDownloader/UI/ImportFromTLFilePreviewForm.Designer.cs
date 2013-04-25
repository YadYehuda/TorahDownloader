namespace TorahDownloader.UI
{
	partial class ImportFromTLFilePreviewForm
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
			this.button1 = new MetroFramework.Controls.MetroButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Highlight = false;
			this.button1.Location = new System.Drawing.Point(388, 286);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.Style = MetroFramework.MetroColorStyle.Blue;
			this.button1.StyleManager = null;
			this.button1.TabIndex = 0;
			this.button1.Text = "Close";
			this.button1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(23, 63);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(440, 212);
			this.listBox1.TabIndex = 1;
			// 
			// ImportFromTLFilePreviewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 332);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "ImportFromTLFilePreviewForm";
			this.Text = "Preview - Files to Download";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton button1;
		private System.Windows.Forms.ListBox listBox1;
	}
}