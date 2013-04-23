using System.Drawing;
using System.Windows.Forms;

namespace TorahDownloader.UI
{
	public class FileTypeImageList
	{
		private const string OpenFolderKey = "OpenFolderKey";
		private const string CloseFolderKey = "OpenFolderKey";

		private static ImageList instance;

		public static ImageList GetSharedInstance()
		{
			if (instance == null)
			{
				instance = new ImageList();
				instance.TransparentColor = Color.Black;
				instance.TransparentColor = Color.Transparent;
				instance.ColorDepth = ColorDepth.Depth32Bit;
				instance.ImageSize = new Size(16, 16);
			}

			return instance;
		}

		public static int GetImageIndexByExtention(string ext)
		{
			GetSharedInstance();

			ext = ext.ToLower();

			if (!instance.Images.ContainsKey(ext))
			{
				//Icon iconForFile = IconExtractor.Extract(ext);
				Icon iconForFile = IconProvider.Instance().GetFileIconByExt(ext, IconProvider.EnumIconSize.Small, false);

				instance.Images.Add(ext, iconForFile);
			}

			return instance.Images.IndexOfKey(ext);
		}

		public static int GetImageIndexFromFolder(bool open)
		{
			string key;

			GetSharedInstance();

			if (open)
			{
				key = OpenFolderKey;
			}
			else
			{
				key = CloseFolderKey;
			}

			if (!instance.Images.ContainsKey(key))
			{
				Icon iconForFile = IconProvider.Instance().GetFolderIcon(
					IconProvider.EnumIconSize.Small,
					(open ? IconProvider.EnumFolderType.Open : IconProvider.EnumFolderType.Closed));

				instance.Images.Add(key, iconForFile);
			}

			return instance.Images.IndexOfKey(key);
		}
	}
}
