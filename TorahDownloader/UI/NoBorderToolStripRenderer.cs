using System.Windows.Forms;

namespace TorahDownloader.UI
{
	class NoBorderToolStripRenderer : ToolStripSystemRenderer
	{
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			// No-Op gets rid of the border.
			//base.OnRenderToolStripBorder(e);
		}
	}
}
