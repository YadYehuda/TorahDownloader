using System;

namespace TorahDownloader
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			App.Instance.Start(args);
		}
	}
}
