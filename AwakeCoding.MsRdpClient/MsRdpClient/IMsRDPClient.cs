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

namespace AwakeCoding.MsRdpClient
{
	using System;
	using System.Drawing;

	using MSTSCLib;

	using IMsTscAxEvents_OnDisconnectedEventHandler = AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler;
	using IMsTscAxEvents_OnFatalErrorEventHandler = AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler;
	using IMsTscAxEvents_OnWarningEventHandler = AxMSTSCLib.IMsTscAxEvents_OnWarningEventHandler;

	public interface IMsRDPClient
	{
		event EventHandler OnConnected;

		event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

		event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

		event IMsTscAxEvents_OnWarningEventHandler OnWarning;

		IMsTscAdvancedSettings AdvancedSettings { get; }

		IMsRdpClientAdvancedSettings AdvancedSettings2 { get; }

		IMsRdpClientAdvancedSettings2 AdvancedSettings3 { get; }

		IMsRdpClientAdvancedSettings4 AdvancedSettings5 { get; }

		IMsRdpClientAdvancedSettings5 AdvancedSettings6 { get; }

		IMsRdpClientAdvancedSettings6 AdvancedSettings7 { get; }

		IMsRdpClientAdvancedSettings7 AdvancedSettings8 { get; }

		IMsRdpClientAdvancedSettings8 AdvancedSettings9 { get; }

		int ColorDepth { get; set; }

		short Connected { get; }

		string ConnectingText { get; set; }

		bool ContainsFocus { get; }

		int DesktopHeight { get; set; }

		int DesktopWidth { get; set; }

		string Domain { get; set; }

		ExtendedDisconnectReasonCode ExtendedDisconnectReason { get; }

		bool FullScreen { get; set; }

		string FullScreenTitle { set; }

		IMsTscSecuredSettings SecuredSettings { get; }

		IMsRdpClientSecuredSettings SecuredSettings2 { get; }

		string Server { get; set; }

		Size Size { get; }

		IMsRdpClientTransportSettings2 TransportSettings2 { get; }

		string UserName { get; set; }

		void Connect();

		string ConnectedStatusText { get; set; }

		void Disconnect();

		string DisconnectedText { get; set; }

		bool Focus();

		string GetErrorDescription(uint discReason, uint extendedDisconnectReason);

		object GetOcx();

		int HorizontalScrollBarVisible { get; }
		int VerticalScrollBarVisible { get; }


	}
}