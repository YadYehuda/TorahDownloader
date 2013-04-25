using MetroFramework.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TorahDownloader.Core;
using TorahDownloader.Core.UI;

namespace TorahDownloader.UI
{
	public partial class ImportFromTLFileForm : MetroForm
	{
		public ImportFromTLFileForm()
		{
			InitializeComponent();
		}

		public string DownloadPath
		{
			get { return downloadFolder1.Folder; }
		}

		public ResourceLocation[] URLs
		{
			get
			{
				List<ResourceLocation> urls = new List<ResourceLocation>();

				if (IsValid())
				{
					// TODO: FILL THE LIST HERE!!!!
					JsonTextReader jtr = new JsonTextReader(File.OpenText(fileChooser1.FileName));
					var data = (new JsonSerializer()).Deserialize<dynamic>(jtr);

					foreach (var item in data.files)
					{
						urls.Add(new ResourceLocation() {
							URL = item.location,
							FileName = item.filename
						});
					}
				}

				return urls.ToArray();
			}
		}

		public void ApplySettings()
		{
			scheduledDownloadEnabler1.ApplySettings();
		}

		private bool IsValid()
		{
			if (!File.Exists(fileChooser1.FileName))
			{
				MessageBox.Show("Invalid file name.",
					AppManager.Instance.Application.MainForm.Text,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				fileChooser1.Color = MetroFramework.MetroColorStyle.Red;
				return false;
			}

			fileChooser1.ClearColor();
			return true;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (!IsValid())
			{
				DialogResult = DialogResult.None;
				return;
			}
		}

		private void btnPreview_Click(object sender, System.EventArgs e)
		{
			if (IsValid())
			{
				using (ImportFromTLFilePreviewForm preview = new ImportFromTLFilePreviewForm(this.URLs))
				{
					preview.ShowDialog();
				}
			}
		}
	}
}
