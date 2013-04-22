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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.Common
{
	public interface IAdvancedSettings
	{
		int AcceleratorPassthrough { get; set; }
		int allowBackgroundInput { get; set; }
		bool AudioCaptureRedirectionMode { get; set; }
		uint AudioQualityMode { get; set; }
		uint AudioRedirectionMode { get; set; }
		uint AuthenticationLevel { get; set; }
		string AuthenticationServiceClass { get; set; }
		uint AuthenticationType { get; }
		bool BandwidthDetection { get; set; }
		int BitmapCacheSize { get; set; }
		int BitmapPeristence { get; set; }
		int BitmapPersistence { get; set; }
		int BitmapVirtualCache16BppSize { get; set; }
		int BitmapVirtualCache24BppSize { get; set; }
		int BitmapVirtualCache32BppSize { get; set; }
		int BitmapVirtualCacheSize { get; set; }
		int brushSupportLevel { get; set; }
		int CachePersistenceActive { get; set; }
		bool CanAutoReconnect { get; }
		string ClearTextPassword { get; set; }
		ClientSpec ClientProtocolSpec { get; set; }
		int Compress { get; set; }
		bool ConnectionBarShowMinimizeButton { get; set; }
		bool ConnectionBarShowPinButton { get; set; }
		bool ConnectionBarShowRestoreButton { get; set; }
		bool ConnectToAdministerServer { get; set; }
		// Not supported // bool ConnectToServerConsole { get; set; }
		int ContainerHandledFullScreen { get; set; }
		// Not supported // int DedicatedTerminal { get; set; }
		int DisableCtrlAltDel { get; set; }
		int DisableRdpdr { get; set; }
		bool DisplayConnectionBar { get; set; }
		int DoubleClickDetect { get; set; }
		bool EnableAutoReconnect { get; set; }
		bool EnableCredSspSupport { get; set; }
		// not supported // int EnableMouse { get; set; }
		bool EnableSuperPan { get; set; }
		int EnableWindowsKey { get; set; }
		// not supported // int EncryptionEnabled { get; set; }
		bool GrabFocusOnConnect { get; set; }
		int HotKeyAltEsc { get; set; }
		int HotKeyAltShiftTab { get; set; }
		int HotKeyAltSpace { get; set; }
		int HotKeyAltTab { get; set; }
		int HotKeyCtrlAltDel { get; set; }
		int HotKeyCtrlEsc { get; set; }
		int HotKeyFocusReleaseLeft { get; set; }
		int HotKeyFocusReleaseRight { get; set; }
		int HotKeyFullScreen { get; set; }
		string IconFile { set; }
		int IconIndex { set; }
		// not supported // int InputEventsAtOnce { get; set; }
		int keepAliveInterval { get; set; }
		// not supported // int KeyboardFunctionKey { get; set; }
		string KeyBoardLayoutStr { set; }
		// not supported // int KeyboardSubType { get; set; }
		// not supported // int KeyboardType { get; set; }
		string LoadBalanceInfo { get; set; }
		// not supported // int maxEventCount { get; set; }
		int MaximizeShell { get; set; }
		int MaxReconnectAttempts { get; set; }
		int minInputSendInterval { get; set; }
		int MinutesToIdleTimeout { get; set; }
		bool NegotiateSecurityLayer { get; set; }
		uint NetworkConnectionType { get; set; }
		// not supported // bool NotifyTSPublicKey { get; set; }
		// not supported // int NumBitmapCaches { get; set; }
		// not supported // int orderDrawThreshold { get; set; }
		int overallConnectionTimeout { get; set; }
		string PCB { get; set; }
		int PerformanceFlags { get; set; }
		// Not supported // string PersistCacheDirectory { set; }
		bool PinConnectionBar { get; set; }
		string PluginDlls { set; }
		bool PublicMode { get; set; }
		// not supported // string RdpdrClipCleanTempDirString { get; set; }
		// not supported // string RdpdrClipPasteInfoString { get; set; }
		// not supported // string RdpdrLocalPrintingDocName { get; set; }
		int RDPPort { get; set; }
		bool RedirectClipboard { get; set; }
		bool RedirectDevices { get; set; }
		bool RedirectDirectX { get; set; }
		bool RedirectDrives { get; set; }
		bool RedirectPorts { get; set; }
		bool RedirectPOSDevices { get; set; }
		bool RedirectPrinters { get; set; }
		bool RedirectSmartCards { get; set; }
		bool RelativeMouseMode { get; set; }
		int SasSequence { get; set; }
		// not supported // int ScaleBitmapCachesByBPP { get; set; }
		// not supported // int ShadowBitmap { get; set; }
		int shutdownTimeout { get; set; }
		int singleConnectionTimeout { get; set; }
		bool SmartSizing { get; set; }
		// not supported // int SmoothScroll { get; set; }
		uint SuperPanAccelerationFactor { get; set; }
		int TransportType { get; set; }
		uint VideoPlaybackMode { get; set; }
		// WinCE only // int WinceFixedPalette { get; set; }
	}
}
