using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
    public class FreeRDPClient : Panel, IRDPClient, IDisposable
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
                AdvancedSettings = new AdvancedSettingsStub();
                SecuredSettings = new SecuredSettingsStub();
                TransportSettings = new TransportSettingsStub();

                this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("FreeRDPClient Error on ctor: " + ex.ToString());
            }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
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
            FreeWfi();

            base.Dispose(disposing);
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
            get;
            set;
        }

        public int DesktopHeight
        {
            get;
            set;
        }

        public void Connect()
        {
            GlobalInit();

            string[] argv = new string[] 
            { 
                "SimpleClient.exe", 
                "/u:" + UserName, 
                "/p:" + ((SecuredSettingsStub)SecuredSettings).ClearTextPassword, 
                "/d:" + Domain, 
                "/cert-ignore", 
                "/v:" + Server
            };

            StringBuilder cmdline = new StringBuilder();
            for (int i = 0; i < argv.Length; i++)
            {
                cmdline.Append(argv[i] + " ");
            }

            System.Diagnostics.Debug.WriteLine(cmdline.ToString());

            FreeWfi();
            wfi = NativeMethods.wf_new(IntPtr.Zero, this.Handle, argv.Length, argv);

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

        public Control GetControl()
        {
            return this;
        }

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;
    }
}
