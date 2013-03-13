using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AwakeCoding.Common;

namespace AwakeCoding.MsRdpClient
{
    public partial class RDPClientFrame : UserControl, IRDPClient
    {

        #region Private members

        // Current instanciated version of IRdpClient
        private IRDPClient rdpClient = null;

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
            InitializeRdpComponent();
            RegisterEvents();
        }

        private void InitializeRdpComponent()
        {
#if __MONO
			rdpClient = MsRDPLoader.NewRDPClient(MsRDPLoader.RDPClientType.FreeRDP);
#else
			rdpClient = MsRDPLoader.NewRDPClient(MsRDPLoader.RDPClientType.Microsoft);
#endif
            Control ctrl = rdpClient.GetControl();
            ctrl.Dock = DockStyle.Fill;
            Controls.Add(ctrl);
        }


        public AdvancedSettings AdvancedSettings
        {
            get
            {
                return rdpClient.AdvancedSettings;
            }
        }

        public SecuredSettings SecuredSettings
        {
            get
            {
                return rdpClient.SecuredSettings;
            }
        }

        public TransportSettings TransportSettings
        {
            get
            {
                return rdpClient.TransportSettings;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Server
        {
            get
            {
                return rdpClient.Server;
            }
            set
            {
                rdpClient.Server = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get
            {
                return rdpClient.UserName;
            }
            set
            {
                rdpClient.UserName = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Domain
        {
            get
            {
                return rdpClient.Domain;
            }
            set
            {
                rdpClient.Domain = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DesktopWidth
        {
            get
            {
                return rdpClient.DesktopWidth;
            }
            set
            {
                rdpClient.DesktopWidth = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DesktopHeight
        {
            get
            {
                return rdpClient.DesktopHeight;
            }
            set
            {
                rdpClient.DesktopHeight = value;
            }
        }

        public Control GetControl()
        {
            return this;
        }

        public void Connect()
        {
            rdpClient.Connect();
        }

        public void Disconnect()
        {
            rdpClient.Disconnect();
        }


        #region Event Handling

        private void RegisterEvents()
        {
            rdpClient.Connected += rdpClient_Connected;
            rdpClient.Disconnected += rdpClient_Disconnected;
            rdpClient.WarningOccurred += rdpClient_WarningOccurred;
            rdpClient.FatalErrorOccurred += rdpClient_FatalErrorOccurred;
        }

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

    public enum MsRdpClientVersion
    {
        Unknown,
        MsClient50,
        MsClient60,
        MsClient61,
        MsClient70,
        MsClient80
    }

}
