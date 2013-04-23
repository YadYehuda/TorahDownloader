using System;
using System.ComponentModel;

namespace TorahDownloader.Core.Extensions
{
	public interface IExtensionParameters
	{
		event PropertyChangedEventHandler ParameterChanged;
	}
}
