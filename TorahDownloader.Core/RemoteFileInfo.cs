using System;

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
