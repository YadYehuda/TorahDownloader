using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TorahDownloader.Core
{
	public enum SegmentState
	{
		Idle,
		Connecting,
		Downloading,
		Paused,
		Finished,
		Error,
	}
}
