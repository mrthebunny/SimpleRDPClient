/**
 * FreeRDP: A Remote Desktop Protocol Implementation
 *
 * Copyright 2013 Benoit LeBlanc <benoit.leblanc@awakecoding.com>
 * Copyright 2013 Awake Coding Consulting Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient.FreeRDP
{
	public class FreeRDPAdvancedSettings : IAdvancedSettings
	{
		public event SettingsChangedEventHandler SettingsChanged;

		private FreeRDPSettings settings;

		public FreeRDPAdvancedSettings(FreeRDPSettings settings)
		{
			this.settings = settings;
		}

		private void OnSettingsChanged(string property)
		{
			if (SettingsChanged != null)
			{
				SettingsChanged(this, new SettingsChangedEventArgs() { PropertyName = property });
			}
		}

		private int _acceleratorPassthrough;
		public int AcceleratorPassthrough
		{
			get
			{
				return _acceleratorPassthrough;
			}
			set
			{
				_acceleratorPassthrough = value;
				OnSettingsChanged("AcceleratorPassthrough");
			}
		}

		private int _allowBackgroundInput;
		public int allowBackgroundInput
		{
			get
			{
				return _allowBackgroundInput;
			}
			set
			{
				_allowBackgroundInput = value;
				OnSettingsChanged("allowBackgroundInput");
			}
		}

		public bool AudioCaptureRedirectionMode
		{
			get
			{
				return settings.AudioCapture;
			}
			set
			{
				settings.AudioCapture = value;
			}
		}

		public uint AudioQualityMode
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public uint AudioRedirectionMode
		{
			get
			{
				if (settings.AudioPlayback)
					return RDPConstants.AUDIO_MODE_REDIRECT;

				if (settings.RemoteConsoleAudio)
					return RDPConstants.AUDIO_MODE_PLAY_ON_SERVER;

				return RDPConstants.AUDIO_MODE_NONE;
			}
			set
			{
				bool audioPlayback = false;
				bool remoteConsoleAudio = false;

				if (value == RDPConstants.AUDIO_MODE_REDIRECT)
				{
					audioPlayback = true;
				}
				else if (value == RDPConstants.AUDIO_MODE_PLAY_ON_SERVER)
				{
					remoteConsoleAudio = true;
				}

				settings.AudioPlayback = audioPlayback;
				settings.RemoteConsoleAudio = remoteConsoleAudio;
			}
		}

		/// <summary>
		/// TODO
		/// 0 No authentication of the server.
		/// 1 Server authentication is required and must complete successfully for the connection to proceed.
		/// 2 Attempt authentication of the server. If authentication fails, the user will be prompted with the option to cancel the connection or to proceed without server authentication.
		/// </summary>
		public uint AuthenticationLevel
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string AuthenticationServiceClass
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//0 No authentication is used.
		//1 Certificate authentication is used.
		//2 Kerberos authentication is used.
		//3 Both certificate and Kerberos authentication are used.
		public uint AuthenticationType
		{
			get { throw new NotImplementedException(); }
		}

		public bool BandwidthDetection
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int BitmapCacheSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int BitmapPeristence
		{
			get
			{
				return settings.BitmapCachePersistEnabled ? 1 : 0;
			}
			set
			{
				settings.BitmapCachePersistEnabled = (value == 0 ? false : true);
			}
		}

		public int BitmapPersistence
		{
			get
			{
				return settings.BitmapCachePersistEnabled ? 1 : 0;
			}
			set
			{
				settings.BitmapCachePersistEnabled = (value == 0 ? false : true);
			}
		}

		public int BitmapVirtualCache16BppSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int BitmapVirtualCache24BppSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int BitmapVirtualCache32BppSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int BitmapVirtualCacheSize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int brushSupportLevel
		{
			get
			{
				return (int) settings.BrushSupportLevel;
			}
			set
			{
				settings.BrushSupportLevel = (uint) value;
			}
		}

		public int CachePersistenceActive
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool CanAutoReconnect
		{
			get { return settings.AutoReconnectionEnabled; }
		}

		public string ClearTextPassword
		{
			get
			{
				return settings.Password;
			}
			set
			{
				settings.Password = value;
			}
		}

		public ClientSpec ClientProtocolSpec
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int Compress
		{
			get
			{
				return settings.CompressionEnabled ? 1 : 0;
			}
			set
			{
				settings.CompressionEnabled = (value == 0 ? false : true);
			}
		}

		public bool ConnectionBarShowMinimizeButton
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool ConnectionBarShowPinButton
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool ConnectionBarShowRestoreButton
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool ConnectToAdministerServer
		{
			get
			{
				return settings.ConsoleSession;
			}
			set
			{
				settings.ConsoleSession = value;
			}
		}

		//public bool ConnectToServerConsole
		//{
		//	get
		//	{
		//		return settings.ConsoleSession;
		//	}
		//	set
		//	{
		//		settings.ConsoleSession = value;
		//	}
		//}

		public int ContainerHandledFullScreen
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int DedicatedTerminal
		//{
		//	get
		//	{
		//		// NOT SUPPORTED as of WinXP SP2
		//		return 0;
		//	}
		//	set
		//	{
		//	}
		//}

		public int DisableCtrlAltDel
		{
			get
			{
				return settings.DisableCtrlAltDel ? 1 : 0;
			}
			set
			{
				settings.DisableCtrlAltDel = (value == 0 ? false : true);
			}
		}

		public int DisableRdpdr
		{
			get
			{
				return settings.RedirectClipboard ? 0 : 1;
			}
			set
			{
				settings.RedirectClipboard = value == 0 ? true : false;
			}
		}

		public bool DisplayConnectionBar
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int DoubleClickDetect
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool EnableAutoReconnect
		{
			get
			{
				return settings.AutoReconnectionEnabled;
			}
			set
			{
				settings.AutoReconnectionEnabled = value;
			}
		}

		public bool EnableCredSspSupport
		{
			get
			{
				return settings.NlaSecurity;
			}
			set
			{
				settings.NlaSecurity = value;
			}
		}

		//public int EnableMouse
		//{
		//	get
		//	{
		//		return settings.MouseAttached ? 1 : 0;
		//	}
		//	set
		//	{
		//		settings.MouseAttached = value == 0 ? false : true;
		//	}
		//}

		public bool EnableSuperPan
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int EnableWindowsKey
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int EncryptionEnabled
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public bool GrabFocusOnConnect
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyAltEsc
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyAltShiftTab
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyAltSpace
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyAltTab
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyCtrlAltDel
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyCtrlEsc
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyFocusReleaseLeft
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyFocusReleaseRight
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int HotKeyFullScreen
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string IconFile
		{
			set { throw new NotImplementedException(); }
		}

		public int IconIndex
		{
			set { throw new NotImplementedException(); }
		}

		//public int InputEventsAtOnce
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public int keepAliveInterval
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int KeyboardFunctionKey
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public string KeyBoardLayoutStr
		{
			set { throw new NotImplementedException(); }
		}

		//public int KeyboardSubType
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public int KeyboardType
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public string LoadBalanceInfo
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int maxEventCount
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public int MaximizeShell
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int MaxReconnectAttempts
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int minInputSendInterval
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int MinutesToIdleTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool NegotiateSecurityLayer
		{
			get
			{
				return settings.NegotiateSecurityLayer;
			}
			set
			{
				settings.NegotiateSecurityLayer = value;
			}
		}

		public uint NetworkConnectionType
		{
			get
			{
				return settings.ConnectionType;
			}
			set
			{
				settings.ConnectionType = value;
			}
		}

		//public bool NotifyTSPublicKey
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public int NumBitmapCaches
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public int orderDrawThreshold
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public int overallConnectionTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string PCB
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int PerformanceFlags
		{
			get
			{
				// TS_PERF_ENABLE_ENHANCED_GRAPHICS ?

  				int flags = RDPConstants.TS_PERF_DISABLE_NOTHING;

				if (settings.DisableWallpaper)
					flags |= RDPConstants.TS_PERF_DISABLE_WALLPAPER;

				if (settings.DisableFullWindowDrag)
					flags |= RDPConstants.TS_PERF_DISABLE_FULLWINDOWDRAG;

				if (settings.DisableMenuAnims)
					flags |= RDPConstants.TS_PERF_DISABLE_MENUANIMATIONS;

				if (settings.DisableThemes)
					flags |= RDPConstants.TS_PERF_DISABLE_THEMING;

				if (settings.DisableCursorShadow)
					flags |= RDPConstants.TS_PERF_DISABLE_CURSOR_SHADOW;

				if (settings.DisableCursorBlinking)
					flags |= RDPConstants.TS_PERF_DISABLE_CURSORSETTINGS;

				if (settings.AllowFontSmoothing)
					flags |= RDPConstants.TS_PERF_ENABLE_FONT_SMOOTHING;

				if (settings.AllowDesktopComposition)
					flags |= RDPConstants.TS_PERF_ENABLE_DESKTOP_COMPOSITION;

				return flags;
			}
			set
			{
				// TS_PERF_ENABLE_ENHANCED_GRAPHICS ?

				settings.DisableWallpaper = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_WALLPAPER));
				settings.DisableFullWindowDrag = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_FULLWINDOWDRAG));
				settings.DisableMenuAnims = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_MENUANIMATIONS));
				settings.DisableThemes = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_THEMING));
				settings.DisableCursorShadow = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_CURSOR_SHADOW));
				settings.DisableCursorBlinking = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_DISABLE_CURSORSETTINGS));
				settings.AllowFontSmoothing = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_ENABLE_FONT_SMOOTHING));
				settings.AllowDesktopComposition = (RDPConstants.TS_PERF_DISABLE_NOTHING != (value & RDPConstants.TS_PERF_ENABLE_DESKTOP_COMPOSITION));
			}
		}

		public bool PinConnectionBar
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string PluginDlls
		{
			set { throw new NotImplementedException(); }
		}

		public bool PublicMode
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public string RdpdrClipCleanTempDirString
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public string RdpdrClipPasteInfoString
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public string RdpdrLocalPrintingDocName
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public int RDPPort
		{
			get
			{
				return (int) settings.ServerPort;
			}
			set
			{
				settings.ServerPort = (uint)value;
			}
		}

		public bool RedirectClipboard
		{
			get
			{
				return settings.RedirectClipboard;
			}
			set
			{
				settings.RedirectClipboard = value;
			}
		}

		public bool RedirectDevices
		{
			get
			{
				return settings.DeviceRedirection;
			}
			set
			{
				settings.DeviceRedirection = value;
			}
		}

		///// <summary>
		/////  Not used
		///// </summary>
		//public bool RedirectDirectX
		//{
		//	get
		//	{
		//		throw new NotSupportedException();
		//	}
		//	set
		//	{
		//		throw new NotSupportedException();
		//	}
		//}

		public bool RedirectDrives
		{
			get
			{
				return settings.RedirectDrives;
			}
			set
			{
				settings.RedirectDrives = value;
			}
		}

		public bool RedirectPorts
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool RedirectPOSDevices
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool RedirectPrinters
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool RedirectSmartCards
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool RelativeMouseMode
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int SasSequence
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int ScaleBitmapCachesByBPP
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		//public int ShadowBitmap
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public int shutdownTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int singleConnectionTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool SmartSizing
		{
			get
			{
				return settings.SmartSizing;
			}
			set
			{
				settings.SmartSizing = value;
				OnSettingsChanged("SmartSizing");
			}
		}

		//public int SmoothScroll
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		public uint SuperPanAccelerationFactor
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int TransportType
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public uint VideoPlaybackMode
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public int WinceFixedPalette
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//	set
		//	{
		//		throw new NotImplementedException();
		//	}
		//}
	}
}
