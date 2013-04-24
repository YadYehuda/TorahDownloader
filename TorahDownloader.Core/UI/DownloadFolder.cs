using System;
using System.Windows.Forms;
using TorahDownloader.Core.Common;
using TorahDownloader.Core.Properties;

namespace TorahDownloader.Core.UI
{
	public partial class DownloadFolder : UserControl
	{
		public DownloadFolder()
		{
			InitializeComponent();

			Text = "Directory";

			txtSaveTo.Text = Settings.Default.DownloadFolder;
		}

		public string LabelText
		{
			get
			{
				return lblText.Text;
			}
			set
			{
				lblText.Text = value;
			}
		}

		public string Folder
		{
			get { return txtSaveTo.Text.GetWithDirectorySeparator(); }
		}

		private void btnSelAV_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txtSaveTo.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
