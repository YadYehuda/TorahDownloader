
namespace TorahDownloader.Core
{
	public interface ISegmentCalculator
	{
		CalculatedSegment[] GetSegments(int segmentCount, RemoteFileInfo fileSize);
	}
}
