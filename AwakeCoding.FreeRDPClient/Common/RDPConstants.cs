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

		// PerformanceFlags
		public const int TS_PERF_DISABLE_NOTHING = 0x00000000; // No features are disabled.
		public const int TS_PERF_DISABLE_WALLPAPER = 0x00000001; // Wallpaper on the desktop is not displayed.
		public const int TS_PERF_DISABLE_FULLWINDOWDRAG = 0x00000002; // Full-window drag is disabled; only the window outline is displayed when the window is moved.
		public const int TS_PERF_DISABLE_MENUANIMATIONS = 0x00000004; // Menu animations are disabled.
		public const int TS_PERF_DISABLE_THEMING= 0x00000008; // Themes are disabled.
		public const int TS_PERF_ENABLE_ENHANCED_GRAPHICS = 0x00000010; // Enable enhanced graphics.
		public const int TS_PERF_DISABLE_CURSOR_SHADOW = 0x00000020; // No shadow is displayed for the cursor.
		public const int TS_PERF_DISABLE_CURSORSETTINGS = 0x00000040; // Cursor blinking is disabled.
		public const int TS_PERF_ENABLE_FONT_SMOOTHING = 0x00000080; // Enable font smoothing.
		public const int TS_PERF_ENABLE_DESKTOP_COMPOSITION = 0x00000100; // Enable desktop composition.
		public const int TS_PERF_DEFAULT_NONPERFCLIENT_SETTING = 0x40000000; // Set internally for clients not aware of this setting.
		public const uint TS_PERF_RESERVED1 = 0x80000000; // Reserved and used internally by the client.
	}


}
