using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.UI
{
	class StaticIcon : IconProvider
	{
		private static Size SizeFromEnum(EnumIconSize e)
		{
			switch (e)
			{
				case EnumIconSize.Large:
					return new Size(32, 32);
				case EnumIconSize.Small:
					return new Size(16, 16);
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private Icon GetGenericFileIcon(EnumIconSize size)
		{
			return new Icon(this.GetType().Assembly.GetManifestResourceStream("TorahDownloader.Resources.FileIcon.ico"), SizeFromEnum(size));
		}
		private Icon GetGenericFolderIcon(EnumIconSize size)
		{
			return new Icon(this.GetType().Assembly.GetManifestResourceStream("TorahDownloader.Resources.FolderIcon.ico"), SizeFromEnum(size));
		}

		public override Icon GetFileIcon(string filePath, EnumIconSize size, bool addLinkOverlay)
		{
			return GetGenericFileIcon(size);
		}

		public override Icon GetFileIconByExt(string fileExt, EnumIconSize size, bool addLinkOverlay)
		{
			return GetGenericFileIcon(size);
		}

		public override Icon GetFolderIcon(EnumIconSize size, EnumFolderType folderType)
		{
			return GetGenericFolderIcon(size);
		}

		public override Icon GetFolderIcon(string folderPath, EnumIconSize size, EnumFolderType folderType)
		{
			return GetGenericFolderIcon(size);
		}
	}
}
