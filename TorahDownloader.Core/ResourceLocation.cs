using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TorahDownloader.Core
{
	[Serializable]
	public class ResourceLocation
	{
		#region Fields

		private string url;
		private Type protocolProviderType;
		private IProtocolProvider provider;

		#endregion

		#region Constructor
		public ResourceLocation()
		{
		}

		public static ResourceLocation FromURL(string url)
		{
			ResourceLocation rl = new ResourceLocation();
			rl.URL = url;
			return rl;
		}

		public static ResourceLocation[] FromURLArray(string[] urls)
		{
			List<ResourceLocation> result = new List<ResourceLocation>();

			foreach (string url in urls)
			{
				if (IsURL(url))
				{
					result.Add(ResourceLocation.FromURL(url));
				}
			}

			return result.ToArray();
		}

		public static ResourceLocation FromURL(
			string url,
			bool authenticate,
			string login,
			string password)
		{
			ResourceLocation rl = new ResourceLocation();
			rl.URL = url;
			rl.Authenticate = authenticate;
			rl.Login = login;
			rl.Password = password;
			return rl;
		}
		#endregion

		#region Properties

		public string URL
		{
			get { return url; }
			set
			{
				url = value;
				BindProtocolProviderType();
			}
		}

		public bool Authenticate { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }

		public string ProtocolProviderType
		{
			get
			{
				if (protocolProviderType == null)
				{
					return null;
				}
				return protocolProviderType.AssemblyQualifiedName;
			}
			set
			{
				if (value == null)
				{
					BindProtocolProviderType();
				}
				else
				{
					protocolProviderType = Type.GetType(value);
				}
			}
		}

		#endregion

		#region Methods

		public IProtocolProvider GetProtocolProvider(Downloader downloader)
		{
			return BindProtocolProviderInstance(downloader);
		}

		public void BindProtocolProviderType()
		{
			provider = null;

			if (!String.IsNullOrEmpty(this.URL))
			{
				protocolProviderType = ProtocolProviderFactory.GetProviderType(this.URL);
			}
		}

		public IProtocolProvider BindProtocolProviderInstance(Downloader downloader)
		{
			if (protocolProviderType == null)
			{
				BindProtocolProviderType();
			}

			if (provider == null)
			{
				provider = ProtocolProviderFactory.CreateProvider(protocolProviderType, downloader);
			}

			return provider;
		}

		public ResourceLocation Clone()
		{
			return (ResourceLocation)this.MemberwiseClone();
		}

		public override string ToString()
		{
			return this.URL;
		}

		public static bool IsURL(string url)
		{
			Match m = Regex.Match(url, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
			if (m.ToString() != string.Empty)
			{
				return true;
			}
			return false;
		}

		#endregion
	}
}
