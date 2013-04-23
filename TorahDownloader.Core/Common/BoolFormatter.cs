using System;
using System.Text;

namespace TorahDownloader.Core.Common
{
	public static class BoolFormatter
	{
		private const string Yes = "Yes";
		private const string No = "No";

		public static bool FromString(string s)
		{
			return (s == Yes);
		}

		public static string ToString(this bool v)
		{
			return v ? Yes : No;
		}
	}
}
