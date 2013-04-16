using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.Common
{
	/// <summary>
	/// RDP Constants for compatibility with MS ActiveX component
	/// </summary>
	public static class RDPConstants
	{
		// GatewayUsageMethod
		public const uint TSC_PROXY_MODE_NONE_DIRECT = 0;
		public const uint TSC_PROXY_MODE_DIRECT = 1;
		public const uint TSC_PROXY_MODE_DETECT = 2;
		public const uint TSC_PROXY_MODE_DEFAULT = 3;
		public const uint TSC_PROXY_MODE_NONE_DETECT = 4;

		// GatewayProfileUsageMethod
		public const uint TSC_PROXY_PROFILE_MODE_DEFAULT = 0;
		public const uint TSC_PROXY_PROFILE_MODE_EXPLICIT = 1;

		// AudioRedirectionMode
		public const uint AUDIO_MODE_REDIRECT = 0;
		public const uint AUDIO_MODE_PLAY_ON_SERVER = 1;
		public const uint AUDIO_MODE_NONE = 2;
	}


}
