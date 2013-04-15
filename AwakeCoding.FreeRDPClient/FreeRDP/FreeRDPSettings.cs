using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient.FreeRDP
{
	public sealed class FreeRDPSettings
	{
		private IntPtr wfi;

		public FreeRDPSettings(IntPtr wfi)
		{
			this.wfi = wfi;
		}

		public bool ServerMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 16);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 16, value);
			}
		}

		public uint ShareId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 17);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 17, value);
			}
		}

		public uint PduSource
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 18);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 18, value);
			}
		}

		public uint ServerPort
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 19);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 19, value);
			}
		}

		public string ServerHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 20);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 20, value);
			}
		}

		public string Username
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 21);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 21, value);
			}
		}

		public string Password
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 22);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 22, value);
			}
		}

		public string Domain
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 23);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 23, value);
			}
		}

		public uint RdpVersion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 128);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 128, value);
			}
		}

		public uint DesktopWidth
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 129);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 129, value);
			}
		}

		public uint DesktopHeight
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 130);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 130, value);
			}
		}

		public uint ColorDepth
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 131);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 131, value);
			}
		}

		public uint ConnectionType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 132);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 132, value);
			}
		}

		public uint ClientBuild
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 133);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 133, value);
			}
		}

		public string ClientHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 134);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 134, value);
			}
		}

		public string ClientProductId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 135);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 135, value);
			}
		}

		public uint EarlyCapabilityFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 136);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 136, value);
			}
		}

		public bool NetworkAutoDetect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 137);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 137, value);
			}
		}

		public bool SupportAsymetricKeys
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 138);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 138, value);
			}
		}

		public bool SupportErrorInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 139);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 139, value);
			}
		}

		public bool SupportStatusInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 140);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 140, value);
			}
		}

		public bool SupportMonitorLayoutPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 141);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 141, value);
			}
		}

		public bool SupportGraphicsPipeline
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 142);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 142, value);
			}
		}

		public bool SupportDynamicTimeZone
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 143);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 143, value);
			}
		}

		public bool DisableEncryption
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 192);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 192, value);
			}
		}

		public uint EncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 193);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 193, value);
			}
		}

		public uint ExtEncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 194);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 194, value);
			}
		}

		public uint EncryptionLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 195);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 195, value);
			}
		}

		public uint ChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 256);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 256, value);
			}
		}

		public uint ChannelDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 257);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 257, value);
			}
		}

		public uint ClusterInfoFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 320);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 320, value);
			}
		}

		public uint RedirectedSessionId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 321);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 321, value);
			}
		}

		public bool ConsoleSession
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 322);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 322, value);
			}
		}

		public uint MonitorDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 385);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 385, value);
			}
		}

		public bool SpanMonitors
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 387);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 387, value);
			}
		}

		public bool UseMultimon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 388);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 388, value);
			}
		}

		public bool ForceMultimon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 389);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 389, value);
			}
		}

		public uint MultitransportFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 512);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 512, value);
			}
		}

		public string AlternateShell
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 640);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 640, value);
			}
		}

		public string ShellWorkingDirectory
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 641);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 641, value);
			}
		}

		public bool AutoLogonEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 704);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 704, value);
			}
		}

		public bool CompressionEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 705);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 705, value);
			}
		}

		public bool DisableCtrlAltDel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 706);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 706, value);
			}
		}

		public bool EnableWindowsKey
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 707);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 707, value);
			}
		}

		public bool MaximizeShell
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 708);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 708, value);
			}
		}

		public bool LogonNotify
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 709);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 709, value);
			}
		}

		public bool LogonErrors
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 710);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 710, value);
			}
		}

		public bool MouseAttached
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 711);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 711, value);
			}
		}

		public bool MouseHasWheel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 712);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 712, value);
			}
		}

		public bool RemoteConsoleAudio
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 713);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 713, value);
			}
		}

		public bool AudioPlayback
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 714);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 714, value);
			}
		}

		public bool AudioCapture
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 715);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 715, value);
			}
		}

		public bool VideoDisable
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 716);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 716, value);
			}
		}

		public bool PasswordIsSmartcardPin
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 717);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 717, value);
			}
		}

		public bool UsingSavedCredentials
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 718);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 718, value);
			}
		}

		public bool ForceEncryptedCsPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 719);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 719, value);
			}
		}

		public bool IPv6Enabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 768);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 768, value);
			}
		}

		public string ClientAddress
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 769);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 769, value);
			}
		}

		public string ClientDir
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 770);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 770, value);
			}
		}

		public bool AutoReconnectionEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 832);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 832, value);
			}
		}

		public uint AutoReconnectMaxRetries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 833);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 833, value);
			}
		}

		public string DynamicDSTTimeZoneKeyName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 897);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 897, value);
			}
		}

		public bool DynamicDaylightTimeDisabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 898);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 898, value);
			}
		}

		public uint PerformanceFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 960);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 960, value);
			}
		}

		public bool AllowFontSmoothing
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 961);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 961, value);
			}
		}

		public bool DisableWallpaper
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 962);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 962, value);
			}
		}

		public bool DisableFullWindowDrag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 963);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 963, value);
			}
		}

		public bool DisableMenuAnims
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 964);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 964, value);
			}
		}

		public bool DisableThemes
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 965);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 965, value);
			}
		}

		public bool DisableCursorShadow
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 966);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 966, value);
			}
		}

		public bool DisableCursorBlinking
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 967);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 967, value);
			}
		}

		public bool AllowDesktopComposition
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 968);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 968, value);
			}
		}

		public bool TlsSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1088);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1088, value);
			}
		}

		public bool NlaSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1089);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1089, value);
			}
		}

		public bool RdpSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1090);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1090, value);
			}
		}

		public bool ExtSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1091);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1091, value);
			}
		}

		public bool Authentication
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1092);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1092, value);
			}
		}

		public uint RequestedProtocols
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1093);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1093, value);
			}
		}

		public uint SelectedProtocol
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1094);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1094, value);
			}
		}

		public uint NegotiationFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1095);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1095, value);
			}
		}

		public bool NegotiateSecurityLayer
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1096);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1096, value);
			}
		}

		public bool MstscCookieMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1152);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1152, value);
			}
		}

		public uint CookieMaxLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1153);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1153, value);
			}
		}

		public uint PreconnectionId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1154);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1154, value);
			}
		}

		public string PreconnectionBlob
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1155);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1155, value);
			}
		}

		public bool SendPreconnectionPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1156);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1156, value);
			}
		}

		public uint RedirectionFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1216);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1216, value);
			}
		}

		public uint LoadBalanceInfoLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1218);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1218, value);
			}
		}

		public uint RedirectionUsernameLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1220);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1220, value);
			}
		}

		public uint RedirectionDomainLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1222);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1222, value);
			}
		}

		public uint RedirectionPasswordLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1224);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1224, value);
			}
		}

		public uint RedirectionTargetFQDNLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1226);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1226, value);
			}
		}

		public uint RedirectionTargetNetBiosNameLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1228);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1228, value);
			}
		}

		public uint RedirectionTsvUrlLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1230);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1230, value);
			}
		}

		public uint TargetNetAddressCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1231);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1231, value);
			}
		}

		public string KerberosKdc
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1344);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1344, value);
			}
		}

		public string KerberosRealm
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1345);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1345, value);
			}
		}

		public bool IgnoreCertificate
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1408);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1408, value);
			}
		}

		public string CertificateName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1409);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1409, value);
			}
		}

		public string CertificateFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1410);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1410, value);
			}
		}

		public string PrivateKeyFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1411);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1411, value);
			}
		}

		public string RdpKeyFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1412);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1412, value);
			}
		}

		public bool Workarea
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1536);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1536, value);
			}
		}

		public bool Fullscreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1537);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1537, value);
			}
		}

		public uint PercentScreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1538);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1538, value);
			}
		}

		public bool GrabKeyboard
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1539);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1539, value);
			}
		}

		public bool Decorations
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1540);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1540, value);
			}
		}

		public bool MouseMotion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1541);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1541, value);
			}
		}

		public string WindowTitle
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1542);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1542, value);
			}
		}

		public ulong ParentWindowId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint64(wfi, 1543);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint64(wfi, 1543, value);
			}
		}

		public bool AsyncInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1544);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1544, value);
			}
		}

		public bool AsyncUpdate
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1545);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1545, value);
			}
		}

		public bool AsyncChannels
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1546);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1546, value);
			}
		}

		public bool AsyncTransport
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1547);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1547, value);
			}
		}

		public bool ToggleFullscreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1548);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1548, value);
			}
		}

		public string WmClass
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1549);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1549, value);
			}
		}

		public bool EmbeddedWindow
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1550);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1550, value);
			}
		}

		public bool SmartSizing
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1551);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1551, value);
			}
		}

		public bool SoftwareGdi
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1601);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1601, value);
			}
		}

		public bool LocalConnection
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1602);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1602, value);
			}
		}

		public bool AuthenticationOnly
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1603);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1603, value);
			}
		}

		public bool CredentialsFromStdin
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1604);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1604, value);
			}
		}

		public string ComputerName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1664);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1664, value);
			}
		}

		public string ConnectionFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1728);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1728, value);
			}
		}

		public string HomePath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1792);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1792, value);
			}
		}

		public string ConfigPath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1793);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1793, value);
			}
		}

		public string CurrentPath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1794);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1794, value);
			}
		}

		public bool DumpRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1856);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1856, value);
			}
		}

		public bool PlayRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1857);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1857, value);
			}
		}

		public string DumpRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1858);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1858, value);
			}
		}

		public string PlayRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1859);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1859, value);
			}
		}

		public bool GatewayUsageMethod
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1984);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1984, value);
			}
		}

		public uint GatewayPort
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1985);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1985, value);
			}
		}

		public string GatewayHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1986);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1986, value);
			}
		}

		public string GatewayUsername
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1987);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1987, value);
			}
		}

		public string GatewayPassword
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1988);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1988, value);
			}
		}

		public string GatewayDomain
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 1989);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 1989, value);
			}
		}

		public uint GatewayCredentialsSource
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 1990);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 1990, value);
			}
		}

		public bool GatewayUseSameCredentials
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 1991);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 1991, value);
			}
		}

		public bool RemoteApplicationMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2112);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2112, value);
			}
		}

		public string RemoteApplicationName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2113);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2113, value);
			}
		}

		public string RemoteApplicationIcon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2114);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2114, value);
			}
		}

		public string RemoteApplicationProgram
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2115);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2115, value);
			}
		}

		public string RemoteApplicationFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2116);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2116, value);
			}
		}

		public string RemoteApplicationGuid
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2117);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2117, value);
			}
		}

		public string RemoteApplicationCmdLine
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2118);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2118, value);
			}
		}

		public uint RemoteAppNumIconCaches
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2122);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2122, value);
			}
		}

		public uint RemoteAppNumIconCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2123);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2123, value);
			}
		}

		public bool RemoteAppLanguageBarSupported
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2124);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2124, value);
			}
		}

		public uint ReceivedCapabilitiesSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2241);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2241, value);
			}
		}

		public uint OsMajorType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2304);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2304, value);
			}
		}

		public uint OsMinorType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2305);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2305, value);
			}
		}

		public bool RefreshRect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2306);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2306, value);
			}
		}

		public bool SuppressOutput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2307);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2307, value);
			}
		}

		public bool FastPathOutput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2308);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2308, value);
			}
		}

		public bool SaltedChecksum
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2309);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2309, value);
			}
		}

		public bool LongCredentialsSupported
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2310);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2310, value);
			}
		}

		public bool NoBitmapCompressionHeader
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2311);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2311, value);
			}
		}

		public bool DesktopResize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2368);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2368, value);
			}
		}

		public bool DrawAllowDynamicColorFidelity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2369);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2369, value);
			}
		}

		public bool DrawAllowColorSubsampling
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2370);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2370, value);
			}
		}

		public bool DrawAllowSkipAlpha
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2371);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2371, value);
			}
		}

		public bool BitmapCacheV3Enabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2433);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2433, value);
			}
		}

		public bool AltSecFrameMarkerSupport
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2434);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2434, value);
			}
		}

		public bool BitmapCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2497);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2497, value);
			}
		}

		public uint BitmapCacheVersion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2498);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2498, value);
			}
		}

		public bool AllowCacheWaitingList
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2499);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2499, value);
			}
		}

		public bool BitmapCachePersistEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2500);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2500, value);
			}
		}

		public uint BitmapCacheV2NumCells
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2501);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2501, value);
			}
		}

		public bool ColorPointerFlag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2560);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2560, value);
			}
		}

		public uint PointerCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2561);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2561, value);
			}
		}

		public uint KeyboardLayout
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2624);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2624, value);
			}
		}

		public uint KeyboardType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2625);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2625, value);
			}
		}

		public uint KeyboardSubType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2626);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2626, value);
			}
		}

		public uint KeyboardFunctionKey
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2627);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2627, value);
			}
		}

		public string ImeFileName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 2628);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 2628, value);
			}
		}

		public bool UnicodeInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2629);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2629, value);
			}
		}

		public bool FastPathInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2630);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2630, value);
			}
		}

		public uint BrushSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2688);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2688, value);
			}
		}

		public uint GlyphSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2752);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2752, value);
			}
		}

		public uint OffscreenSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2816);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2816, value);
			}
		}

		public uint OffscreenCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2817);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2817, value);
			}
		}

		public uint OffscreenCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2818);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2818, value);
			}
		}

		public uint VirtualChannelCompressionFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2880);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2880, value);
			}
		}

		public uint VirtualChannelChunkSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 2881);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 2881, value);
			}
		}

		public bool SoundBeepsEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 2944);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 2944, value);
			}
		}

		public uint MultifragMaxRequestSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3328);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3328, value);
			}
		}

		public uint LargePointerFlag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3392);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3392, value);
			}
		}

		public uint CompDeskSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3456);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3456, value);
			}
		}

		public bool SurfaceCommandsEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3520);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3520, value);
			}
		}

		public bool FrameMarkerCommandEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3521);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3521, value);
			}
		}

		public bool RemoteFxOnly
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3648);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3648, value);
			}
		}

		public bool RemoteFxCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3649);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3649, value);
			}
		}

		public uint RemoteFxCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3650);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3650, value);
			}
		}

		public uint RemoteFxCodecMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3651);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3651, value);
			}
		}

		public bool RemoteFxImageCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3652);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3652, value);
			}
		}

		public uint RemoteFxCaptureFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3653);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3653, value);
			}
		}

		public bool NSCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3712);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3712, value);
			}
		}

		public uint NSCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3713);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3713, value);
			}
		}

		public bool FrameAcknowledge
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3714);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3714, value);
			}
		}

		public bool JpegCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3776);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3776, value);
			}
		}

		public uint JpegCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3777);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3777, value);
			}
		}

		public uint JpegQuality
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3778);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3778, value);
			}
		}

		public uint BitmapCacheV3CodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3904);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3904, value);
			}
		}

		public bool DrawNineGridEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 3968);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 3968, value);
			}
		}

		public uint DrawNineGridCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3969);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3969, value);
			}
		}

		public uint DrawNineGridCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 3970);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 3970, value);
			}
		}

		public bool DrawGdiPlusEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4032);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4032, value);
			}
		}

		public bool DrawGdiPlusCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4033);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4033, value);
			}
		}

		public bool DeviceRedirection
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4160);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4160, value);
			}
		}

		public uint DeviceCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 4161);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 4161, value);
			}
		}

		public uint DeviceArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 4162);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 4162, value);
			}
		}

		public bool RedirectDrives
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4288);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4288, value);
			}
		}

		public bool RedirectHomeDrive
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4289);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4289, value);
			}
		}

		public string DrivesToRedirect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, 4290);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, 4290, value);
			}
		}

		public bool RedirectSmartCards
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4416);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4416, value);
			}
		}

		public bool RedirectPrinters
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4544);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4544, value);
			}
		}

		public bool RedirectSerialPorts
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4672);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4672, value);
			}
		}

		public bool RedirectParallelPorts
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4673);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4673, value);
			}
		}

		public bool RedirectClipboard
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, 4800);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, 4800, value);
			}
		}

		public uint StaticChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 4928);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 4928, value);
			}
		}

		public uint StaticChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 4929);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 4929, value);
			}
		}

		public uint DynamicChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 5056);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 5056, value);
			}
		}

		public uint DynamicChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, 5057);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, 5057, value);
			}
		}

	}
}
