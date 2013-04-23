namespace TorahDownloader.Core.Extensions
{
	public interface IExtension
	{
		string Name { get; }

		IUIExtension UIExtension { get; }
	}
}
