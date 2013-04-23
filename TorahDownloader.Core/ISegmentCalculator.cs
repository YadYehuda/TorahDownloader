using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	public interface ISegmentCalculator
	{
		CalculatedSegment[] GetSegments(int segmentCount, RemoteFileInfo fileSize);
	}
}
