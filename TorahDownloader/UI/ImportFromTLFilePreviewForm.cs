using MetroFramework.Forms;
using TorahDownloader.Core;

namespace TorahDownloader.UI
{
	public partial class ImportFromTLFilePreviewForm : MetroForm
	{
		public ImportFromTLFilePreviewForm(ResourceLocation[] locations)
		{
			InitializeComponent();

			listBox1.DataSource = locations;
		}
	}
}
