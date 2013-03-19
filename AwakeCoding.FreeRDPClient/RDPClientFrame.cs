using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Text;
using System.Windows.Forms;

using AwakeCoding.Common;

namespace AwakeCoding.MsRdpClient
{
    public partial class RDPClientFrame : UserControl, IRDPClient
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
            InitializeComponent();

        }

        //protected override void InitLayout()
        protected override void OnLoad(EventArgs e)
{
 	 base.OnLoad(e);

            InitializeRdpComponent();
            RegisterEvents();

            //base.InitLayout();
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

            Control ctrl = rdpClientImpl.GetControl();
            ctrl.Dock = DockStyle.Fill;
            Controls.Add(ctrl);
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

        public Control GetControl()
        {
            return this;
        }

        public void Connect()
        {
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

    }

}
