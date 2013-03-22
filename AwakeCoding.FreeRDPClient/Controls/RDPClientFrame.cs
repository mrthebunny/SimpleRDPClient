using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Text;
using System.Windows.Forms;

using AwakeCoding.Common;

namespace AwakeCoding.FreeRDPClient
{
    public partial class RDPClientFrame : Panel, IRDPClient
    {

        #region Private members

        // Default value differs depending on platform
#if __MONO
        private RDPClientVersion clientVersion = RDPClientVersion.FreeRDP;
#else
        private RDPClientVersion clientVersion = RDPClientVersion.MsRDPClient;
#endif

        // Current instanciated version of IRdpClient
        private IRDPClient rdpClientImpl = null;

        #endregion // Private members

        #region Events

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;

        #endregion Events

        public RDPClientFrame()
        {
            this.HandleCreated += RDPClientFrame_HandleCreated;
        }

        void RDPClientFrame_HandleCreated(object sender, EventArgs e)
        {
            InitializeRdpComponent();
            RegisterEvents();
        }

        protected override void InitLayout()
        {
 	        base.InitLayout();
        }


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                IDisposable disp = rdpClientImpl as IDisposable;
                if (disp != null)
                {
                    disp.Dispose();
                    rdpClientImpl = null;
                }
            }

            base.Dispose(disposing);
        }

        private void RegisterEvents()
        {
            rdpClientImpl.Connected += rdpClient_Connected;
            rdpClientImpl.Disconnected += rdpClient_Disconnected;
            rdpClientImpl.WarningOccurred += rdpClient_WarningOccurred;
            rdpClientImpl.FatalErrorOccurred += rdpClient_FatalErrorOccurred;
        }


        private void InitializeRdpComponent()
        {
            rdpClientImpl = RDPClientLoader.NewRDPClient(ClientVersion);
            rdpClientImpl.Attach(this);
        }

        [Browsable(false)]
        public IAdvancedSettings AdvancedSettings
        {
            get
            {
                return rdpClientImpl.AdvancedSettings;
            }
        }

        [Browsable(false)]
        public ISecuredSettings SecuredSettings
        {
            get
            {
                return rdpClientImpl.SecuredSettings;
            }
        }

        [Browsable(false)]
        public ITransportSettings TransportSettings
        {
            get
            {
                return rdpClientImpl.TransportSettings;
            }
        }

        public RDPClientVersion ClientVersion
        {
            get
            {
                return clientVersion;
            }
            set
            {
                clientVersion = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Server
        {
            get
            {
                return rdpClientImpl.Server;
            }
            set
            {
                rdpClientImpl.Server = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get
            {
                return rdpClientImpl.UserName;
            }
            set
            {
                rdpClientImpl.UserName = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Domain
        {
            get
            {
                return rdpClientImpl.Domain;
            }
            set
            {
                rdpClientImpl.Domain = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DesktopWidth
        {
            get
            {
                return rdpClientImpl.DesktopWidth;
            }
            set
            {
                rdpClientImpl.DesktopWidth = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DesktopHeight
        {
            get
            {
                return rdpClientImpl.DesktopHeight;
            }
            set
            {
                rdpClientImpl.DesktopHeight = value;
            }
        }

        public void Attach(Control parent)
        {
            parent.Controls.Add(this);
        }

        public void Connect()
        {
            this.MaximumSize = new System.Drawing.Size(DesktopWidth, DesktopHeight);
            rdpClientImpl.Connect();
        }

        public void Disconnect()
        {
            rdpClientImpl.Disconnect();
        }


        #region Event Handling

        void rdpClient_FatalErrorOccurred(object sender, FatalErrorEventArgs e)
        {
            if (FatalErrorOccurred != null)
            {
                FatalErrorOccurred(this, e);
            }
        }

        void rdpClient_WarningOccurred(object sender, WarningEventArgs e)
        {
            if (WarningOccurred != null)
            {
                WarningOccurred(this, e);
            }
        }

        void rdpClient_Disconnected(object sender, DisconnectedEventArgs e)
        {
            if (Disconnected != null)
            {
                Disconnected(this, e);
            }
        }

        void rdpClient_Connected(object sender, EventArgs e)
        {
            if (Connected != null)
            {
                Connected(this, e);
            }
        }

        #endregion // Event Handling

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RDPClientFrame
            // 
            this.Name = "RDPClientFrame";
            this.ResumeLayout(false);

        }
    }

}
