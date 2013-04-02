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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
	public class FreeRDPClient : Panel, IRDPClient
	{
		private IntPtr wfi = IntPtr.Zero;
		private static bool staticInitialized = false;

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
		}

		void FreeRDPClient_SettingsChanged(object sender, EventArgs e)
		{
			//// Update smart sizing

			//if (!AdvancedSettings.SmartSizing)
			//{
			//    host.Scale(new System.Drawing.SizeF(1.0F, 1.0F));
			//}
			//else
			//{
			//    UpdateRatio();
			//}
		}

		private void UpdateRatio()
		{
			//host.Scale(new System.Drawing.SizeF(0.5F, 0.5F));

			//if (DesktopWidth > 0 && DesktopHeight > 0)
			//{
			//    float xRatio = Math.Min(1.0F, (float)host.Width / (float)DesktopWidth);
			//    float yRatio = Math.Min(1.0F, (float)host.Height / (float)DesktopHeight);

			//    host.Scale(new System.Drawing.SizeF(xRatio, yRatio));
			//}
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
			get;
			set;
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

			if (AdvancedSettings.SmartSizing)
			{
				this.AutoScroll = false;
			}
			else
			{
				this.AutoScroll = true;
				this.AutoScrollMinSize = new System.Drawing.Size(DesktopWidth, DesktopHeight);
			}

			AdjustSizeAndPosition();

			string[] argv = GetCommandLine();

			StringBuilder cmdline = new StringBuilder();
			for (int i = 0; i < argv.Length; i++)
			{
				cmdline.Append(argv[i] + " ");
			}

			System.Diagnostics.Debug.WriteLine(cmdline.ToString());

			FreeWfi();
			wfi = NativeMethods.wf_new(IntPtr.Zero, /*parent.Handle*/ Handle, argv.Length, argv);

			NativeMethods.wf_start(wfi);
			Visible = true;
			IsConnected = true;

			if (Connected != null)
			{
				Connected(this, EventArgs.Empty);
			}
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

			if (DesktopHeight > 0)
			{ argv.Add("/h:" + DesktopHeight); }

			if (DesktopWidth > 0)
			{ argv.Add("/w:" + DesktopWidth); }

			if (!String.IsNullOrEmpty(Domain))
			{ argv.Add("/d:" + Domain); }

			if (!String.IsNullOrEmpty(Server))
			{ argv.Add("/v:" + Server); }

			if (!String.IsNullOrEmpty(UserName))
			{ argv.Add("/u:" + UserName); }

			if (ColorDepth > 0)
			{
				argv.Add("/bpp:" + ColorDepth);
			}

			// Secured settings
			FreeRDPAdvancedSettings advanced = (FreeRDPAdvancedSettings)AdvancedSettings;
			if (!String.IsNullOrEmpty(advanced.ClearTextPassword))
			{ argv.Add("/p:" + advanced.ClearTextPassword); }

			// Advanced settings

			if (AdvancedSettings.RDPPort > 0)
			{
				argv.Add("/port:" + AdvancedSettings.RDPPort);
			}

			return argv.ToArray();
		}

		public void Disconnect()
		{
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
			parent.Controls.Add(this);
			this.Width = parent.Width;
			this.Height = parent.Height;

			parent.SizeChanged += parent_SizeChanged;
		}

		void parent_SizeChanged(object sender, EventArgs e)
		{
			AdjustSizeAndPosition();
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
			NativeMethods.wf_set_size(wfi, width, height);
		}

		private void AdjustSizeAndPosition()
		{
			int x = Location.X;
			int y = Location.Y;
			int width = this.Width;
			int height = this.Height;

			if (DesktopHeight > 0 && Parent.Height > 0)
			{
				if (Parent.Height <= DesktopHeight)
				{
					y = 0;
					height = Parent.Height;
				}
				else
				{
					y = (Parent.Height - DesktopHeight) / 2;
					height = DesktopHeight;
				}
			}

			if (DesktopWidth > 0 && Parent.Width > 0)
			{
				if (Parent.Width <= DesktopWidth)
				{
					x = 0;
					width = Parent.Width;
				}
				else
				{
					x = (Parent.Width - DesktopWidth) / 2;
					width = DesktopWidth;
				}
			}

			this.Location = new System.Drawing.Point(x, y);

			if (width != this.Width || height != this.Height)
			{
				this.Height = height;
				this.Width = width;
				System.Diagnostics.Debug.WriteLine("width:" + this.Width + " height:" + this.Height);

				if (IsConnected)
				{
					if (AdvancedSettings.SmartSizing)
					{
						NativeMethods.wf_set_size(wfi, Math.Min(DesktopWidth, Parent.Width), Math.Min(DesktopHeight, Parent.Height));
					}
					else
					{
						NativeMethods.wf_set_size(wfi, DesktopWidth, DesktopHeight);
					}
				}
			}
		}
	}
}
