using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.UI
{
	public abstract class IconProvider
	{
		///
		/// size of the icon
		///
		public enum EnumIconSize
		{
			/// 32x32
			Large = 0,
			/// 16x16
			Small = 1
		}

		///
		/// state of the folder
		///
		public enum EnumFolderType
		{
			/// open folder
			Open = 0,
			/// closed folder
			Closed = 1
		}

		public abstract Icon GetFileIcon(string filePath, EnumIconSize size, bool addLinkOverlay);

		public abstract Icon GetFileIconByExt(string fileExt, EnumIconSize size, bool addLinkOverlay);

		public abstract Icon GetFolderIcon(EnumIconSize size, EnumFolderType folderType);

		public abstract Icon GetFolderIcon(string folderPath, EnumIconSize size, EnumFolderType folderType);

		private static IconProvider _instance;
		public static IconProvider Instance()
		{
			if (_instance == null)
			{
				// We can only use the IconReader on platforms that are known to support it!
				OperatingSystem os = Environment.OSVersion;
				PlatformID pid = os.Platform;
				switch (pid)
				{
					case PlatformID.Win32NT:
					case PlatformID.Win32S:
					case PlatformID.Win32Windows:
					case PlatformID.WinCE:
						_instance = new IconReader();
						break;
					default:
						_instance = new StaticIcon();
						break;
				}
			}

			return _instance;
		}
	}
}
