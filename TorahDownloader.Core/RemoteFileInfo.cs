using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	[Serializable]
	public class RemoteFileInfo
	{
		public string MimeType { get; set; }

		public bool AcceptRanges { get; set; }

		public long FileSize { get; set; }

		public DateTime LastModified { get; set; }

	}
}
