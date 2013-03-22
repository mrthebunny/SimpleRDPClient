using AwakeCoding.Common;
using AwakeCoding.FreeRDPClient.FreeRDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
    public class FreeRDPClient : IRDPClient, IDisposable
    {
        private IntPtr wfi = IntPtr.Zero;
        private static bool staticInitialized = false;

        private Panel host;


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
                SecuredSettings = new SecuredSettingsStub();
                TransportSettings = new TransportSettingsStub();

                ((FreeRDPAdvancedSettings)AdvancedSettings).SettingsChanged += FreeRDPClient_SettingsChanged;
                
                host = new Panel();
                host.Dock = DockStyle.Fill;
                host.SizeChanged += host_SizeChanged;
                //host.AutoScroll = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("FreeRDPClient Error on ctor: " + ex.ToString());
            }
        }

        void host_SizeChanged(object sender, EventArgs e)
        {
            //if (AdvancedSettings.SmartSizing)
            //{
            //    UpdateRatio();
            //}
        }

        void FreeRDPClient_SettingsChanged(object sender, EventArgs e)
        {
            // Update smart sizing

            if (!AdvancedSettings.SmartSizing)
            {
                host.Scale(new System.Drawing.SizeF(1.0F, 1.0F));
            }
            else
            {
                UpdateRatio();
            }
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
        public void Dispose()
        {
            FreeWfi();
        }

        void panel_HandleCreated(object sender, EventArgs e)
        {
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
            set;
        }

        public ISecuredSettings SecuredSettings
        {
            get;
            set;
        }
        public ITransportSettings TransportSettings
        {
            get;
            set;
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
            get;set;
        }

        public void Connect()
        {
            GlobalInit();

            //host.MaximumSize = new System.Drawing.Size(DesktopWidth, DesktopHeight);
            host.AutoScrollMinSize = new System.Drawing.Size(DesktopWidth, DesktopHeight);

            string[] argv = new string[] 
            { 
                "SimpleClient.exe", 
                "/u:" + UserName, 
                "/p:" + ((SecuredSettingsStub)SecuredSettings).ClearTextPassword, 
                "/d:" + Domain, 
                "/cert-ignore", 
                "/v:" + Server,
                "-decorations",
                "/w:" + DesktopWidth,
                "/h:" + DesktopHeight
            };

            StringBuilder cmdline = new StringBuilder();
            for (int i = 0; i < argv.Length; i++)
            {
                cmdline.Append(argv[i] + " ");
            }

            System.Diagnostics.Debug.WriteLine(cmdline.ToString());

            FreeWfi();
            wfi = NativeMethods.wf_new(IntPtr.Zero, /*parent.Handle*/ host.Handle, argv.Length, argv);

            NativeMethods.wf_start(wfi);
            if (Connected != null)
            {
                Connected(this, EventArgs.Empty);
            }
        }

        public void Disconnect()
        {
            NativeMethods.wf_stop(wfi);
            if (Disconnected != null)
            {
                Disconnected(this, new DisconnectedEventArgs(0));
            }
        }

        public void Attach(Control parent)
        {
            //this.parent = parent;
            parent.Controls.Add(host);
        }

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;
    }
}
