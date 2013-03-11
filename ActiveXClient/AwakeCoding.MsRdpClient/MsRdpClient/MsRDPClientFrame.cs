using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AwakeCoding.Common;
using MSTSCLib;



namespace AwakeCoding.MsRdpClient
{
    public partial class MSRDPClientFrame : UserControl, IRDPClient
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

        public MSRDPClientFrame()
        {
            AdvancedSettings = new Common.AdvancedSettings();
            SecuredSettings = new Common.SecuredSettings();
            TransportSettings = new Common.TransportSettings();

            InitializeComponent();
            InitializeRdpComponent();
            RegisterEvents();
        }

        private void InitializeRdpComponent()
        {
            rdpClient = new MsRdpClientAdapter();

            Control component = (Control)rdpClient;
            component.Dock = DockStyle.Fill;
            Controls.Add(component);
        }


        public AdvancedSettings AdvancedSettings
        {
            get;
            set;
        }

        public SecuredSettings SecuredSettings
        {
            get;
            set;
        }

        public TransportSettings TransportSettings
        {
            get;
            set;
        }

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
        }

        #endregion // Event Handling

    }
}
