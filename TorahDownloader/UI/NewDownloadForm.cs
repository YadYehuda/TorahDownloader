using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using TorahDownloader.Core;
using TorahDownloader.Core.Common;
using TorahDownloader.Core.UI;

namespace TorahDownloader.UI
{
	public partial class NewDownloadForm : MetroForm
	{
		private bool FileIsValid = false;

		public NewDownloadForm()
		{
			InitializeComponent();
		}

		public string DownloadLocation
		{
			get
			{
				return txtFileName.Text;
			}
			set
			{
				txtFileName.Text = value;
			}
		}

		public string LocalFile
		{
			get { return PathHelper.GetWithBackslash(txtSaveLocation.Text); }
		}

		public bool StartNow
		{
			get
			{
				return true;
				//return chkStartNow.Checked;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				//ResourceLocation rl = this.DownloadLocation;

				//rl.BindProtocolProviderType();

				//if (rl.ProtocolProviderType == null)
				//{
				//	MessageBox.Show("Invalid URL format, please check the location field.",
				//		AppManager.Instance.Application.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

				//	DialogResult = DialogResult.None;
				//	return;
				//}

				Downloader download = DownloadManager.Instance.Add(
					null, //rl,
					null,
					this.LocalFile,
					0, //this.Segments,
					this.StartNow);

				Close();
			}
			catch (Exception)
			{
				DialogResult = DialogResult.None;

				MessageBox.Show("Unknown error, please check your input data.",
					AppManager.Instance.Application.MainForm.Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnChooseFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtFileName.Text = openFileDialog1.FileName;
			}
		}

		private void btnSaveLocation_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				txtSaveLocation.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}