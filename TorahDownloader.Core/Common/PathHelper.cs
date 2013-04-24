using System.IO;

namespace TorahDownloader.Core.Common
{
	public static class PathHelper
	{
		public static string GetWithDirectorySeparator(this string path)
		{
			return path.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
		}
	}
}
