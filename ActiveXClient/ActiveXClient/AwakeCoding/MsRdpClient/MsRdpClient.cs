using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxMSTSCLib;
using AwakeCoding.Common;



namespace AwakeCoding.MsRdpClient
{
    public partial class MsRDPClient : UserControl, IRdpClient
    {
        // Last detected version of the ActiveX control
        private static MsRdpClientVersion lastDetectedVersion = MsRdpClientVersion.Unknown;

        // Current instanciated version of IRdpClient
        private IMsRdpClient internalMsClient = null;

        public MsRDPClient()
        {
            InitializeComponent();
            InitializeRdpComponent();
        }

        public static MsRdpClientVersion LastDetectedVersion
        {
            get
            {
                return lastDetectedVersion;
            }
        }

        private void InitializeRdpComponent()
        {
            TryVersion(MsRdpClientVersion.MsClient80, () => { internalMsClient = new MsRDPClient80(); });
            TryVersion(MsRdpClientVersion.MsClient70, () => { internalMsClient = new MsRDPClient70(); });
            TryVersion(MsRdpClientVersion.MsClient61, () => { internalMsClient = new MsRDPClient61(); });
            TryVersion(MsRdpClientVersion.MsClient60, () => { internalMsClient = new MsRDPClient60(); });
            TryVersion(MsRdpClientVersion.MsClient50, () => { internalMsClient = new MsRDPClient50(); });

            if (lastDetectedVersion == MsRdpClientVersion.Unknown)
            {
                throw new NotSupportedException("MsRrdpClient could not be instanciated");
            }
        }

        private void TryVersion(MsRdpClientVersion clientVersion, MethodInvoker doApplyVersion)
        {
            try
            {
                if (lastDetectedVersion == MsRdpClientVersion.Unknown || lastDetectedVersion == clientVersion)
                {
                    doApplyVersion();
                    lastDetectedVersion = clientVersion;
                }
            }
            catch 
            {
                
                lastDetectedVersion = MsRdpClientVersion.Unknown;
            }
        }


        /// <summary>
        /// Apply the values of the current RDP Client internal RDP ActiveX component
        /// Override in derived classes to extend the settings that apply to a given version. Always call
        /// the ancestor version.
        /// </summary>
        protected virtual void ApplySettings()
        {
        }

        /// <summary>
        /// Apply the values of AdvancedSettings to the internal RDP ActiveX component
        /// Override in derived classes to extend the settings that apply to a given version. Always call
        /// the ancestor version.
        /// </summary>
        protected virtual void ApplyAdvancedSettings()
        {
        }

        /// <summary>
        /// Apply the values of SecuredSettings to the internal RDP ActiveX component
        /// Override in derived classes to extend the settings that apply to a given version. Always call
        /// the ancestor version.
        /// </summary>
        protected virtual void ApplySecuredSettings()
        {
        }

        /// <summary>
        /// Apply the values of TransportSettings to the internal RDP ActiveX component
        /// Override in derived classes to extend the settings that apply to a given version. Always call
        /// the ancestor version.
        /// </summary>
        protected virtual void ApplyTransportSettings()
        {
        }

        public AdvancedSettings AdvancedSettings
        {
            get { throw new NotImplementedException(); }
        }

        public SecuredSettings SecuredSettings
        {
            get { throw new NotImplementedException(); }
        }

        public TransportSettings TransportSettings
        {
            get { throw new NotImplementedException(); }
        }

        public string Server
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string UserName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Domain
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string DesktopWidth
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string DesktopHeight
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Connect()
        {
            ApplyAdvancedSettings();
            ApplySecuredSettings();
            ApplyTransportSettings();

            if (rdp8 != null) rdp8.Connect();
            else if (rdp7 != null) rdp7.Connect();
            else if (rdp6 != null) rdp6.Connect();
            else if (rdp5 != null) rdp5.Connect();
            else if (rdp4 != null) rdp4.Connect();
            else if (rdp3 != null) rdp3.Connect();
            else if (rdp2 != null) rdp2.Connect();
            else if (rdp != null)  rdp.Connect();
        }

        public void Disconnect()
        {
            if (rdp8 != null) rdp8.Disconnect();
            else if (rdp7 != null) rdp7.Disconnect();
            else if (rdp6 != null) rdp6.Disconnect();
            else if (rdp5 != null) rdp5.Disconnect();
            else if (rdp4 != null) rdp4.Disconnect();
            else if (rdp3 != null) rdp3.Disconnect();
            else if (rdp2 != null) rdp2.Disconnect();
            else if (rdp != null) rdp.Disconnect();
        }


        #region Event Handling

        void rdp_OnAuthenticationWarningDismissed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public event EventHandler OnConnected;

        public event EventHandler OnDisconnected;

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
