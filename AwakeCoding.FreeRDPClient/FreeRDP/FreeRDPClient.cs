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
using AwakeCoding.FreeRDPClient.FreeRDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
	public class FreeRDPClient : Panel, IRDPClient
	{
		private static bool staticInitialized = false;

		private Container components = new Container();
		private IntPtr wfi = IntPtr.Zero;
		private FreeRDPSettings freeRDPsettings;

		private int internalHeight = 0;
		private int internalWidth = 0;

		private static void GlobalInit()
		{
			if (!staticInitialized)
			{
				NativeMethods.freerdp_client_global_init();
				staticInitialized = true;
				AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
			}
		}

		static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
			NativeMethods.freerdp_client_global_uninit();
		}

		public FreeRDPClient()
		{
			try
			{
				GlobalInit();

				string[] argv = new string[] { System.IO.Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) };

				StringBuilder cmdline = new StringBuilder();
				for (int i = 0; i < argv.Length; i++)
				{
					cmdline.Append(argv[i] + " ");
				}

				System.Diagnostics.Debug.WriteLine(cmdline.ToString());

				wfi = NativeMethods.freerdp_client_new(argv.Length, argv);
				freeRDPsettings = new FreeRDPSettings(wfi);

				AdvancedSettings = new FreeRDPAdvancedSettings(freeRDPsettings);
				TransportSettings = new FreeRDPTransportSettings(freeRDPsettings);
				SecuredSettings = new FreeRDPSecuredSettings(freeRDPsettings);

				Visible = false;

				((FreeRDPAdvancedSettings)AdvancedSettings).SettingsChanged += FreeRDPClient_SettingsChanged;
				((FreeRDPTransportSettings)TransportSettings).SettingsChanged += FreeRDPClient_SettingsChanged;
				((FreeRDPSecuredSettings)SecuredSettings).SettingsChanged += FreeRDPClient_SettingsChanged;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("FreeRDPClient Error on ctor: " + ex.ToString());
				throw;
			}

			this.SetStyle(ControlStyles.Selectable, true);

			this.TabStop = true;
		}

		public bool HandleSizingInternally 
		{ 
			get { return false; } 
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == (int) WM.MOUSEACTIVATE)
			{
				Focus();
			}

			base.WndProc(ref m);
		}

		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);
			if (wfi != IntPtr.Zero)
			{
				NativeMethods.freerdp_client_focus_in(wfi);
			}
		}

		protected override void OnLeave(EventArgs e)
		{
			base.OnLeave(e);
			if (wfi != IntPtr.Zero)
			{
				NativeMethods.freerdp_client_focus_out(wfi);
			}
		}

		void parentForm_Activated(object sender, EventArgs e)
		{
			if (this.Focused && wfi != IntPtr.Zero)
			{
				NativeMethods.freerdp_client_focus_in(wfi);
			}
		}

		void parentForm_Deactivate(object sender, EventArgs e)
		{
			if (this.Focused && wfi != IntPtr.Zero)
			{
				NativeMethods.freerdp_client_focus_out(wfi);
			}
		}

		void FreeRDPClient_SettingsChanged(object sender, SettingsChangedEventArgs e)
		{
			if (SettingsChanged != null)
			{
				if (e.PropertyName == "SmartSizing")
				{
					if (IsConnected)
					{
						NativeMethods.freerdp_client_set_window_size(wfi, ClientRectangle.Width, ClientRectangle.Height);
					}
				}

				SettingsChanged(this, e);
			}
		}

		protected void FreeWfi()
		{
			if (wfi != IntPtr.Zero)
			{
				NativeMethods.freerdp_client_free(wfi);
				wfi = IntPtr.Zero;
			}
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components.Dispose();
				FreeWfi();
			}

			base.Dispose(disposing);
		}

		public RDPClientVersion ClientVersion
		{
			get
			{
				return RDPClientVersion.FreeRDP;
			}
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
				return freeRDPsettings.ServerHostname;
			}
			set
			{
				freeRDPsettings.ServerHostname = value;
			}
		}

		public string UserName
		{
			get
			{
				return freeRDPsettings.Username;
			}
			set
			{
				freeRDPsettings.Username = value;
			}
		}
		public string Domain
		{
			get
			{
				return freeRDPsettings.Domain;
			}
			set
			{
				freeRDPsettings.Domain = value;
			}
		}

		public int DesktopWidth
		{
			get
			{
				return (int)freeRDPsettings.DesktopWidth;
			}
			set
			{
				freeRDPsettings.DesktopWidth = (uint)value;
			}
		}

		public int DesktopHeight
		{
			get
			{
				return (int) freeRDPsettings.DesktopHeight;
			}
			set
			{
				freeRDPsettings.DesktopHeight = (uint)value;
			}
		}

		public int ColorDepth
		{
			get
			{
				return (int) freeRDPsettings.ColorDepth;
			}
			set
			{
				freeRDPsettings.ColorDepth = (uint) value;
			}
		}

		public void Connect()
		{
			ApplySettings();

			Control current = Parent;
			Form parentForm = null;
			while (current != null)
			{
				parentForm = current as Form;
				if (parentForm != null)
					break;
				current = current.Parent;
			}

			if (parentForm != null)
			{
				//parentForm.ResizeEnd += parentForm_ResizeEnd;
				
				parentForm.Deactivate += parentForm_Deactivate;
				parentForm.Activated += parentForm_Activated;
			}


			NativeMethods.freerdp_client_start(wfi);
			Visible = true;
			IsConnected = true;

			if (Connected != null)
			{
				Connected(this, EventArgs.Empty);
			}

			Focus();
		}

		private void ApplySettings()
		{
			freeRDPsettings.ParentWindowId = (ulong)this.Handle.ToInt64();
			freeRDPsettings.Domain = this.Domain;
			freeRDPsettings.ServerHostname = this.Server;
			freeRDPsettings.Username = this.UserName;
			freeRDPsettings.Password = ((FreeRDPAdvancedSettings) this.AdvancedSettings).ClearTextPassword;
			freeRDPsettings.DesktopHeight = (uint) DesktopHeight;
			freeRDPsettings.DesktopWidth = (uint) DesktopWidth;
			freeRDPsettings.Decorations = false;
			freeRDPsettings.IgnoreCertificate = true;
			freeRDPsettings.SmartSizing = AdvancedSettings.SmartSizing;

			if (AdvancedSettings.RDPPort > 0)
			{
				freeRDPsettings.ServerPort = (uint) AdvancedSettings.RDPPort;
			}

			if (ColorDepth > 0)
			{
				freeRDPsettings.ColorDepth = (uint) ColorDepth;
			}

			// gateway ?
		}

		public void Disconnect()
		{
			Control current = Parent;
			Form parentForm = null;
			while (current != null)
			{
				parentForm = current as Form;
				if (parentForm != null)
					break;
				current = current.Parent;
			}

			if (parentForm != null)
			{
				parentForm.Deactivate -= parentForm_Deactivate;
				parentForm.Activated -= parentForm_Activated;
			}

			Visible = false;
			NativeMethods.freerdp_client_stop(wfi);

			IsConnected = false;
			if (Disconnected != null)
			{
				Disconnected(this, new DisconnectedEventArgs(0));
			}
		}

		public void Attach(Control parent)
		{
			this.Parent = parent;
			this.Width = parent.ClientRectangle.Width;
			this.Height = parent.ClientRectangle.Height;
		}

		public event EventHandler Connected;

		public event DisconnectedEventHandler Disconnected;

		public event FatalErrorEventHandler FatalErrorOccurred;

		public event WarningEventHandler WarningOccurred;


		public string ConnectedStatusText
		{
			get;
			set;
		}

		public string ConnectingText
		{
			get;
			set;
		}

		public string DisconnectedText
		{
			get;
			set;
		}

		public bool FullScreen
		{
			get
			{
				return freeRDPsettings.Fullscreen;
			}
			set
			{
				freeRDPsettings.Fullscreen = value;
			}
		}

		public string FullScreenTitle
		{
			get;
			set;
		}

		public bool HorizontalScrollBarVisible
		{
			get
			{
				return HorizontalScroll.Visible;
			}
		}

		public bool IsConnected
		{
			get;
			private set;
		}

		public bool VerticalScrollBarVisible
		{
			get
			{
				return VerticalScroll.Visible;
			}
		}

		public string GetErrorDescription(uint discReason, uint extendedDisconnectReason)
		{
			throw new NotImplementedException();
		}

		// Temporary - test method
		internal void ForceSize(int width, int height)
		{
			NativeMethods.freerdp_client_set_window_size(wfi, width, height);
		}

		public void SetSize(int width, int height)
		{
			Width = width;
			Height = height;

			if (internalHeight != Height || internalWidth != Width)
			{
				internalHeight = Height;
				internalWidth = Width;
				if (IsConnected)
				{
					NativeMethods.freerdp_client_set_window_size(wfi, ClientRectangle.Width, ClientRectangle.Height);
				}
			}
		}

		public event SettingsChangedEventHandler SettingsChanged;
	}
}