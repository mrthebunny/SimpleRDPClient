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
using System.Windows.Forms;

namespace AwakeCoding.Common
{

	/// <summary>
	/// Common interface used to control a RDP Client component.
	/// </summary>
	public interface IRDPClient
	{
		RDPClientVersion ClientVersion { get; }

		#region Settings
		IAdvancedSettings AdvancedSettings { get; }
		ISecuredSettings SecuredSettings { get; }
		ITransportSettings TransportSettings { get; }

		int ColorDepth { get; set; }
		bool ContainsFocus { get; }
		string ConnectedStatusText { get; set; }
		string ConnectingText { get; set; }
		int DesktopHeight { get; set; }
		int DesktopWidth { get; set; }
		string DisconnectedText { get; set; }
		string Domain { get; set; }
		bool FullScreen { get; set; }
		string FullScreenTitle { set; }
		bool HorizontalScrollBarVisible { get; }
		bool IsConnected { get; }
		string Server { get; set; }
		string UserName { get; set; }
		bool VerticalScrollBarVisible { get; }

		int Width { get; }
		int Height { get; }
		System.Drawing.Point Location { get; set; }

		void SetSize(int width, int height);

		// Set to true to tell the frame to always scale this control to the client area.
		bool HandleSizingInternally { get; }

		#endregion // Settings

		#region Methods
		void Connect();
		void Disconnect();
		void Attach(Control parent);
		string GetErrorDescription(uint discReason, uint extendedDisconnectReason);
		#endregion // Methods

		#region Events

		event EventHandler Connected;
		event DisconnectedEventHandler Disconnected;
		event FatalErrorEventHandler FatalErrorOccurred;
		event WarningEventHandler WarningOccurred;
		event SettingsChangedEventHandler SettingsChanged;

		#endregion // Events
	}

	public class SettingsChangedEventArgs : EventArgs
	{
		public string PropertyName { get; set; }
	}

	public delegate void SettingsChangedEventHandler(object sender, SettingsChangedEventArgs args);

}
