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
using AxMSTSCLib;
using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMsTscAxEvents_OnDisconnectedEventHandler = AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler;
using IMsTscAxEvents_OnFatalErrorEventHandler = AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler;
using IMsTscAxEvents_OnWarningEventHandler = AxMSTSCLib.IMsTscAxEvents_OnWarningEventHandler;

namespace AwakeCoding.MsRdpClient
{
	public class MsRdpClientAdapter : IRDPClient, IDisposable
	{

		// Last detected version of the ActiveX control
		private static RDPClientVersion lastDetectedVersion = RDPClientVersion.Unknown;

		private IMsRDPClient client;
		private InterfaceProxy<IAdvancedSettings> advancedSettingsProxy;
		private InterfaceProxy<ITransportSettings> transportSettingsProxy;
		private InterfaceProxy<ISecuredSettings> securedSettingsProxy;
		private AxHost host;

		public MsRdpClientAdapter()
		{
			try
			{
				TryVersion(RDPClientVersion.MsRDPClient80, () => { client = new MsRDPClient80(); });
				TryVersion(RDPClientVersion.MsRDPClient70, () => { client = new MsRDPClient70(); });
				TryVersion(RDPClientVersion.MsRDPClient61, () => { client = new MsRDPClient61(); });
				TryVersion(RDPClientVersion.MsRDPClient60, () => { client = new MsRDPClient60(); });
				TryVersion(RDPClientVersion.MsRDPClient50, () => { client = new MsRDPClient50(); });

				if (lastDetectedVersion == RDPClientVersion.Unknown)
				{
					throw new NotSupportedException("MsRrdpClient could not be instanciated");
				}

				System.Diagnostics.Debug.WriteLine("AxRDPClient version instanciated: " + lastDetectedVersion);

				host = (AxHost)client;
				host.HandleCreated += MsRdpClientAdapter_HandleCreated;

				RegisterEvents();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
			}
		}

		/// <summary>
		/// Tell the parent container to let this control handle its size and position
		/// </summary>
		public bool HandleSizingInternally
		{
			get { return true; }
		}

		void MsRdpClientAdapter_HandleCreated(object sender, EventArgs e)
		{
			// Finish initialization - com object proxies

			// Rewrap to "authentication settings" ?
			IMsTscNonScriptable securedSettingsOcx = (IMsTscNonScriptable)client.GetOcx();
			//securedSettingsProxy = new InterfaceProxy<ISecuredSettings>();
			//securedSettingsProxy.TargetInstance = securedSettingsOcx;
			//securedSettingsProxy.TargetType = typeof(IMsTscNonScriptable);
			//SecuredSettings = securedSettingsProxy.GetStrongTypedProxy();

			TrySetSecuredSettings(client.SecuredSettings, typeof(IMsTscSecuredSettings));
			TrySetSecuredSettings(client.SecuredSettings2, typeof(IMsRdpClientSecuredSettings));

			TrySetAdvancedSettings(client.AdvancedSettings9, typeof(MSTSCLib.IMsRdpClientAdvancedSettings8));
			TrySetAdvancedSettings(client.AdvancedSettings8, typeof(MSTSCLib.IMsRdpClientAdvancedSettings7));
			TrySetAdvancedSettings(client.AdvancedSettings7, typeof(MSTSCLib.IMsRdpClientAdvancedSettings6));
			TrySetAdvancedSettings(client.AdvancedSettings6, typeof(MSTSCLib.IMsRdpClientAdvancedSettings5));
			TrySetAdvancedSettings(client.AdvancedSettings5, typeof(MSTSCLib.IMsRdpClientAdvancedSettings4));
			TrySetAdvancedSettings(client.AdvancedSettings3, typeof(MSTSCLib.IMsRdpClientAdvancedSettings2));
			TrySetAdvancedSettings(client.AdvancedSettings2, typeof(MSTSCLib.IMsRdpClientAdvancedSettings));
			TrySetAdvancedSettings(client.AdvancedSettings, typeof(MSTSCLib.IMsTscAdvancedSettings));

			transportSettingsProxy = new InterfaceProxy<ITransportSettings>();
			transportSettingsProxy.TargetInstance = client.TransportSettings2;
			transportSettingsProxy.TargetType = typeof(IMsRdpClientTransportSettings2);
			TransportSettings = transportSettingsProxy.GetStrongTypedProxy();

			host.Width = host.Parent.ClientRectangle.Width;
			host.Height = host.Parent.ClientRectangle.Height;
			host.Dock = DockStyle.Fill;

			host.Visible = false;
		}

		private void TrySetAdvancedSettings(object targetInstance, Type targetType)
		{
			if (AdvancedSettings == null && targetInstance != null)
			{
				advancedSettingsProxy = new InterfaceProxy<IAdvancedSettings>();
				advancedSettingsProxy.TargetInstance = targetInstance;
				advancedSettingsProxy.TargetType = targetType;
				AdvancedSettings = advancedSettingsProxy.GetStrongTypedProxy();

				advancedSettingsProxy.SettingsChanged += advancedSettingsProxy_SettingsChanged;
			}
		}

		void advancedSettingsProxy_SettingsChanged(object sender, SettingsChangedEventArgs args)
		{
			if (SettingsChanged != null)
			{
				SettingsChanged(this, args);
			}
		}

		private void TrySetSecuredSettings(object targetInstance, Type targetType)
		{
			if (SecuredSettings == null && targetInstance != null)
			{
				securedSettingsProxy = new InterfaceProxy<ISecuredSettings>();
				securedSettingsProxy.TargetInstance = targetInstance;
				securedSettingsProxy.TargetType = targetType;
				SecuredSettings = securedSettingsProxy.GetStrongTypedProxy();
			}
		}

		public RDPClientVersion ClientVersion
		{
			get
			{
				return lastDetectedVersion;
			}
		}

		public void Attach(Control parent)
		{
			parent.Controls.Add((Control)client);
		}

		private void RegisterEvents()
		{
			if (client != null)
			{
				client.OnConnected += client_OnConnected;
				client.OnDisconnected += client_OnDisconnected;
				client.OnFatalError += client_OnFatalError;
				client.OnWarning += client_OnWarning;
			}
		}

		void client_OnConnected(object sender, EventArgs e)
		{
			if (Connected != null)
			{
				Connected(this, e);
			}
		}

		void client_OnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
		{
			if (WarningOccurred != null)
			{
				WarningOccurred(this, new WarningEventArgs(e.warningCode));
			}
		}

		void client_OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
		{
			if (FatalErrorOccurred != null)
			{
				FatalErrorOccurred(this, new FatalErrorEventArgs(e.errorCode));
			}
		}

		void client_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			if (Disconnected != null)
			{
				Disconnected(this, new DisconnectedEventArgs(e.discReason));
			}
		}

		private void UnregisterEvents()
		{
		}


		private void TryVersion(RDPClientVersion clientVersion, MethodInvoker doApplyVersion)
		{
			try
			{
				if (lastDetectedVersion == RDPClientVersion.Unknown || lastDetectedVersion == clientVersion)
				{
					doApplyVersion();
					lastDetectedVersion = clientVersion;
				}
			}
			catch
			{

				lastDetectedVersion = RDPClientVersion.Unknown;
			}
		}

		public static RDPClientVersion LastDetectedVersion
		{
			get
			{
				return lastDetectedVersion;
			}
		}

		public void Dispose()
		{
			UnregisterEvents();
		}

		public IAdvancedSettings AdvancedSettings
		{
			get;
			private set;
		}

		public ITransportSettings TransportSettings
		{
			get;
			private set;
		}

		public ISecuredSettings SecuredSettings
		{
			get;
			private set;
		}

		public string Server
		{
			get
			{
				return client.Server;
			}
			set
			{
				client.Server = value;
			}
		}

		public string UserName
		{
			get
			{
				return client.UserName;
			}
			set
			{
				client.UserName = value;
			}
		}

		public string Domain
		{
			get
			{
				return client.Domain;
			}
			set
			{
				client.Domain = value;
			}
		}

		public int DesktopWidth
		{
			get
			{
				return client.DesktopWidth;
			}
			set
			{
				client.DesktopWidth = value;
			}
		}

		public int DesktopHeight
		{
			get
			{
				return client.DesktopHeight;
			}
			set
			{
				client.DesktopHeight = value;
			}
		}

		public int ColorDepth
		{
			get
			{
				return client.ColorDepth;
			}
			set
			{
				client.ColorDepth = value;
			}
		}


		/// <summary>
		/// Apply the values of the current RDP Client internal RDP ActiveX component
		/// Override in derived classes to extend the settings that apply to a given version. Always call
		/// the ancestor version.
		/// </summary>
		protected virtual void ApplySettings()
		{
		}

		/// <summary>
		/// Apply the values of AdvancedSettings to the internal RDP ActiveX component
		/// Override in derived classes to extend the settings that apply to a given version. Always call
		/// the ancestor version.
		/// </summary>
		protected virtual void ApplyAdvancedSettings()
		{
		}

		/// <summary>
		/// Apply the values of SecuredSettings to the internal RDP ActiveX component
		/// Override in derived classes to extend the settings that apply to a given version. Always call
		/// the ancestor version.
		/// </summary>
		protected virtual void ApplySecuredSettings()
		{
			//IMsTscNonScriptable secured = (IMsTscNonScriptable) client.GetOcx();

			//secured.ClearTextPassword = SecuredSettings.ClearTextPassword;
			//secured.BinaryPassword = SecuredSettings.BinaryPassword;
			//secured.BinarySalt = SecuredSettings.BinarySalt;
			//secured.PortablePassword = SecuredSettings.PortablePassword;
			//secured.PortableSalt = SecuredSettings.PortableSalt;
		}

		/// <summary>
		/// Apply the values of TransportSettings to the internal RDP ActiveX component
		/// Override in derived classes to extend the settings that apply to a given version. Always call
		/// the ancestor version.
		/// </summary>
		protected virtual void ApplyTransportSettings()
		{
		}


		public void Connect()
		{
			ApplySettings();
			ApplyAdvancedSettings();
			ApplySecuredSettings();
			ApplyTransportSettings();

			client.Connect();
			host.Visible = true;
		}

		public void Disconnect()
		{
			host.Visible = false;
			client.Disconnect();
		}

		public event EventHandler Connected;

		public event DisconnectedEventHandler Disconnected;

		public event FatalErrorEventHandler FatalErrorOccurred;

		public event WarningEventHandler WarningOccurred;


		public bool ContainsFocus
		{
			get
			{
				return client.ContainsFocus;
			}
		}

		public string ConnectedStatusText
		{
			get
			{
				return client.ConnectedStatusText;
			}
			set
			{
				client.ConnectedStatusText = value;
			}
		}

		public string ConnectingText
		{
			get
			{
				return client.ConnectingText;
			}
			set
			{
				client.ConnectingText = value;
			}
		}

		public string DisconnectedText
		{
			get
			{
				return client.DisconnectedText;
			}
			set
			{
				client.DisconnectedText = value;
			}
		}

		public bool FullScreen
		{
			get
			{
				return client.FullScreen;
			}
			set
			{
				client.FullScreen = value;
			}
		}

		public string FullScreenTitle
		{
			set
			{
				client.FullScreenTitle = value;
			}
		}

		public bool HorizontalScrollBarVisible
		{
			get
			{
				return (client.HorizontalScrollBarVisible != 0);
			}
		}

		public bool IsConnected
		{
			get { return (client.Connected != 0); }
		}

		public bool VerticalScrollBarVisible
		{
			get
			{
				return (client.VerticalScrollBarVisible != 0);
			}
		}

		public string GetErrorDescription(uint discReason, uint extendedDisconnectReason)
		{
			return client.GetErrorDescription(discReason, extendedDisconnectReason);
		}

		public int Width
		{
			get { return host.Width; }
		}

		public int Height
		{
			get { return host.Height; }
		}

		public System.Drawing.Point Location
		{
			get
			{
				return host.Location;
			}
			set
			{
				host.Location = value;
			}
		}

		public void SetSize(int width, int height)
		{
			if (host != null)
			{
				host.Height = height;
				host.Width = width;
			}
		}


		public event SettingsChangedEventHandler SettingsChanged;
	}
}
