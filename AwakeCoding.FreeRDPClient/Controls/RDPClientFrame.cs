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
        private IRDPClient rdpClientImpl = new RDPClientStub();

        #endregion // Private members

        #region Events

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;

        #endregion Events

        public RDPClientFrame()
        {
            InitializeComponent();
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
        public ITransportSettings TransportSettings
        {
            get
            {
                return rdpClientImpl.TransportSettings;
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ColorDepth
        {
            get
            {
                return rdpClientImpl.ColorDepth;
            }
            set
            {
                rdpClientImpl.ColorDepth = value;
            }
        }

        public void Attach(Control parent)
        {
            parent.Controls.Add(this);
        }

        public void Connect()
        {
            BackColor = System.Drawing.SystemColors.AppWorkspace;
            rdpClientImpl.Connect();
        }

        public void Disconnect()
        {
            rdpClientImpl.Disconnect();
            BackColor = System.Drawing.Color.Transparent;
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
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResumeLayout(false);

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ContainsFocus
        {
            get
            {
                return rdpClientImpl.ContainsFocus;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectedStatusText
        {
            get
            {
                return rdpClientImpl.ConnectedStatusText;
            }
            set
            {
                rdpClientImpl.ConnectedStatusText = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectingText
        {
            get
            {
                return rdpClientImpl.ConnectingText;
            }
            set
            {
                rdpClientImpl.ConnectingText = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DisconnectedText
        {
            get
            {
                return rdpClientImpl.DisconnectedText;
            }
            set
            {
                rdpClientImpl.DisconnectedText = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FullScreen
        {
            get
            {
                return rdpClientImpl.FullScreen;
            }
            set
            {
                rdpClientImpl.FullScreen = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FullScreenTitle
        {
            set 
            { 
                rdpClientImpl.FullScreenTitle = value; 
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HorizontalScrollBarVisible
        {
            get 
            {
                return rdpClientImpl.HorizontalScrollBarVisible;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConnected
        {
            get
            {
                return rdpClientImpl.IsConnected;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool VerticalScrollBarVisible
        {
            get 
            {
                return rdpClientImpl.VerticalScrollBarVisible;
            }
        }


        public string GetErrorDescription(uint discReason, uint extendedDisconnectReason)
        {
            return rdpClientImpl.GetErrorDescription(discReason, extendedDisconnectReason);
        }

        public void ForceSize(int width, int height)
        {
            FreeRDPClient client = rdpClientImpl as FreeRDPClient;
            if (client != null)
            {
                client.ForceSize(width, height);
            }
        }
    }

}
