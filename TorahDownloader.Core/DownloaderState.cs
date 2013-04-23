using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	public enum DownloaderState : byte
	{
		NeedToPrepare = 0,
		Preparing,
		WaitingForReconnect,
		Prepared,
		Working,
		Pausing,
		Paused,
		Ended,
		EndedWithError
	}
}
