using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient.FreeRDP
{
	/// <summary>
	/// IMPORTANT: This class is generated. Do not modify manually. See Settings.pl for implementation.
	/// </summary>
	public sealed class FreeRDPSettings
	{
		public event FreeRDPSettingsChangedEventHandler SettingsChanged;

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

		private IntPtr wfi;

		public FreeRDPSettings(IntPtr wfi)
		{
			this.wfi = wfi;
		}

		private void OnSettingsChanged(Keys key)
		{
			if (SettingsChanged != null)
			{
				SettingsChanged(this, new FreeRDPSettingsChangedEventArgs() { Property = key });
			}
		}

		public bool ServerMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ServerMode);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ServerMode, value);
				OnSettingsChanged(Keys.ServerMode);
			}
		}

		public uint ShareId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ShareId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ShareId, value);
				OnSettingsChanged(Keys.ShareId);
			}
		}

		public uint PduSource
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.PduSource);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.PduSource, value);
				OnSettingsChanged(Keys.PduSource);
			}
		}

		public uint ServerPort
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ServerPort);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ServerPort, value);
				OnSettingsChanged(Keys.ServerPort);
			}
		}

		public string ServerHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ServerHostname);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ServerHostname, value);
				OnSettingsChanged(Keys.ServerHostname);
			}
		}

		public string Username
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.Username);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.Username, value);
				OnSettingsChanged(Keys.Username);
			}
		}

		public string Password
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.Password);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.Password, value);
				OnSettingsChanged(Keys.Password);
			}
		}

		public string Domain
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.Domain);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.Domain, value);
				OnSettingsChanged(Keys.Domain);
			}
		}

		public uint RdpVersion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RdpVersion);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RdpVersion, value);
				OnSettingsChanged(Keys.RdpVersion);
			}
		}

		public uint DesktopWidth
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DesktopWidth);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DesktopWidth, value);
				OnSettingsChanged(Keys.DesktopWidth);
			}
		}

		public uint DesktopHeight
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DesktopHeight);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DesktopHeight, value);
				OnSettingsChanged(Keys.DesktopHeight);
			}
		}

		public uint ColorDepth
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ColorDepth);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ColorDepth, value);
				OnSettingsChanged(Keys.ColorDepth);
			}
		}

		public uint ConnectionType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ConnectionType);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ConnectionType, value);
				OnSettingsChanged(Keys.ConnectionType);
			}
		}

		public uint ClientBuild
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ClientBuild);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ClientBuild, value);
				OnSettingsChanged(Keys.ClientBuild);
			}
		}

		public string ClientHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ClientHostname);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ClientHostname, value);
				OnSettingsChanged(Keys.ClientHostname);
			}
		}

		public string ClientProductId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ClientProductId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ClientProductId, value);
				OnSettingsChanged(Keys.ClientProductId);
			}
		}

		public uint EarlyCapabilityFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.EarlyCapabilityFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.EarlyCapabilityFlags, value);
				OnSettingsChanged(Keys.EarlyCapabilityFlags);
			}
		}

		public bool NetworkAutoDetect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.NetworkAutoDetect);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.NetworkAutoDetect, value);
				OnSettingsChanged(Keys.NetworkAutoDetect);
			}
		}

		public bool SupportAsymetricKeys
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportAsymetricKeys);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportAsymetricKeys, value);
				OnSettingsChanged(Keys.SupportAsymetricKeys);
			}
		}

		public bool SupportErrorInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportErrorInfoPdu);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportErrorInfoPdu, value);
				OnSettingsChanged(Keys.SupportErrorInfoPdu);
			}
		}

		public bool SupportStatusInfoPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportStatusInfoPdu);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportStatusInfoPdu, value);
				OnSettingsChanged(Keys.SupportStatusInfoPdu);
			}
		}

		public bool SupportMonitorLayoutPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportMonitorLayoutPdu);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportMonitorLayoutPdu, value);
				OnSettingsChanged(Keys.SupportMonitorLayoutPdu);
			}
		}

		public bool SupportGraphicsPipeline
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportGraphicsPipeline);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportGraphicsPipeline, value);
				OnSettingsChanged(Keys.SupportGraphicsPipeline);
			}
		}

		public bool SupportDynamicTimeZone
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SupportDynamicTimeZone);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SupportDynamicTimeZone, value);
				OnSettingsChanged(Keys.SupportDynamicTimeZone);
			}
		}

		public bool DisableEncryption
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableEncryption);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableEncryption, value);
				OnSettingsChanged(Keys.DisableEncryption);
			}
		}

		public uint EncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.EncryptionMethods);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.EncryptionMethods, value);
				OnSettingsChanged(Keys.EncryptionMethods);
			}
		}

		public uint ExtEncryptionMethods
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ExtEncryptionMethods);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ExtEncryptionMethods, value);
				OnSettingsChanged(Keys.ExtEncryptionMethods);
			}
		}

		public uint EncryptionLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.EncryptionLevel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.EncryptionLevel, value);
				OnSettingsChanged(Keys.EncryptionLevel);
			}
		}

		public uint ChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ChannelCount);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ChannelCount, value);
				OnSettingsChanged(Keys.ChannelCount);
			}
		}

		public uint ChannelDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ChannelDefArraySize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ChannelDefArraySize, value);
				OnSettingsChanged(Keys.ChannelDefArraySize);
			}
		}

		public uint ClusterInfoFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ClusterInfoFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ClusterInfoFlags, value);
				OnSettingsChanged(Keys.ClusterInfoFlags);
			}
		}

		public uint RedirectedSessionId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectedSessionId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectedSessionId, value);
				OnSettingsChanged(Keys.RedirectedSessionId);
			}
		}

		public bool ConsoleSession
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ConsoleSession);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ConsoleSession, value);
				OnSettingsChanged(Keys.ConsoleSession);
			}
		}

		public uint MonitorDefArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.MonitorDefArraySize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.MonitorDefArraySize, value);
				OnSettingsChanged(Keys.MonitorDefArraySize);
			}
		}

		public bool SpanMonitors
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SpanMonitors);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SpanMonitors, value);
				OnSettingsChanged(Keys.SpanMonitors);
			}
		}

		public bool UseMultimon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.UseMultimon);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.UseMultimon, value);
				OnSettingsChanged(Keys.UseMultimon);
			}
		}

		public bool ForceMultimon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ForceMultimon);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ForceMultimon, value);
				OnSettingsChanged(Keys.ForceMultimon);
			}
		}

		public uint MultitransportFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.MultitransportFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.MultitransportFlags, value);
				OnSettingsChanged(Keys.MultitransportFlags);
			}
		}

		public string AlternateShell
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.AlternateShell);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.AlternateShell, value);
				OnSettingsChanged(Keys.AlternateShell);
			}
		}

		public string ShellWorkingDirectory
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ShellWorkingDirectory);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ShellWorkingDirectory, value);
				OnSettingsChanged(Keys.ShellWorkingDirectory);
			}
		}

		public bool AutoLogonEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AutoLogonEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AutoLogonEnabled, value);
				OnSettingsChanged(Keys.AutoLogonEnabled);
			}
		}

		public bool CompressionEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.CompressionEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.CompressionEnabled, value);
				OnSettingsChanged(Keys.CompressionEnabled);
			}
		}

		public bool DisableCtrlAltDel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableCtrlAltDel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableCtrlAltDel, value);
				OnSettingsChanged(Keys.DisableCtrlAltDel);
			}
		}

		public bool EnableWindowsKey
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.EnableWindowsKey);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.EnableWindowsKey, value);
				OnSettingsChanged(Keys.EnableWindowsKey);
			}
		}

		public bool MaximizeShell
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.MaximizeShell);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.MaximizeShell, value);
				OnSettingsChanged(Keys.MaximizeShell);
			}
		}

		public bool LogonNotify
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.LogonNotify);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.LogonNotify, value);
				OnSettingsChanged(Keys.LogonNotify);
			}
		}

		public bool LogonErrors
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.LogonErrors);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.LogonErrors, value);
				OnSettingsChanged(Keys.LogonErrors);
			}
		}

		public bool MouseAttached
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.MouseAttached);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.MouseAttached, value);
				OnSettingsChanged(Keys.MouseAttached);
			}
		}

		public bool MouseHasWheel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.MouseHasWheel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.MouseHasWheel, value);
				OnSettingsChanged(Keys.MouseHasWheel);
			}
		}

		public bool RemoteConsoleAudio
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteConsoleAudio);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteConsoleAudio, value);
				OnSettingsChanged(Keys.RemoteConsoleAudio);
			}
		}

		public bool AudioPlayback
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AudioPlayback);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AudioPlayback, value);
				OnSettingsChanged(Keys.AudioPlayback);
			}
		}

		public bool AudioCapture
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AudioCapture);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AudioCapture, value);
				OnSettingsChanged(Keys.AudioCapture);
			}
		}

		public bool VideoDisable
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.VideoDisable);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.VideoDisable, value);
				OnSettingsChanged(Keys.VideoDisable);
			}
		}

		public bool PasswordIsSmartcardPin
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.PasswordIsSmartcardPin);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.PasswordIsSmartcardPin, value);
				OnSettingsChanged(Keys.PasswordIsSmartcardPin);
			}
		}

		public bool UsingSavedCredentials
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.UsingSavedCredentials);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.UsingSavedCredentials, value);
				OnSettingsChanged(Keys.UsingSavedCredentials);
			}
		}

		public bool ForceEncryptedCsPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ForceEncryptedCsPdu);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ForceEncryptedCsPdu, value);
				OnSettingsChanged(Keys.ForceEncryptedCsPdu);
			}
		}

		public bool IPv6Enabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.IPv6Enabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.IPv6Enabled, value);
				OnSettingsChanged(Keys.IPv6Enabled);
			}
		}

		public string ClientAddress
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ClientAddress);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ClientAddress, value);
				OnSettingsChanged(Keys.ClientAddress);
			}
		}

		public string ClientDir
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ClientDir);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ClientDir, value);
				OnSettingsChanged(Keys.ClientDir);
			}
		}

		public bool AutoReconnectionEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AutoReconnectionEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AutoReconnectionEnabled, value);
				OnSettingsChanged(Keys.AutoReconnectionEnabled);
			}
		}

		public uint AutoReconnectMaxRetries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.AutoReconnectMaxRetries);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.AutoReconnectMaxRetries, value);
				OnSettingsChanged(Keys.AutoReconnectMaxRetries);
			}
		}

		public string DynamicDSTTimeZoneKeyName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.DynamicDSTTimeZoneKeyName);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.DynamicDSTTimeZoneKeyName, value);
				OnSettingsChanged(Keys.DynamicDSTTimeZoneKeyName);
			}
		}

		public bool DynamicDaylightTimeDisabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DynamicDaylightTimeDisabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DynamicDaylightTimeDisabled, value);
				OnSettingsChanged(Keys.DynamicDaylightTimeDisabled);
			}
		}

		public uint PerformanceFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.PerformanceFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.PerformanceFlags, value);
				OnSettingsChanged(Keys.PerformanceFlags);
			}
		}

		public bool AllowFontSmoothing
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AllowFontSmoothing);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AllowFontSmoothing, value);
				OnSettingsChanged(Keys.AllowFontSmoothing);
			}
		}

		public bool DisableWallpaper
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableWallpaper);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableWallpaper, value);
				OnSettingsChanged(Keys.DisableWallpaper);
			}
		}

		public bool DisableFullWindowDrag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableFullWindowDrag);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableFullWindowDrag, value);
				OnSettingsChanged(Keys.DisableFullWindowDrag);
			}
		}

		public bool DisableMenuAnims
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableMenuAnims);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableMenuAnims, value);
				OnSettingsChanged(Keys.DisableMenuAnims);
			}
		}

		public bool DisableThemes
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableThemes);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableThemes, value);
				OnSettingsChanged(Keys.DisableThemes);
			}
		}

		public bool DisableCursorShadow
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableCursorShadow);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableCursorShadow, value);
				OnSettingsChanged(Keys.DisableCursorShadow);
			}
		}

		public bool DisableCursorBlinking
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DisableCursorBlinking);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DisableCursorBlinking, value);
				OnSettingsChanged(Keys.DisableCursorBlinking);
			}
		}

		public bool AllowDesktopComposition
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AllowDesktopComposition);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AllowDesktopComposition, value);
				OnSettingsChanged(Keys.AllowDesktopComposition);
			}
		}

		public bool TlsSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.TlsSecurity);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.TlsSecurity, value);
				OnSettingsChanged(Keys.TlsSecurity);
			}
		}

		public bool NlaSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.NlaSecurity);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.NlaSecurity, value);
				OnSettingsChanged(Keys.NlaSecurity);
			}
		}

		public bool RdpSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RdpSecurity);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RdpSecurity, value);
				OnSettingsChanged(Keys.RdpSecurity);
			}
		}

		public bool ExtSecurity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ExtSecurity);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ExtSecurity, value);
				OnSettingsChanged(Keys.ExtSecurity);
			}
		}

		public bool Authentication
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.Authentication);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.Authentication, value);
				OnSettingsChanged(Keys.Authentication);
			}
		}

		public uint RequestedProtocols
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RequestedProtocols);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RequestedProtocols, value);
				OnSettingsChanged(Keys.RequestedProtocols);
			}
		}

		public uint SelectedProtocol
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.SelectedProtocol);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.SelectedProtocol, value);
				OnSettingsChanged(Keys.SelectedProtocol);
			}
		}

		public uint NegotiationFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.NegotiationFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.NegotiationFlags, value);
				OnSettingsChanged(Keys.NegotiationFlags);
			}
		}

		public bool NegotiateSecurityLayer
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.NegotiateSecurityLayer);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.NegotiateSecurityLayer, value);
				OnSettingsChanged(Keys.NegotiateSecurityLayer);
			}
		}

		public bool MstscCookieMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.MstscCookieMode);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.MstscCookieMode, value);
				OnSettingsChanged(Keys.MstscCookieMode);
			}
		}

		public uint CookieMaxLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.CookieMaxLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.CookieMaxLength, value);
				OnSettingsChanged(Keys.CookieMaxLength);
			}
		}

		public uint PreconnectionId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.PreconnectionId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.PreconnectionId, value);
				OnSettingsChanged(Keys.PreconnectionId);
			}
		}

		public string PreconnectionBlob
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.PreconnectionBlob);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.PreconnectionBlob, value);
				OnSettingsChanged(Keys.PreconnectionBlob);
			}
		}

		public bool SendPreconnectionPdu
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SendPreconnectionPdu);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SendPreconnectionPdu, value);
				OnSettingsChanged(Keys.SendPreconnectionPdu);
			}
		}

		public uint RedirectionFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionFlags, value);
				OnSettingsChanged(Keys.RedirectionFlags);
			}
		}

		public uint LoadBalanceInfoLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.LoadBalanceInfoLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.LoadBalanceInfoLength, value);
				OnSettingsChanged(Keys.LoadBalanceInfoLength);
			}
		}

		public uint RedirectionUsernameLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionUsernameLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionUsernameLength, value);
				OnSettingsChanged(Keys.RedirectionUsernameLength);
			}
		}

		public uint RedirectionDomainLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionDomainLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionDomainLength, value);
				OnSettingsChanged(Keys.RedirectionDomainLength);
			}
		}

		public uint RedirectionPasswordLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionPasswordLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionPasswordLength, value);
				OnSettingsChanged(Keys.RedirectionPasswordLength);
			}
		}

		public uint RedirectionTargetFQDNLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionTargetFQDNLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionTargetFQDNLength, value);
				OnSettingsChanged(Keys.RedirectionTargetFQDNLength);
			}
		}

		public uint RedirectionTargetNetBiosNameLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionTargetNetBiosNameLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionTargetNetBiosNameLength, value);
				OnSettingsChanged(Keys.RedirectionTargetNetBiosNameLength);
			}
		}

		public uint RedirectionTsvUrlLength
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RedirectionTsvUrlLength);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RedirectionTsvUrlLength, value);
				OnSettingsChanged(Keys.RedirectionTsvUrlLength);
			}
		}

		public uint TargetNetAddressCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.TargetNetAddressCount);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.TargetNetAddressCount, value);
				OnSettingsChanged(Keys.TargetNetAddressCount);
			}
		}

		public string KerberosKdc
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.KerberosKdc);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.KerberosKdc, value);
				OnSettingsChanged(Keys.KerberosKdc);
			}
		}

		public string KerberosRealm
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.KerberosRealm);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.KerberosRealm, value);
				OnSettingsChanged(Keys.KerberosRealm);
			}
		}

		public bool IgnoreCertificate
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.IgnoreCertificate);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.IgnoreCertificate, value);
				OnSettingsChanged(Keys.IgnoreCertificate);
			}
		}

		public string CertificateName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.CertificateName);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.CertificateName, value);
				OnSettingsChanged(Keys.CertificateName);
			}
		}

		public string CertificateFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.CertificateFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.CertificateFile, value);
				OnSettingsChanged(Keys.CertificateFile);
			}
		}

		public string PrivateKeyFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.PrivateKeyFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.PrivateKeyFile, value);
				OnSettingsChanged(Keys.PrivateKeyFile);
			}
		}

		public string RdpKeyFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RdpKeyFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RdpKeyFile, value);
				OnSettingsChanged(Keys.RdpKeyFile);
			}
		}

		public bool Workarea
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.Workarea);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.Workarea, value);
				OnSettingsChanged(Keys.Workarea);
			}
		}

		public bool Fullscreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.Fullscreen);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.Fullscreen, value);
				OnSettingsChanged(Keys.Fullscreen);
			}
		}

		public uint PercentScreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.PercentScreen);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.PercentScreen, value);
				OnSettingsChanged(Keys.PercentScreen);
			}
		}

		public bool GrabKeyboard
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.GrabKeyboard);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.GrabKeyboard, value);
				OnSettingsChanged(Keys.GrabKeyboard);
			}
		}

		public bool Decorations
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.Decorations);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.Decorations, value);
				OnSettingsChanged(Keys.Decorations);
			}
		}

		public bool MouseMotion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.MouseMotion);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.MouseMotion, value);
				OnSettingsChanged(Keys.MouseMotion);
			}
		}

		public string WindowTitle
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.WindowTitle);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.WindowTitle, value);
				OnSettingsChanged(Keys.WindowTitle);
			}
		}

		public ulong ParentWindowId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint64(wfi, (int)Keys.ParentWindowId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint64(wfi, (int)Keys.ParentWindowId, value);
				OnSettingsChanged(Keys.ParentWindowId);
			}
		}

		public bool AsyncInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AsyncInput);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AsyncInput, value);
				OnSettingsChanged(Keys.AsyncInput);
			}
		}

		public bool AsyncUpdate
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AsyncUpdate);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AsyncUpdate, value);
				OnSettingsChanged(Keys.AsyncUpdate);
			}
		}

		public bool AsyncChannels
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AsyncChannels);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AsyncChannels, value);
				OnSettingsChanged(Keys.AsyncChannels);
			}
		}

		public bool AsyncTransport
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AsyncTransport);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AsyncTransport, value);
				OnSettingsChanged(Keys.AsyncTransport);
			}
		}

		public bool ToggleFullscreen
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ToggleFullscreen);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ToggleFullscreen, value);
				OnSettingsChanged(Keys.ToggleFullscreen);
			}
		}

		public string WmClass
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.WmClass);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.WmClass, value);
				OnSettingsChanged(Keys.WmClass);
			}
		}

		public bool EmbeddedWindow
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.EmbeddedWindow);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.EmbeddedWindow, value);
				OnSettingsChanged(Keys.EmbeddedWindow);
			}
		}

		public bool SmartSizing
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SmartSizing);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SmartSizing, value);
				OnSettingsChanged(Keys.SmartSizing);
			}
		}

		public bool SoftwareGdi
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SoftwareGdi);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SoftwareGdi, value);
				OnSettingsChanged(Keys.SoftwareGdi);
			}
		}

		public bool LocalConnection
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.LocalConnection);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.LocalConnection, value);
				OnSettingsChanged(Keys.LocalConnection);
			}
		}

		public bool AuthenticationOnly
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AuthenticationOnly);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AuthenticationOnly, value);
				OnSettingsChanged(Keys.AuthenticationOnly);
			}
		}

		public bool CredentialsFromStdin
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.CredentialsFromStdin);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.CredentialsFromStdin, value);
				OnSettingsChanged(Keys.CredentialsFromStdin);
			}
		}

		public string ComputerName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ComputerName);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ComputerName, value);
				OnSettingsChanged(Keys.ComputerName);
			}
		}

		public string ConnectionFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ConnectionFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ConnectionFile, value);
				OnSettingsChanged(Keys.ConnectionFile);
			}
		}

		public string HomePath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.HomePath);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.HomePath, value);
				OnSettingsChanged(Keys.HomePath);
			}
		}

		public string ConfigPath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ConfigPath);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ConfigPath, value);
				OnSettingsChanged(Keys.ConfigPath);
			}
		}

		public string CurrentPath
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.CurrentPath);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.CurrentPath, value);
				OnSettingsChanged(Keys.CurrentPath);
			}
		}

		public bool DumpRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DumpRemoteFx);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DumpRemoteFx, value);
				OnSettingsChanged(Keys.DumpRemoteFx);
			}
		}

		public bool PlayRemoteFx
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.PlayRemoteFx);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.PlayRemoteFx, value);
				OnSettingsChanged(Keys.PlayRemoteFx);
			}
		}

		public string DumpRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.DumpRemoteFxFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.DumpRemoteFxFile, value);
				OnSettingsChanged(Keys.DumpRemoteFxFile);
			}
		}

		public string PlayRemoteFxFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.PlayRemoteFxFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.PlayRemoteFxFile, value);
				OnSettingsChanged(Keys.PlayRemoteFxFile);
			}
		}

		public bool GatewayUsageMethod
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.GatewayUsageMethod);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.GatewayUsageMethod, value);
				OnSettingsChanged(Keys.GatewayUsageMethod);
			}
		}

		public uint GatewayPort
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.GatewayPort);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.GatewayPort, value);
				OnSettingsChanged(Keys.GatewayPort);
			}
		}

		public string GatewayHostname
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.GatewayHostname);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.GatewayHostname, value);
				OnSettingsChanged(Keys.GatewayHostname);
			}
		}

		public string GatewayUsername
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.GatewayUsername);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.GatewayUsername, value);
				OnSettingsChanged(Keys.GatewayUsername);
			}
		}

		public string GatewayPassword
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.GatewayPassword);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.GatewayPassword, value);
				OnSettingsChanged(Keys.GatewayPassword);
			}
		}

		public string GatewayDomain
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.GatewayDomain);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.GatewayDomain, value);
				OnSettingsChanged(Keys.GatewayDomain);
			}
		}

		public uint GatewayCredentialsSource
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.GatewayCredentialsSource);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.GatewayCredentialsSource, value);
				OnSettingsChanged(Keys.GatewayCredentialsSource);
			}
		}

		public bool GatewayUseSameCredentials
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.GatewayUseSameCredentials);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.GatewayUseSameCredentials, value);
				OnSettingsChanged(Keys.GatewayUseSameCredentials);
			}
		}

		public bool RemoteApplicationMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteApplicationMode);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteApplicationMode, value);
				OnSettingsChanged(Keys.RemoteApplicationMode);
			}
		}

		public string RemoteApplicationName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationName);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationName, value);
				OnSettingsChanged(Keys.RemoteApplicationName);
			}
		}

		public string RemoteApplicationIcon
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationIcon);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationIcon, value);
				OnSettingsChanged(Keys.RemoteApplicationIcon);
			}
		}

		public string RemoteApplicationProgram
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationProgram);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationProgram, value);
				OnSettingsChanged(Keys.RemoteApplicationProgram);
			}
		}

		public string RemoteApplicationFile
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationFile);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationFile, value);
				OnSettingsChanged(Keys.RemoteApplicationFile);
			}
		}

		public string RemoteApplicationGuid
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationGuid);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationGuid, value);
				OnSettingsChanged(Keys.RemoteApplicationGuid);
			}
		}

		public string RemoteApplicationCmdLine
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.RemoteApplicationCmdLine);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.RemoteApplicationCmdLine, value);
				OnSettingsChanged(Keys.RemoteApplicationCmdLine);
			}
		}

		public uint RemoteAppNumIconCaches
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RemoteAppNumIconCaches);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RemoteAppNumIconCaches, value);
				OnSettingsChanged(Keys.RemoteAppNumIconCaches);
			}
		}

		public uint RemoteAppNumIconCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RemoteAppNumIconCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RemoteAppNumIconCacheEntries, value);
				OnSettingsChanged(Keys.RemoteAppNumIconCacheEntries);
			}
		}

		public bool RemoteAppLanguageBarSupported
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteAppLanguageBarSupported);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteAppLanguageBarSupported, value);
				OnSettingsChanged(Keys.RemoteAppLanguageBarSupported);
			}
		}

		public uint ReceivedCapabilitiesSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.ReceivedCapabilitiesSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.ReceivedCapabilitiesSize, value);
				OnSettingsChanged(Keys.ReceivedCapabilitiesSize);
			}
		}

		public uint OsMajorType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.OsMajorType);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.OsMajorType, value);
				OnSettingsChanged(Keys.OsMajorType);
			}
		}

		public uint OsMinorType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.OsMinorType);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.OsMinorType, value);
				OnSettingsChanged(Keys.OsMinorType);
			}
		}

		public bool RefreshRect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RefreshRect);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RefreshRect, value);
				OnSettingsChanged(Keys.RefreshRect);
			}
		}

		public bool SuppressOutput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SuppressOutput);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SuppressOutput, value);
				OnSettingsChanged(Keys.SuppressOutput);
			}
		}

		public bool FastPathOutput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.FastPathOutput);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.FastPathOutput, value);
				OnSettingsChanged(Keys.FastPathOutput);
			}
		}

		public bool SaltedChecksum
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SaltedChecksum);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SaltedChecksum, value);
				OnSettingsChanged(Keys.SaltedChecksum);
			}
		}

		public bool LongCredentialsSupported
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.LongCredentialsSupported);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.LongCredentialsSupported, value);
				OnSettingsChanged(Keys.LongCredentialsSupported);
			}
		}

		public bool NoBitmapCompressionHeader
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.NoBitmapCompressionHeader);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.NoBitmapCompressionHeader, value);
				OnSettingsChanged(Keys.NoBitmapCompressionHeader);
			}
		}

		public bool DesktopResize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DesktopResize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DesktopResize, value);
				OnSettingsChanged(Keys.DesktopResize);
			}
		}

		public bool DrawAllowDynamicColorFidelity
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawAllowDynamicColorFidelity);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawAllowDynamicColorFidelity, value);
				OnSettingsChanged(Keys.DrawAllowDynamicColorFidelity);
			}
		}

		public bool DrawAllowColorSubsampling
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawAllowColorSubsampling);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawAllowColorSubsampling, value);
				OnSettingsChanged(Keys.DrawAllowColorSubsampling);
			}
		}

		public bool DrawAllowSkipAlpha
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawAllowSkipAlpha);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawAllowSkipAlpha, value);
				OnSettingsChanged(Keys.DrawAllowSkipAlpha);
			}
		}

		public bool BitmapCacheV3Enabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.BitmapCacheV3Enabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.BitmapCacheV3Enabled, value);
				OnSettingsChanged(Keys.BitmapCacheV3Enabled);
			}
		}

		public bool AltSecFrameMarkerSupport
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AltSecFrameMarkerSupport);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AltSecFrameMarkerSupport, value);
				OnSettingsChanged(Keys.AltSecFrameMarkerSupport);
			}
		}

		public bool BitmapCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.BitmapCacheEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.BitmapCacheEnabled, value);
				OnSettingsChanged(Keys.BitmapCacheEnabled);
			}
		}

		public uint BitmapCacheVersion
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.BitmapCacheVersion);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.BitmapCacheVersion, value);
				OnSettingsChanged(Keys.BitmapCacheVersion);
			}
		}

		public bool AllowCacheWaitingList
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.AllowCacheWaitingList);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.AllowCacheWaitingList, value);
				OnSettingsChanged(Keys.AllowCacheWaitingList);
			}
		}

		public bool BitmapCachePersistEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.BitmapCachePersistEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.BitmapCachePersistEnabled, value);
				OnSettingsChanged(Keys.BitmapCachePersistEnabled);
			}
		}

		public uint BitmapCacheV2NumCells
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.BitmapCacheV2NumCells);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.BitmapCacheV2NumCells, value);
				OnSettingsChanged(Keys.BitmapCacheV2NumCells);
			}
		}

		public bool ColorPointerFlag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.ColorPointerFlag);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.ColorPointerFlag, value);
				OnSettingsChanged(Keys.ColorPointerFlag);
			}
		}

		public uint PointerCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.PointerCacheSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.PointerCacheSize, value);
				OnSettingsChanged(Keys.PointerCacheSize);
			}
		}

		public uint KeyboardLayout
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.KeyboardLayout);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.KeyboardLayout, value);
				OnSettingsChanged(Keys.KeyboardLayout);
			}
		}

		public uint KeyboardType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.KeyboardType);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.KeyboardType, value);
				OnSettingsChanged(Keys.KeyboardType);
			}
		}

		public uint KeyboardSubType
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.KeyboardSubType);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.KeyboardSubType, value);
				OnSettingsChanged(Keys.KeyboardSubType);
			}
		}

		public uint KeyboardFunctionKey
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.KeyboardFunctionKey);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.KeyboardFunctionKey, value);
				OnSettingsChanged(Keys.KeyboardFunctionKey);
			}
		}

		public string ImeFileName
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.ImeFileName);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.ImeFileName, value);
				OnSettingsChanged(Keys.ImeFileName);
			}
		}

		public bool UnicodeInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.UnicodeInput);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.UnicodeInput, value);
				OnSettingsChanged(Keys.UnicodeInput);
			}
		}

		public bool FastPathInput
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.FastPathInput);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.FastPathInput, value);
				OnSettingsChanged(Keys.FastPathInput);
			}
		}

		public uint BrushSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.BrushSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.BrushSupportLevel, value);
				OnSettingsChanged(Keys.BrushSupportLevel);
			}
		}

		public uint GlyphSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.GlyphSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.GlyphSupportLevel, value);
				OnSettingsChanged(Keys.GlyphSupportLevel);
			}
		}

		public uint OffscreenSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.OffscreenSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.OffscreenSupportLevel, value);
				OnSettingsChanged(Keys.OffscreenSupportLevel);
			}
		}

		public uint OffscreenCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.OffscreenCacheSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.OffscreenCacheSize, value);
				OnSettingsChanged(Keys.OffscreenCacheSize);
			}
		}

		public uint OffscreenCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.OffscreenCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.OffscreenCacheEntries, value);
				OnSettingsChanged(Keys.OffscreenCacheEntries);
			}
		}

		public uint VirtualChannelCompressionFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.VirtualChannelCompressionFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.VirtualChannelCompressionFlags, value);
				OnSettingsChanged(Keys.VirtualChannelCompressionFlags);
			}
		}

		public uint VirtualChannelChunkSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.VirtualChannelChunkSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.VirtualChannelChunkSize, value);
				OnSettingsChanged(Keys.VirtualChannelChunkSize);
			}
		}

		public bool SoundBeepsEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SoundBeepsEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SoundBeepsEnabled, value);
				OnSettingsChanged(Keys.SoundBeepsEnabled);
			}
		}

		public uint MultifragMaxRequestSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.MultifragMaxRequestSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.MultifragMaxRequestSize, value);
				OnSettingsChanged(Keys.MultifragMaxRequestSize);
			}
		}

		public uint LargePointerFlag
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.LargePointerFlag);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.LargePointerFlag, value);
				OnSettingsChanged(Keys.LargePointerFlag);
			}
		}

		public uint CompDeskSupportLevel
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.CompDeskSupportLevel);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.CompDeskSupportLevel, value);
				OnSettingsChanged(Keys.CompDeskSupportLevel);
			}
		}

		public bool SurfaceCommandsEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.SurfaceCommandsEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.SurfaceCommandsEnabled, value);
				OnSettingsChanged(Keys.SurfaceCommandsEnabled);
			}
		}

		public bool FrameMarkerCommandEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.FrameMarkerCommandEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.FrameMarkerCommandEnabled, value);
				OnSettingsChanged(Keys.FrameMarkerCommandEnabled);
			}
		}

		public bool RemoteFxOnly
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteFxOnly);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteFxOnly, value);
				OnSettingsChanged(Keys.RemoteFxOnly);
			}
		}

		public bool RemoteFxCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteFxCodec);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteFxCodec, value);
				OnSettingsChanged(Keys.RemoteFxCodec);
			}
		}

		public uint RemoteFxCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RemoteFxCodecId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RemoteFxCodecId, value);
				OnSettingsChanged(Keys.RemoteFxCodecId);
			}
		}

		public uint RemoteFxCodecMode
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RemoteFxCodecMode);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RemoteFxCodecMode, value);
				OnSettingsChanged(Keys.RemoteFxCodecMode);
			}
		}

		public bool RemoteFxImageCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RemoteFxImageCodec);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RemoteFxImageCodec, value);
				OnSettingsChanged(Keys.RemoteFxImageCodec);
			}
		}

		public uint RemoteFxCaptureFlags
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.RemoteFxCaptureFlags);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.RemoteFxCaptureFlags, value);
				OnSettingsChanged(Keys.RemoteFxCaptureFlags);
			}
		}

		public bool NSCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.NSCodec);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.NSCodec, value);
				OnSettingsChanged(Keys.NSCodec);
			}
		}

		public uint NSCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.NSCodecId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.NSCodecId, value);
				OnSettingsChanged(Keys.NSCodecId);
			}
		}

		public bool FrameAcknowledge
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.FrameAcknowledge);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.FrameAcknowledge, value);
				OnSettingsChanged(Keys.FrameAcknowledge);
			}
		}

		public bool JpegCodec
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.JpegCodec);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.JpegCodec, value);
				OnSettingsChanged(Keys.JpegCodec);
			}
		}

		public uint JpegCodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.JpegCodecId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.JpegCodecId, value);
				OnSettingsChanged(Keys.JpegCodecId);
			}
		}

		public uint JpegQuality
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.JpegQuality);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.JpegQuality, value);
				OnSettingsChanged(Keys.JpegQuality);
			}
		}

		public uint BitmapCacheV3CodecId
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.BitmapCacheV3CodecId);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.BitmapCacheV3CodecId, value);
				OnSettingsChanged(Keys.BitmapCacheV3CodecId);
			}
		}

		public bool DrawNineGridEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawNineGridEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawNineGridEnabled, value);
				OnSettingsChanged(Keys.DrawNineGridEnabled);
			}
		}

		public uint DrawNineGridCacheSize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DrawNineGridCacheSize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DrawNineGridCacheSize, value);
				OnSettingsChanged(Keys.DrawNineGridCacheSize);
			}
		}

		public uint DrawNineGridCacheEntries
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DrawNineGridCacheEntries);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DrawNineGridCacheEntries, value);
				OnSettingsChanged(Keys.DrawNineGridCacheEntries);
			}
		}

		public bool DrawGdiPlusEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawGdiPlusEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawGdiPlusEnabled, value);
				OnSettingsChanged(Keys.DrawGdiPlusEnabled);
			}
		}

		public bool DrawGdiPlusCacheEnabled
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DrawGdiPlusCacheEnabled);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DrawGdiPlusCacheEnabled, value);
				OnSettingsChanged(Keys.DrawGdiPlusCacheEnabled);
			}
		}

		public bool DeviceRedirection
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.DeviceRedirection);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.DeviceRedirection, value);
				OnSettingsChanged(Keys.DeviceRedirection);
			}
		}

		public uint DeviceCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DeviceCount);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DeviceCount, value);
				OnSettingsChanged(Keys.DeviceCount);
			}
		}

		public uint DeviceArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DeviceArraySize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DeviceArraySize, value);
				OnSettingsChanged(Keys.DeviceArraySize);
			}
		}

		public bool RedirectDrives
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectDrives);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectDrives, value);
				OnSettingsChanged(Keys.RedirectDrives);
			}
		}

		public bool RedirectHomeDrive
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectHomeDrive);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectHomeDrive, value);
				OnSettingsChanged(Keys.RedirectHomeDrive);
			}
		}

		public string DrivesToRedirect
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_string(wfi, (int)Keys.DrivesToRedirect);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_string(wfi, (int)Keys.DrivesToRedirect, value);
				OnSettingsChanged(Keys.DrivesToRedirect);
			}
		}

		public bool RedirectSmartCards
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectSmartCards);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectSmartCards, value);
				OnSettingsChanged(Keys.RedirectSmartCards);
			}
		}

		public bool RedirectPrinters
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectPrinters);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectPrinters, value);
				OnSettingsChanged(Keys.RedirectPrinters);
			}
		}

		public bool RedirectSerialPorts
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectSerialPorts);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectSerialPorts, value);
				OnSettingsChanged(Keys.RedirectSerialPorts);
			}
		}

		public bool RedirectParallelPorts
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectParallelPorts);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectParallelPorts, value);
				OnSettingsChanged(Keys.RedirectParallelPorts);
			}
		}

		public bool RedirectClipboard
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_bool(wfi, (int)Keys.RedirectClipboard);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_bool(wfi, (int)Keys.RedirectClipboard, value);
				OnSettingsChanged(Keys.RedirectClipboard);
			}
		}

		public uint StaticChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.StaticChannelCount);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.StaticChannelCount, value);
				OnSettingsChanged(Keys.StaticChannelCount);
			}
		}

		public uint StaticChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.StaticChannelArraySize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.StaticChannelArraySize, value);
				OnSettingsChanged(Keys.StaticChannelArraySize);
			}
		}

		public uint DynamicChannelCount
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DynamicChannelCount);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DynamicChannelCount, value);
				OnSettingsChanged(Keys.DynamicChannelCount);
			}
		}

		public uint DynamicChannelArraySize
		{
			get
			{
				return NativeMethods.freerdp_client_get_param_uint32(wfi, (int)Keys.DynamicChannelArraySize);
			}
			set
			{
				NativeMethods.freerdp_client_set_param_uint32(wfi, (int)Keys.DynamicChannelArraySize, value);
				OnSettingsChanged(Keys.DynamicChannelArraySize);
			}
		}

	}

	public delegate void FreeRDPSettingsChangedEventHandler(object sender, FreeRDPSettingsChangedEventArgs e);
	public class FreeRDPSettingsChangedEventArgs : EventArgs
	{
		public FreeRDPSettings.Keys Property { get; set; }
	}

}
