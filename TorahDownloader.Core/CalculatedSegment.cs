using System;

namespace TorahDownloader.Core
{
	[Serializable]
	public struct CalculatedSegment
	{
		public long StartPosition { get; private set; }

		public long EndPosition { get; private set; }

		public CalculatedSegment(long startPos, long endPos) : this()
		{
			EndPosition = endPos;
			StartPosition = startPos;
		}
	}
}
