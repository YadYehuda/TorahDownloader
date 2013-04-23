using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TorahDownloader.Core.Extensions;

namespace TorahDownloader.Core.UI
{
	public interface IApp : IDisposable
	{
		Form MainForm { get; }

		NotifyIcon NotifyIcon { get; }

		List<IExtension> Extensions { get; }

		IExtension GetExtensionByType(Type type);

		void Start(string[] args);
	}
}
