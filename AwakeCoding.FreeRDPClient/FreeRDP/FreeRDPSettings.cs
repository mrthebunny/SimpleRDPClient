using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient.FreeRDP
{
	public sealed class FreeRDPSettings
	{
		public enum Keys
		{
			ServerMode = 16,
			ShareId = 17,
			PduSource = 18,
			ServerPort = 19,
			ServerHostname = 20,
			Username = 21,
			Password = 22,
			Domain = 23,
			RdpVersion = 128,
			DesktopWidth = 129,
			DesktopHeight = 130,
			ColorDepth = 131,
			ConnectionType = 132,
			ClientBuild = 133,
			ClientHostname = 134,
			ClientProductId = 135,
			EarlyCapabilityFlags = 136,
			NetworkAutoDetect = 137,
			SupportAsymetricKeys = 138,
			SupportErrorInfoPdu = 139,
			SupportStatusInfoPdu = 140,
			SupportMonitorLayoutPdu = 141,
			SupportGraphicsPipeline = 142,
			SupportDynamicTimeZone = 143,
			DisableEncryption = 192,
			EncryptionMethods = 193,
			ExtEncryptionMethods = 194,
			EncryptionLevel = 195,
			ChannelCount = 256,
			ChannelDefArraySize = 257,
			ClusterInfoFlags = 320,
			RedirectedSessionId = 321,
			ConsoleSession = 322,
			MonitorDefArraySize = 385,
			SpanMonitors = 387,
			UseMultimon = 388,
			ForceMultimon = 389,
			MultitransportFlags = 512,
			AlternateShell = 640,
			ShellWorkingDirectory = 641,
			AutoLogonEnabled = 704,
			CompressionEnabled = 705,
			DisableCtrlAltDel = 706,
			EnableWindowsKey = 707,
			MaximizeShell = 708,
			LogonNotify = 709,
			LogonErrors = 710,
			MouseAttached = 711,
			MouseHasWheel = 712,
			RemoteConsoleAudio = 713,
			AudioPlayback = 714,
			AudioCapture = 715,
			VideoDisable = 716,
			PasswordIsSmartcardPin = 717,
			UsingSavedCredentials = 718,
			ForceEncryptedCsPdu = 719,
			IPv6Enabled = 768,
			ClientAddress = 769,
			ClientDir = 770,
			AutoReconnectionEnabled = 832,
			AutoReconnectMaxRetries = 833,
			DynamicDSTTimeZoneKeyName = 897,
			DynamicDaylightTimeDisabled = 898,
			PerformanceFlags = 960,
			AllowFontSmoothing = 961,
			DisableWallpaper = 962,
			DisableFullWindowDrag = 963,
			DisableMenuAnims = 964,
			DisableThemes = 965,
			DisableCursorShadow = 966,
			DisableCursorBlinking = 967,
			AllowDesktopComposition = 968,
			TlsSecurity = 1088,
			NlaSecurity = 1089,
			RdpSecurity = 1090,
			ExtSecurity = 1091,
			Authentication = 1092,
			RequestedProtocols = 1093,
			SelectedProtocol = 1094,
			NegotiationFlags = 1095,
			NegotiateSecurityLayer = 1096,
			MstscCookieMode = 1152,
			CookieMaxLength = 1153,
			PreconnectionId = 1154,
			PreconnectionBlob = 1155,
			SendPreconnectionPdu = 1156,
			RedirectionFlags = 1216,
			LoadBalanceInfoLength = 1218,
			RedirectionUsernameLength = 1220,
			RedirectionDomainLength = 1222,
			RedirectionPasswordLength = 1224,
			RedirectionTargetFQDNLength = 1226,
			RedirectionTargetNetBiosNameLength = 1228,
			RedirectionTsvUrlLength = 1230,
			TargetNetAddressCount = 1231,
			KerberosKdc = 1344,
			KerberosRealm = 1345,
			IgnoreCertificate = 1408,
			CertificateName = 1409,
			CertificateFile = 1410,
			PrivateKeyFile = 1411,
			RdpKeyFile = 1412,
			Workarea = 1536,
			Fullscreen = 1537,
			PercentScreen = 1538,
			GrabKeyboard = 1539,
			Decorations = 1540,
			MouseMotion = 1541,
			WindowTitle = 1542,
			ParentWindowId = 1543,
			AsyncInput = 1544,
			AsyncUpdate = 1545,
			AsyncChannels = 1546,
			AsyncTransport = 1547,
			ToggleFullscreen = 1548,
			WmClass = 1549,
			EmbeddedWindow = 1550,
			SmartSizing = 1551,
			SoftwareGdi = 1601,
			LocalConnection = 1602,
			AuthenticationOnly = 1603,
			CredentialsFromStdin = 1604,
			ComputerName = 1664,
			ConnectionFile = 1728,
			HomePath = 1792,
			ConfigPath = 1793,
			CurrentPath = 1794,
			DumpRemoteFx = 1856,
			PlayRemoteFx = 1857,
			DumpRemoteFxFile = 1858,
			PlayRemoteFxFile = 1859,
			GatewayUsageMethod = 1984,
			GatewayPort = 1985,
			GatewayHostname = 1986,
			GatewayUsername = 1987,
			GatewayPassword = 1988,
			GatewayDomain = 1989,
			GatewayCredentialsSource = 1990,
			GatewayUseSameCredentials = 1991,
			RemoteApplicationMode = 2112,
			RemoteApplicationName = 2113,
			RemoteApplicationIcon = 2114,
			RemoteApplicationProgram = 2115,
			RemoteApplicationFile = 2116,
			RemoteApplicationGuid = 2117,
			RemoteApplicationCmdLine = 2118,
			RemoteAppNumIconCaches = 2122,
			RemoteAppNumIconCacheEntries = 2123,
			RemoteAppLanguageBarSupported = 2124,
			ReceivedCapabilitiesSize = 2241,
			OsMajorType = 2304,
			OsMinorType = 2305,
			RefreshRect = 2306,
			SuppressOutput = 2307,
			FastPathOutput = 2308,
			SaltedChecksum = 2309,
			LongCredentialsSupported = 2310,
			NoBitmapCompressionHeader = 2311,
			DesktopResize = 2368,
			DrawAllowDynamicColorFidelity = 2369,
			DrawAllowColorSubsampling = 2370,
			DrawAllowSkipAlpha = 2371,
			BitmapCacheV3Enabled = 2433,
			AltSecFrameMarkerSupport = 2434,
			BitmapCacheEnabled = 2497,
			BitmapCacheVersion = 2498,
			AllowCacheWaitingList = 2499,
			BitmapCachePersistEnabled = 2500,
			BitmapCacheV2NumCells = 2501,
			ColorPointerFlag = 2560,
			PointerCacheSize = 2561,
			KeyboardLayout = 2624,
			KeyboardType = 2625,
			KeyboardSubType = 2626,
			KeyboardFunctionKey = 2627,
			ImeFileName = 2628,
			UnicodeInput = 2629,
			FastPathInput = 2630,
			BrushSupportLevel = 2688,
			GlyphSupportLevel = 2752,
			OffscreenSupportLevel = 2816,
			OffscreenCacheSize = 2817,
			OffscreenCacheEntries = 2818,
			VirtualChannelCompressionFlags = 2880,
			VirtualChannelChunkSize = 2881,
			SoundBeepsEnabled = 2944,
			MultifragMaxRequestSize = 3328,
			LargePointerFlag = 3392,
			CompDeskSupportLevel = 3456,
			SurfaceCommandsEnabled = 3520,
			FrameMarkerCommandEnabled = 3521,
			RemoteFxOnly = 3648,
			RemoteFxCodec = 3649,
			RemoteFxCodecId = 3650,
			RemoteFxCodecMode = 3651,
			RemoteFxImageCodec = 3652,
			RemoteFxCaptureFlags = 3653,
			NSCodec = 3712,
			NSCodecId = 3713,
			FrameAcknowledge = 3714,
			JpegCodec = 3776,
			JpegCodecId = 3777,
			JpegQuality = 3778,
			BitmapCacheV3CodecId = 3904,
			DrawNineGridEnabled = 3968,
			DrawNineGridCacheSize = 3969,
			DrawNineGridCacheEntries = 3970,
			DrawGdiPlusEnabled = 4032,
			DrawGdiPlusCacheEnabled = 4033,
			DeviceRedirection = 4160,
			DeviceCount = 4161,
			DeviceArraySize = 4162,
			RedirectDrives = 4288,
			RedirectHomeDrive = 4289,
			DrivesToRedirect = 4290,
			RedirectSmartCards = 4416,
			RedirectPrinters = 4544,
			RedirectSerialPorts = 4672,
			RedirectParallelPorts = 4673,
			RedirectClipboard = 4800,
			StaticChannelCount = 4928,
			StaticChannelArraySize = 4929,
			DynamicChannelCount = 5056,
			DynamicChannelArraySize = 5057
		}
	
		private IntPtr settings;

		public FreeRDPSettings(IntPtr wfi)
		{
			this.settings = NativeMethods.freerdp_client_get_settings(wfi);
		}

		public bool ServerMode
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ServerMode);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ServerMode, value);
			}
		}

		public uint ShareId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ShareId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ShareId, value);
			}
		}

		public uint PduSource
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.PduSource);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.PduSource, value);
			}
		}

		public uint ServerPort
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ServerPort);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ServerPort, value);
			}
		}

		public string ServerHostname
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ServerHostname);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ServerHostname, value);
			}
		}

		public string Username
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.Username);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.Username, value);
			}
		}

		public string Password
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.Password);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.Password, value);
			}
		}

		public string Domain
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.Domain);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.Domain, value);
			}
		}

		public uint RdpVersion
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RdpVersion);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RdpVersion, value);
			}
		}

		public uint DesktopWidth
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DesktopWidth);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DesktopWidth, value);
			}
		}

		public uint DesktopHeight
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DesktopHeight);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DesktopHeight, value);
			}
		}

		public uint ColorDepth
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ColorDepth);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ColorDepth, value);
			}
		}

		public uint ConnectionType
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ConnectionType);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ConnectionType, value);
			}
		}

		public uint ClientBuild
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ClientBuild);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ClientBuild, value);
			}
		}

		public string ClientHostname
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ClientHostname);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ClientHostname, value);
			}
		}

		public string ClientProductId
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ClientProductId);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ClientProductId, value);
			}
		}

		public uint EarlyCapabilityFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.EarlyCapabilityFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.EarlyCapabilityFlags, value);
			}
		}

		public bool NetworkAutoDetect
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.NetworkAutoDetect);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.NetworkAutoDetect, value);
			}
		}

		public bool SupportAsymetricKeys
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportAsymetricKeys);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportAsymetricKeys, value);
			}
		}

		public bool SupportErrorInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportErrorInfoPdu);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportErrorInfoPdu, value);
			}
		}

		public bool SupportStatusInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportStatusInfoPdu);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportStatusInfoPdu, value);
			}
		}

		public bool SupportMonitorLayoutPdu
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportMonitorLayoutPdu);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportMonitorLayoutPdu, value);
			}
		}

		public bool SupportGraphicsPipeline
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportGraphicsPipeline);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportGraphicsPipeline, value);
			}
		}

		public bool SupportDynamicTimeZone
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SupportDynamicTimeZone);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SupportDynamicTimeZone, value);
			}
		}

		public bool DisableEncryption
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableEncryption);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableEncryption, value);
			}
		}

		public uint EncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.EncryptionMethods);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.EncryptionMethods, value);
			}
		}

		public uint ExtEncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ExtEncryptionMethods);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ExtEncryptionMethods, value);
			}
		}

		public uint EncryptionLevel
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.EncryptionLevel);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.EncryptionLevel, value);
			}
		}

		public uint ChannelCount
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ChannelCount);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ChannelCount, value);
			}
		}

		public uint ChannelDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ChannelDefArraySize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ChannelDefArraySize, value);
			}
		}

		public uint ClusterInfoFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ClusterInfoFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ClusterInfoFlags, value);
			}
		}

		public uint RedirectedSessionId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectedSessionId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectedSessionId, value);
			}
		}

		public bool ConsoleSession
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ConsoleSession);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ConsoleSession, value);
			}
		}

		public uint MonitorDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.MonitorDefArraySize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.MonitorDefArraySize, value);
			}
		}

		public bool SpanMonitors
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SpanMonitors);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SpanMonitors, value);
			}
		}

		public bool UseMultimon
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.UseMultimon);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.UseMultimon, value);
			}
		}

		public bool ForceMultimon
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ForceMultimon);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ForceMultimon, value);
			}
		}

		public uint MultitransportFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.MultitransportFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.MultitransportFlags, value);
			}
		}

		public string AlternateShell
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.AlternateShell);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.AlternateShell, value);
			}
		}

		public string ShellWorkingDirectory
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ShellWorkingDirectory);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ShellWorkingDirectory, value);
			}
		}

		public bool AutoLogonEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AutoLogonEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AutoLogonEnabled, value);
			}
		}

		public bool CompressionEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.CompressionEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.CompressionEnabled, value);
			}
		}

		public bool DisableCtrlAltDel
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableCtrlAltDel);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableCtrlAltDel, value);
			}
		}

		public bool EnableWindowsKey
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.EnableWindowsKey);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.EnableWindowsKey, value);
			}
		}

		public bool MaximizeShell
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.MaximizeShell);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.MaximizeShell, value);
			}
		}

		public bool LogonNotify
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.LogonNotify);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.LogonNotify, value);
			}
		}

		public bool LogonErrors
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.LogonErrors);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.LogonErrors, value);
			}
		}

		public bool MouseAttached
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.MouseAttached);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.MouseAttached, value);
			}
		}

		public bool MouseHasWheel
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.MouseHasWheel);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.MouseHasWheel, value);
			}
		}

		public bool RemoteConsoleAudio
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteConsoleAudio);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteConsoleAudio, value);
			}
		}

		public bool AudioPlayback
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AudioPlayback);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AudioPlayback, value);
			}
		}

		public bool AudioCapture
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AudioCapture);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AudioCapture, value);
			}
		}

		public bool VideoDisable
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.VideoDisable);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.VideoDisable, value);
			}
		}

		public bool PasswordIsSmartcardPin
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.PasswordIsSmartcardPin);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.PasswordIsSmartcardPin, value);
			}
		}

		public bool UsingSavedCredentials
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.UsingSavedCredentials);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.UsingSavedCredentials, value);
			}
		}

		public bool ForceEncryptedCsPdu
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ForceEncryptedCsPdu);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ForceEncryptedCsPdu, value);
			}
		}

		public bool IPv6Enabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.IPv6Enabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.IPv6Enabled, value);
			}
		}

		public string ClientAddress
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ClientAddress);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ClientAddress, value);
			}
		}

		public string ClientDir
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ClientDir);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ClientDir, value);
			}
		}

		public bool AutoReconnectionEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AutoReconnectionEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AutoReconnectionEnabled, value);
			}
		}

		public uint AutoReconnectMaxRetries
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.AutoReconnectMaxRetries);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.AutoReconnectMaxRetries, value);
			}
		}

		public string DynamicDSTTimeZoneKeyName
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.DynamicDSTTimeZoneKeyName);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.DynamicDSTTimeZoneKeyName, value);
			}
		}

		public bool DynamicDaylightTimeDisabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DynamicDaylightTimeDisabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DynamicDaylightTimeDisabled, value);
			}
		}

		public uint PerformanceFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.PerformanceFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.PerformanceFlags, value);
			}
		}

		public bool AllowFontSmoothing
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AllowFontSmoothing);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AllowFontSmoothing, value);
			}
		}

		public bool DisableWallpaper
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableWallpaper);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableWallpaper, value);
			}
		}

		public bool DisableFullWindowDrag
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableFullWindowDrag);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableFullWindowDrag, value);
			}
		}

		public bool DisableMenuAnims
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableMenuAnims);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableMenuAnims, value);
			}
		}

		public bool DisableThemes
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableThemes);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableThemes, value);
			}
		}

		public bool DisableCursorShadow
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableCursorShadow);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableCursorShadow, value);
			}
		}

		public bool DisableCursorBlinking
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DisableCursorBlinking);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DisableCursorBlinking, value);
			}
		}

		public bool AllowDesktopComposition
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AllowDesktopComposition);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AllowDesktopComposition, value);
			}
		}

		public bool TlsSecurity
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.TlsSecurity);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.TlsSecurity, value);
			}
		}

		public bool NlaSecurity
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.NlaSecurity);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.NlaSecurity, value);
			}
		}

		public bool RdpSecurity
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RdpSecurity);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RdpSecurity, value);
			}
		}

		public bool ExtSecurity
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ExtSecurity);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ExtSecurity, value);
			}
		}

		public bool Authentication
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.Authentication);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.Authentication, value);
			}
		}

		public uint RequestedProtocols
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RequestedProtocols);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RequestedProtocols, value);
			}
		}

		public uint SelectedProtocol
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.SelectedProtocol);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.SelectedProtocol, value);
			}
		}

		public uint NegotiationFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.NegotiationFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.NegotiationFlags, value);
			}
		}

		public bool NegotiateSecurityLayer
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.NegotiateSecurityLayer);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.NegotiateSecurityLayer, value);
			}
		}

		public bool MstscCookieMode
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.MstscCookieMode);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.MstscCookieMode, value);
			}
		}

		public uint CookieMaxLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.CookieMaxLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.CookieMaxLength, value);
			}
		}

		public uint PreconnectionId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.PreconnectionId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.PreconnectionId, value);
			}
		}

		public string PreconnectionBlob
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.PreconnectionBlob);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.PreconnectionBlob, value);
			}
		}

		public bool SendPreconnectionPdu
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SendPreconnectionPdu);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SendPreconnectionPdu, value);
			}
		}

		public uint RedirectionFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionFlags, value);
			}
		}

		public uint LoadBalanceInfoLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.LoadBalanceInfoLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.LoadBalanceInfoLength, value);
			}
		}

		public uint RedirectionUsernameLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionUsernameLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionUsernameLength, value);
			}
		}

		public uint RedirectionDomainLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionDomainLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionDomainLength, value);
			}
		}

		public uint RedirectionPasswordLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionPasswordLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionPasswordLength, value);
			}
		}

		public uint RedirectionTargetFQDNLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionTargetFQDNLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionTargetFQDNLength, value);
			}
		}

		public uint RedirectionTargetNetBiosNameLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionTargetNetBiosNameLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionTargetNetBiosNameLength, value);
			}
		}

		public uint RedirectionTsvUrlLength
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RedirectionTsvUrlLength);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RedirectionTsvUrlLength, value);
			}
		}

		public uint TargetNetAddressCount
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.TargetNetAddressCount);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.TargetNetAddressCount, value);
			}
		}

		public string KerberosKdc
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.KerberosKdc);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.KerberosKdc, value);
			}
		}

		public string KerberosRealm
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.KerberosRealm);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.KerberosRealm, value);
			}
		}

		public bool IgnoreCertificate
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.IgnoreCertificate);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.IgnoreCertificate, value);
			}
		}

		public string CertificateName
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.CertificateName);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.CertificateName, value);
			}
		}

		public string CertificateFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.CertificateFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.CertificateFile, value);
			}
		}

		public string PrivateKeyFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.PrivateKeyFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.PrivateKeyFile, value);
			}
		}

		public string RdpKeyFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RdpKeyFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RdpKeyFile, value);
			}
		}

		public bool Workarea
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.Workarea);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.Workarea, value);
			}
		}

		public bool Fullscreen
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.Fullscreen);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.Fullscreen, value);
			}
		}

		public uint PercentScreen
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.PercentScreen);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.PercentScreen, value);
			}
		}

		public bool GrabKeyboard
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.GrabKeyboard);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.GrabKeyboard, value);
			}
		}

		public bool Decorations
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.Decorations);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.Decorations, value);
			}
		}

		public bool MouseMotion
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.MouseMotion);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.MouseMotion, value);
			}
		}

		public string WindowTitle
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.WindowTitle);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.WindowTitle, value);
			}
		}

		public ulong ParentWindowId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint64(settings, (int) Keys.ParentWindowId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint64(settings, (int) Keys.ParentWindowId, value);
			}
		}

		public bool AsyncInput
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AsyncInput);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AsyncInput, value);
			}
		}

		public bool AsyncUpdate
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AsyncUpdate);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AsyncUpdate, value);
			}
		}

		public bool AsyncChannels
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AsyncChannels);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AsyncChannels, value);
			}
		}

		public bool AsyncTransport
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AsyncTransport);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AsyncTransport, value);
			}
		}

		public bool ToggleFullscreen
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ToggleFullscreen);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ToggleFullscreen, value);
			}
		}

		public string WmClass
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.WmClass);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.WmClass, value);
			}
		}

		public bool EmbeddedWindow
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.EmbeddedWindow);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.EmbeddedWindow, value);
			}
		}

		public bool SmartSizing
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SmartSizing);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SmartSizing, value);
			}
		}

		public bool SoftwareGdi
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SoftwareGdi);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SoftwareGdi, value);
			}
		}

		public bool LocalConnection
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.LocalConnection);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.LocalConnection, value);
			}
		}

		public bool AuthenticationOnly
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AuthenticationOnly);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AuthenticationOnly, value);
			}
		}

		public bool CredentialsFromStdin
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.CredentialsFromStdin);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.CredentialsFromStdin, value);
			}
		}

		public string ComputerName
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ComputerName);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ComputerName, value);
			}
		}

		public string ConnectionFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ConnectionFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ConnectionFile, value);
			}
		}

		public string HomePath
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.HomePath);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.HomePath, value);
			}
		}

		public string ConfigPath
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ConfigPath);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ConfigPath, value);
			}
		}

		public string CurrentPath
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.CurrentPath);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.CurrentPath, value);
			}
		}

		public bool DumpRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DumpRemoteFx);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DumpRemoteFx, value);
			}
		}

		public bool PlayRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.PlayRemoteFx);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.PlayRemoteFx, value);
			}
		}

		public string DumpRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.DumpRemoteFxFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.DumpRemoteFxFile, value);
			}
		}

		public string PlayRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.PlayRemoteFxFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.PlayRemoteFxFile, value);
			}
		}

		public bool GatewayUsageMethod
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.GatewayUsageMethod);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.GatewayUsageMethod, value);
			}
		}

		public uint GatewayPort
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.GatewayPort);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.GatewayPort, value);
			}
		}

		public string GatewayHostname
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.GatewayHostname);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.GatewayHostname, value);
			}
		}

		public string GatewayUsername
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.GatewayUsername);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.GatewayUsername, value);
			}
		}

		public string GatewayPassword
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.GatewayPassword);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.GatewayPassword, value);
			}
		}

		public string GatewayDomain
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.GatewayDomain);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.GatewayDomain, value);
			}
		}

		public uint GatewayCredentialsSource
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.GatewayCredentialsSource);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.GatewayCredentialsSource, value);
			}
		}

		public bool GatewayUseSameCredentials
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.GatewayUseSameCredentials);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.GatewayUseSameCredentials, value);
			}
		}

		public bool RemoteApplicationMode
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteApplicationMode);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteApplicationMode, value);
			}
		}

		public string RemoteApplicationName
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationName);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationName, value);
			}
		}

		public string RemoteApplicationIcon
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationIcon);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationIcon, value);
			}
		}

		public string RemoteApplicationProgram
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationProgram);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationProgram, value);
			}
		}

		public string RemoteApplicationFile
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationFile);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationFile, value);
			}
		}

		public string RemoteApplicationGuid
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationGuid);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationGuid, value);
			}
		}

		public string RemoteApplicationCmdLine
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.RemoteApplicationCmdLine);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.RemoteApplicationCmdLine, value);
			}
		}

		public uint RemoteAppNumIconCaches
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RemoteAppNumIconCaches);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RemoteAppNumIconCaches, value);
			}
		}

		public uint RemoteAppNumIconCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RemoteAppNumIconCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RemoteAppNumIconCacheEntries, value);
			}
		}

		public bool RemoteAppLanguageBarSupported
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteAppLanguageBarSupported);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteAppLanguageBarSupported, value);
			}
		}

		public uint ReceivedCapabilitiesSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.ReceivedCapabilitiesSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.ReceivedCapabilitiesSize, value);
			}
		}

		public uint OsMajorType
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.OsMajorType);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.OsMajorType, value);
			}
		}

		public uint OsMinorType
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.OsMinorType);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.OsMinorType, value);
			}
		}

		public bool RefreshRect
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RefreshRect);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RefreshRect, value);
			}
		}

		public bool SuppressOutput
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SuppressOutput);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SuppressOutput, value);
			}
		}

		public bool FastPathOutput
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.FastPathOutput);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.FastPathOutput, value);
			}
		}

		public bool SaltedChecksum
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SaltedChecksum);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SaltedChecksum, value);
			}
		}

		public bool LongCredentialsSupported
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.LongCredentialsSupported);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.LongCredentialsSupported, value);
			}
		}

		public bool NoBitmapCompressionHeader
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.NoBitmapCompressionHeader);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.NoBitmapCompressionHeader, value);
			}
		}

		public bool DesktopResize
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DesktopResize);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DesktopResize, value);
			}
		}

		public bool DrawAllowDynamicColorFidelity
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawAllowDynamicColorFidelity);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawAllowDynamicColorFidelity, value);
			}
		}

		public bool DrawAllowColorSubsampling
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawAllowColorSubsampling);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawAllowColorSubsampling, value);
			}
		}

		public bool DrawAllowSkipAlpha
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawAllowSkipAlpha);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawAllowSkipAlpha, value);
			}
		}

		public bool BitmapCacheV3Enabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.BitmapCacheV3Enabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.BitmapCacheV3Enabled, value);
			}
		}

		public bool AltSecFrameMarkerSupport
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AltSecFrameMarkerSupport);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AltSecFrameMarkerSupport, value);
			}
		}

		public bool BitmapCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.BitmapCacheEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.BitmapCacheEnabled, value);
			}
		}

		public uint BitmapCacheVersion
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.BitmapCacheVersion);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.BitmapCacheVersion, value);
			}
		}

		public bool AllowCacheWaitingList
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.AllowCacheWaitingList);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.AllowCacheWaitingList, value);
			}
		}

		public bool BitmapCachePersistEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.BitmapCachePersistEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.BitmapCachePersistEnabled, value);
			}
		}

		public uint BitmapCacheV2NumCells
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.BitmapCacheV2NumCells);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.BitmapCacheV2NumCells, value);
			}
		}

		public bool ColorPointerFlag
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.ColorPointerFlag);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.ColorPointerFlag, value);
			}
		}

		public uint PointerCacheSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.PointerCacheSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.PointerCacheSize, value);
			}
		}

		public uint KeyboardLayout
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.KeyboardLayout);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.KeyboardLayout, value);
			}
		}

		public uint KeyboardType
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.KeyboardType);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.KeyboardType, value);
			}
		}

		public uint KeyboardSubType
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.KeyboardSubType);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.KeyboardSubType, value);
			}
		}

		public uint KeyboardFunctionKey
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.KeyboardFunctionKey);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.KeyboardFunctionKey, value);
			}
		}

		public string ImeFileName
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.ImeFileName);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.ImeFileName, value);
			}
		}

		public bool UnicodeInput
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.UnicodeInput);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.UnicodeInput, value);
			}
		}

		public bool FastPathInput
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.FastPathInput);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.FastPathInput, value);
			}
		}

		public uint BrushSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.BrushSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.BrushSupportLevel, value);
			}
		}

		public uint GlyphSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.GlyphSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.GlyphSupportLevel, value);
			}
		}

		public uint OffscreenSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.OffscreenSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.OffscreenSupportLevel, value);
			}
		}

		public uint OffscreenCacheSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.OffscreenCacheSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.OffscreenCacheSize, value);
			}
		}

		public uint OffscreenCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.OffscreenCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.OffscreenCacheEntries, value);
			}
		}

		public uint VirtualChannelCompressionFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.VirtualChannelCompressionFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.VirtualChannelCompressionFlags, value);
			}
		}

		public uint VirtualChannelChunkSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.VirtualChannelChunkSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.VirtualChannelChunkSize, value);
			}
		}

		public bool SoundBeepsEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SoundBeepsEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SoundBeepsEnabled, value);
			}
		}

		public uint MultifragMaxRequestSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.MultifragMaxRequestSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.MultifragMaxRequestSize, value);
			}
		}

		public uint LargePointerFlag
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.LargePointerFlag);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.LargePointerFlag, value);
			}
		}

		public uint CompDeskSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.CompDeskSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.CompDeskSupportLevel, value);
			}
		}

		public bool SurfaceCommandsEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.SurfaceCommandsEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.SurfaceCommandsEnabled, value);
			}
		}

		public bool FrameMarkerCommandEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.FrameMarkerCommandEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.FrameMarkerCommandEnabled, value);
			}
		}

		public bool RemoteFxOnly
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteFxOnly);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteFxOnly, value);
			}
		}

		public bool RemoteFxCodec
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteFxCodec);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteFxCodec, value);
			}
		}

		public uint RemoteFxCodecId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RemoteFxCodecId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RemoteFxCodecId, value);
			}
		}

		public uint RemoteFxCodecMode
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RemoteFxCodecMode);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RemoteFxCodecMode, value);
			}
		}

		public bool RemoteFxImageCodec
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RemoteFxImageCodec);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RemoteFxImageCodec, value);
			}
		}

		public uint RemoteFxCaptureFlags
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.RemoteFxCaptureFlags);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.RemoteFxCaptureFlags, value);
			}
		}

		public bool NSCodec
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.NSCodec);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.NSCodec, value);
			}
		}

		public uint NSCodecId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.NSCodecId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.NSCodecId, value);
			}
		}

		public bool FrameAcknowledge
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.FrameAcknowledge);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.FrameAcknowledge, value);
			}
		}

		public bool JpegCodec
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.JpegCodec);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.JpegCodec, value);
			}
		}

		public uint JpegCodecId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.JpegCodecId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.JpegCodecId, value);
			}
		}

		public uint JpegQuality
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.JpegQuality);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.JpegQuality, value);
			}
		}

		public uint BitmapCacheV3CodecId
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.BitmapCacheV3CodecId);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.BitmapCacheV3CodecId, value);
			}
		}

		public bool DrawNineGridEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawNineGridEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawNineGridEnabled, value);
			}
		}

		public uint DrawNineGridCacheSize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DrawNineGridCacheSize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DrawNineGridCacheSize, value);
			}
		}

		public uint DrawNineGridCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DrawNineGridCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DrawNineGridCacheEntries, value);
			}
		}

		public bool DrawGdiPlusEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawGdiPlusEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawGdiPlusEnabled, value);
			}
		}

		public bool DrawGdiPlusCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DrawGdiPlusCacheEnabled);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DrawGdiPlusCacheEnabled, value);
			}
		}

		public bool DeviceRedirection
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.DeviceRedirection);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.DeviceRedirection, value);
			}
		}

		public uint DeviceCount
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DeviceCount);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DeviceCount, value);
			}
		}

		public uint DeviceArraySize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DeviceArraySize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DeviceArraySize, value);
			}
		}

		public bool RedirectDrives
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectDrives);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectDrives, value);
			}
		}

		public bool RedirectHomeDrive
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectHomeDrive);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectHomeDrive, value);
			}
		}

		public string DrivesToRedirect
		{
			get
			{
				return NativeMethods.freerdp_get_param_string(settings, (int) Keys.DrivesToRedirect);
			}
			set
			{
				NativeMethods.freerdp_set_param_string(settings, (int) Keys.DrivesToRedirect, value);
			}
		}

		public bool RedirectSmartCards
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectSmartCards);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectSmartCards, value);
			}
		}

		public bool RedirectPrinters
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectPrinters);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectPrinters, value);
			}
		}

		public bool RedirectSerialPorts
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectSerialPorts);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectSerialPorts, value);
			}
		}

		public bool RedirectParallelPorts
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectParallelPorts);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectParallelPorts, value);
			}
		}

		public bool RedirectClipboard
		{
			get
			{
				return NativeMethods.freerdp_get_param_bool(settings, (int) Keys.RedirectClipboard);
			}
			set
			{
				NativeMethods.freerdp_set_param_bool(settings, (int) Keys.RedirectClipboard, value);
			}
		}

		public uint StaticChannelCount
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.StaticChannelCount);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.StaticChannelCount, value);
			}
		}

		public uint StaticChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.StaticChannelArraySize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.StaticChannelArraySize, value);
			}
		}

		public uint DynamicChannelCount
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DynamicChannelCount);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DynamicChannelCount, value);
			}
		}

		public uint DynamicChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_get_param_uint32(settings, (int) Keys.DynamicChannelArraySize);
			}
			set
			{
				NativeMethods.freerdp_set_param_uint32(settings, (int) Keys.DynamicChannelArraySize, value);
			}
		}

	}

	public delegate void FreeRDPSettingsChangedEventHandler(object sender, FreeRDPSettingsChangedEventArgs e);

	public class FreeRDPSettingsChangedEventArgs : EventArgs
	{
		public FreeRDPSettings.Keys Property  {get;set;}
	}

}
