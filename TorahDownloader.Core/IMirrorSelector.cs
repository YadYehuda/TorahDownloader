using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	public interface IMirrorSelector
	{
		void Init(Downloader downloader);

		ResourceLocation GetNextResourceLocation();
	}
}
