using MetroFramework.Controls;
using System;
using System.Windows.Forms;
using TorahDownloader.Core.Common;
using TorahDownloader.Core.Properties;

namespace TorahDownloader.Core.UI
{
	public partial class FileChooser : MetroUserControl
	{
		public FileChooser()
		{
			InitializeComponent();

			Text = "File";

			txtOpenFrom.Text = "";
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

		public string FileName
		{
			get { return txtOpenFrom.Text; }
		}

		private void btnSelAV_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtOpenFrom.Text = openFileDialog1.FileName;
			}
		}

		public string DefaultExt {
			get { return openFileDialog1.DefaultExt; }
			set { openFileDialog1.DefaultExt = value; }
		}

		public string Filter
		{
			get { return openFileDialog1.Filter; }
			set { openFileDialog1.Filter = value; }
		}

		public MetroFramework.MetroColorStyle Color
		{
			get { return txtOpenFrom.Style; }
			set
			{
				txtOpenFrom.Style = value;
				txtOpenFrom.UseStyleColors = true;
				btnSelAV.Style = value;
				btnSelAV.Highlight = true;

				this.Refresh();
			}
		}

		public void ClearColor()
		{
			txtOpenFrom.UseStyleColors = false;
			btnSelAV.Highlight = false;

			this.Refresh();
		}
	}
}
