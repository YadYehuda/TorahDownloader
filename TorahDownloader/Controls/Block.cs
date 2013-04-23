using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
