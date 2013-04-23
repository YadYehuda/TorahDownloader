using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	public interface IProtocolProvider
	{
		// TODO: remove this method?
		void Initialize(Downloader downloader);

		Stream CreateStream(ResourceLocation rl, long initialPosition, long endPosition);

		RemoteFileInfo GetFileInfo(ResourceLocation rl, out Stream stream);
	}
}
