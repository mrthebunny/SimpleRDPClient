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
		private Container components = new Container();
		private Timer resizeTimer;
		private IntPtr wfi = IntPtr.Zero;
		private static bool staticInitialized = false;

		private int internalHeight = 0;
		private int internalWidth = 0;

		private bool smartSizing;

		private static void GlobalInit()
		{
			if (!staticInitialized)
			{
				NativeMethods.wf_global_init();
				staticInitialized = true;
				AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
			}
		}

		static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
			NativeMethods.wf_global_uninit();
		}

		public FreeRDPClient()
		{
			try
			{
				AdvancedSettings = new FreeRDPAdvancedSettings();
				TransportSettings = new TransportSettingsStub();
				SecuredSettings = new SecuredSettingsStub();

				Visible = false;

				((FreeRDPAdvancedSettings)AdvancedSettings).SettingsChanged += FreeRDPClient_SettingsChanged;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("FreeRDPClient Error on ctor: " + ex.ToString());
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
				NativeMethods.wf_set_focus(wfi);
			}
		}

		protected override void OnLeave(EventArgs e)
		{
			base.OnLeave(e);
			if (wfi != IntPtr.Zero)
			{
				NativeMethods.wf_kill_focus(wfi);
			}
		}

		void parentForm_Activated(object sender, EventArgs e)
		{
			if (this.Focused && wfi != IntPtr.Zero)
			{
				NativeMethods.wf_set_focus(wfi);
			}
		}

		void parentForm_Deactivate(object sender, EventArgs e)
		{
			if (this.Focused && wfi != IntPtr.Zero)
			{
				NativeMethods.wf_kill_focus(wfi);
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
						NativeMethods.wf_set_setting(wfi, 0, AdvancedSettings.SmartSizing ? 1 : 0);
					}
				}

				SettingsChanged(this, e);
			}
		}

		protected void FreeWfi()
		{
			if (wfi != IntPtr.Zero)
			{
				NativeMethods.wf_free(wfi);
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
				return RDPClientVersion.Stub;
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
			get;
			set;
		}

		public string UserName
		{
			get;
			set;
		}
		public string Domain
		{
			get;
			set;
		}

		public int DesktopWidth
		{
			get;set;
		}

		public int DesktopHeight
		{
			get;
			set;
		}

		public int ColorDepth
		{
			get;
			set;
		}

		public void Connect()
		{
			GlobalInit();

			string[] argv = GetCommandLine();

			StringBuilder cmdline = new StringBuilder();
			for (int i = 0; i < argv.Length; i++)
			{
				cmdline.Append(argv[i] + " ");
			}

			System.Diagnostics.Debug.WriteLine(cmdline.ToString());

			FreeWfi();
			wfi = NativeMethods.wf_new(IntPtr.Zero, /*parent.Handle*/ Handle, argv.Length, argv);


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


			NativeMethods.wf_start(wfi);
			Visible = true;
			IsConnected = true;

			if (Connected != null)
			{
				Connected(this, EventArgs.Empty);
			}

			Focus();
		}

		/// <summary>
		/// Build the commandline array for FreeRDP with the current settings.
		/// </summary>
		/// <returns></returns>
		private string[] GetCommandLine()
		{
			List<string> argv = new List<string>();

			// Mandatory arguments
			argv.Add("SimpleClient.exe");
			argv.Add("-decorations");
			argv.Add("/cert-ignore");
			argv.Add("/h:" + DesktopHeight);
			argv.Add("/w:" + DesktopWidth);

			if (AdvancedSettings.SmartSizing)
			{ argv.Add("+smart-sizing"); }

			if (!String.IsNullOrEmpty(Domain))
			{ argv.Add("/d:" + Domain); }

			if (!String.IsNullOrEmpty(Server))
			{ argv.Add("/v:" + Server); }

			if (!String.IsNullOrEmpty(UserName))
			{ argv.Add("/u:" + UserName); }

			if (ColorDepth > 0)
			{ argv.Add("/bpp:" + ColorDepth); }

			// Secured settings

			// Advanced settings
			FreeRDPAdvancedSettings advanced = (FreeRDPAdvancedSettings)AdvancedSettings;

			if (!String.IsNullOrEmpty(advanced.ClearTextPassword))
			{ argv.Add("/p:" + advanced.ClearTextPassword); }

			if (advanced.RDPPort > 0)
			{ argv.Add("/port:" + AdvancedSettings.RDPPort); }

			return argv.ToArray();
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
			NativeMethods.wf_stop(wfi);

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
			get;
			set;
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
			NativeMethods.wf_set_window_size(wfi, width, height);
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
					NativeMethods.wf_set_window_size(wfi, ClientRectangle.Width, ClientRectangle.Height);
				}
			}
		}

		public event SettingsChangedEventHandler SettingsChanged;
	}
}