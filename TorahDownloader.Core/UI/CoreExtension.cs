using TorahDownloader.Core.Extensions;

namespace TorahDownloader.Core.UI
{
	public class CoreExtension : IExtension
	{
		#region IExtension Members

		public string Name
		{
			get { return "Core"; }
		}

		public IUIExtension UIExtension
		{
			get { return new CoreUIExtension(); }
		}

		#endregion
	}
}
