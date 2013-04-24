
namespace TorahDownloader.Core
{
	public interface IMirrorSelector
	{
		void Init(Downloader downloader);

		ResourceLocation GetNextResourceLocation();
	}
}
