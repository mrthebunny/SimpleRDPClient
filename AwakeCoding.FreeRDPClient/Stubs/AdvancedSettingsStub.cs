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

namespace AwakeCoding.FreeRDPClient
{
	public class AdvancedSettingsStub : IAdvancedSettings
	{
		public event SettingsChangedEventHandler SettingsChanged;

		protected virtual void OnSettingsChanged(string propertyName)
		{
			if (SettingsChanged != null)
			{
				SettingsChanged(this, new SettingsChangedEventArgs() { PropertyName = propertyName });
			}
		}

		public int AcceleratorPassthrough
		{
			get;
			set;
		}

		public int allowBackgroundInput
		{
			get;
			set;
		}

		public bool AudioCaptureRedirectionMode
		{
			get;
			set;
		}

		public uint AudioQualityMode
		{
			get;
			set;
		}

		public uint AudioRedirectionMode
		{
			get;
			set;
		}

		public uint AuthenticationLevel
		{
			get;
			set;

		}

		public string AuthenticationServiceClass
		{
			get;
			set;

		}

		public uint AuthenticationType
		{
			get;
			set;

		}

		public bool BandwidthDetection
		{
			get;
			set;

		}

		public int BitmapCacheSize
		{
			get;
			set;

		}

		public int BitmapPeristence
		{
			get;
			set;

		}

		public int BitmapPersistence
		{
			get;
			set;

		}

		public int BitmapVirtualCache16BppSize
		{
			get;
			set;

		}

		public int BitmapVirtualCache24BppSize
		{
			get;
			set;
		}

		public int BitmapVirtualCache32BppSize
		{
			get;
			set;

		}

		public int BitmapVirtualCacheSize
		{
			get;
			set;

		}

		public int brushSupportLevel
		{
			get;
			set;

		}

		public int CachePersistenceActive
		{
			get;
			set;

		}

		public bool CanAutoReconnect
		{
			get;
			set;

		}

		public string ClearTextPassword
		{
			get;
			set;
		}

		public ClientSpec ClientProtocolSpec
		{
			get;
			set;
		}

		public int Compress
		{
			get;
			set;
		}

		public bool ConnectionBarShowMinimizeButton
		{
			get;
			set;
		}

		public bool ConnectionBarShowPinButton
		{
			get;
			set;
		}

		public bool ConnectionBarShowRestoreButton
		{
			get;
			set;
		}

		public bool ConnectToAdministerServer
		{
			get;
			set;
		}

		//public bool ConnectToServerConsole
		//{
		//	get;
		//	set;
		//}

		public int ContainerHandledFullScreen
		{
			get;
			set;
		}

		//public int DedicatedTerminal
		//{
		//	get;
		//	set;
		//}

		public int DisableCtrlAltDel
		{
			get;
			set;
		}

		public int DisableRdpdr
		{
			get;
			set;
		}

		public bool DisplayConnectionBar
		{
			get;
			set;
		}

		public int DoubleClickDetect
		{
			get;
			set;
		}

		public bool EnableAutoReconnect
		{
			get;
			set;
		}

		public bool EnableCredSspSupport
		{
			get;
			set;
		}

		//public int EnableMouse
		//{
		//	get;
		//	set;
		//}

		public bool EnableSuperPan
		{
			get;
			set;
		}

		public int EnableWindowsKey
		{
			get;
			set;
		}

		//public int EncryptionEnabled
		//{
		//	get;
		//	set;
		//}

		public bool GrabFocusOnConnect
		{
			get;
			set;
		}

		public int HotKeyAltEsc
		{
			get;
			set;
		}

		public int HotKeyAltShiftTab
		{
			get;
			set;
		}

		public int HotKeyAltSpace
		{
			get;
			set;
		}

		public int HotKeyAltTab
		{
			get;
			set;
		}

		public int HotKeyCtrlAltDel
		{
			get;
			set;
		}

		public int HotKeyCtrlEsc
		{
			get;
			set;
		}

		public int HotKeyFocusReleaseLeft
		{
			get;
			set;
		}

		public int HotKeyFocusReleaseRight
		{
			get;
			set;
		}

		public int HotKeyFullScreen
		{
			get;
			set;
		}

		public string IconFile
		{
			get;
			set;
  		}

		public int IconIndex
		{
			get;
			set;
		}

		//public int InputEventsAtOnce
		//{
		//	get;
		//	set;
		//}

		public int keepAliveInterval
		{
			get;
			set;
		}

		//public int KeyboardFunctionKey
		//{
		//	get;
		//	set;
		//}

		public string KeyBoardLayoutStr
		{
			get;
			set;
		}

		//public int KeyboardSubType
		//{
		//	get;
		//	set;
		//}

		//public int KeyboardType
		//{
		//	get;
		//	set;
		//}

		public string LoadBalanceInfo
		{
			get;
			set;
		}

		//public int maxEventCount
		//{
		//	get;
		//	set;
		//}

		public int MaximizeShell
		{
			get;
			set;
		}

		public int MaxReconnectAttempts
		{
			get;
			set;
		}

		public int minInputSendInterval
		{
			get;
			set;
		}

		public int MinutesToIdleTimeout
		{
			get;
			set;
		}

		public bool NegotiateSecurityLayer
		{
			get;
			set;
		}

		public uint NetworkConnectionType
		{
			get;
			set;
		}

		//public bool NotifyTSPublicKey
		//{
		//	get;
		//	set;
		//}

		//public int NumBitmapCaches
		//{
		//	get;
		//	set;
		//}

		//public int orderDrawThreshold
		//{
		//	get;
		//	set;
		//}

		public int overallConnectionTimeout
		{
			get;
			set;
		}

		public string PCB
		{
			get;
			set;
		}

		public int PerformanceFlags
		{
			get;
			set;
		}

		//public string PersistCacheDirectory
		//{
		//	get;
		//	set;
		//}

		public bool PinConnectionBar
		{
			get;
			set;
		}

		public string PluginDlls
		{
			get;
			set;
		}

		public bool PublicMode
		{
			get;
			set;
		}

		//public string RdpdrClipCleanTempDirString
		//{
		//	get;
		//	set;
		//}

		//public string RdpdrClipPasteInfoString
		//{
		//	get;
		//	set;
		//}

		//public string RdpdrLocalPrintingDocName
		//{
		//	get;
		//	set;
		//}

		public int RDPPort
		{
			get;
			set;
		}

		public bool RedirectClipboard
		{
			get;
			set;
		}

		public bool RedirectDevices
		{
			get;
			set;
		}

		//public bool RedirectDirectX
		//{
		//	get;
		//	set;
		//}

		public bool RedirectDrives
		{
			get;
			set;
		}

		public bool RedirectPorts
		{
			get;
			set;
		}

		public bool RedirectPOSDevices
		{
			get;
			set;
		}

		public bool RedirectPrinters
		{
			get;
			set;
		}

		public bool RedirectSmartCards
		{
			get;
			set;
		}

		public bool RelativeMouseMode
		{
			get;
			set;
		}

		public int SasSequence
		{
			get;
			set;
		}

		//public int ScaleBitmapCachesByBPP
		//{
		//	get;
		//	set;
		//}

		//public int ShadowBitmap
		//{
		//	get;
		//	set;
		//}

		public int shutdownTimeout
		{
			get;
			set;
		}

		public int singleConnectionTimeout
		{
			get;
			set;
		}

		private bool smartSizing;
		public bool SmartSizing
		{
			get
			{
				return smartSizing;
			}
			set
			{
				smartSizing = value;
				OnSettingsChanged("SmartSizing");
			}
		}

		//public int SmoothScroll
		//{
		//	get;
		//	set;
		//}

		public uint SuperPanAccelerationFactor
		{
			get;
			set;
		}

		public int TransportType
		{
			get;
			set;
		}

		public uint VideoPlaybackMode
		{
			get;
			set;
		}

		//public int WinceFixedPalette
		//{
		//	get;
		//	set;
		//}
	}
}
