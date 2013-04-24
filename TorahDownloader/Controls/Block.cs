using System;

namespace TorahDownloader.Controls
{
	[Serializable()]
	public class Block
	{
		public Block(float BlockSize, float PercentProgress)
		{
			this.BlockSize = BlockSize;
			this.PercentProgress = PercentProgress;
		}

		public float BlockSize {get; set;}

		public float PercentProgress { get; set; }
	}
}
