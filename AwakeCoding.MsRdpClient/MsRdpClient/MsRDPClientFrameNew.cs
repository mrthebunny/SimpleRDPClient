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
using MSTSCLib;


namespace AwakeCoding.MsRdpClient
{
    public partial class MSRDPClientFrameNew : UserControl, IRDPClient
    {

        #region Private members

        // Last detected version of the ActiveX control
        private static MsRdpClientVersion lastDetectedVersion = MsRdpClientVersion.Unknown;

        // Current instanciated version of IRdpClient
        private IMsRDPClient internalMsClient = null;

        #endregion // Private members

        #region Events

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;

        #endregion Events

        public MSRDPClientFrameNew()
        {
            AdvancedSettings = new Common.AdvancedSettings();
            SecuredSettings = new Common.SecuredSettings();
            TransportSettings = new Common.TransportSettings();

            InitializeComponent();
            InitializeRdpComponent();
            RegisterEvents();
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

            System.Diagnostics.Debug.WriteLine("AxRDPClient version instanciated: " + lastDetectedVersion);

            AxHost component = (AxHost) internalMsClient;
            component.Dock = DockStyle.Fill;
            Controls.Add(component);
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
            IMsTscNonScriptable secured = (IMsTscNonScriptable)internalMsClient.GetOcx();

            secured.ClearTextPassword = SecuredSettings.ClearTextPassword;
            //secured.BinaryPassword = SecuredSettings.BinaryPassword;
            //secured.BinarySalt = SecuredSettings.BinarySalt;
            //secured.PortablePassword = SecuredSettings.PortablePassword;
            //secured.PortableSalt = SecuredSettings.PortableSalt;
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
                return internalMsClient.Server;
            }
            set
            {
                internalMsClient.Server = value;
            }
        }

        public string UserName
        {
            get
            {
                return internalMsClient.UserName;
            }
            set
            {
                internalMsClient.UserName = value;
            }
        }

        public string Domain
        {
            get
            {
                return internalMsClient.Domain;
            }
            set
            {
                internalMsClient.Domain = value;
            }
        }

        public int DesktopWidth
        {
            get
            {
                return internalMsClient.DesktopWidth;
            }
            set
            {
                internalMsClient.DesktopWidth = value;
            }
        }

        public int DesktopHeight
        {
            get
            {
                return internalMsClient.DesktopHeight;
            }
            set
            {
                internalMsClient.DesktopHeight = value;
            }
        }

        public void Connect()
        {
            ApplySettings();
            ApplyAdvancedSettings();
            ApplySecuredSettings();
            ApplyTransportSettings();

            internalMsClient.Connect();
        }

        public void Disconnect()
        {
            internalMsClient.Disconnect();
        }


        #region Event Handling

        private void RegisterEvents()
        {
            internalMsClient.OnConnected += internalMsClient_OnConnected;
            internalMsClient.OnDisconnected += internalMsClient_OnDisconnected;
            internalMsClient.OnFatalError += internalMsClient_OnFatalError;
            internalMsClient.OnWarning += internalMsClient_OnWarning;
        }

        void internalMsClient_OnConnected(object sender, EventArgs e)
        {
            if (Connected != null)
            {
                Connected(this, e);
            }
        }

        void internalMsClient_OnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
        {
            if (WarningOccurred != null)
            {
                WarningOccurred(this, new WarningEventArgs(e.warningCode));
            }
        }

        void internalMsClient_OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
        {
            if (FatalErrorOccurred != null)
            {
                FatalErrorOccurred(this, new FatalErrorEventArgs(e.errorCode));
            }
        }

        void internalMsClient_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
        {
            if (Disconnected != null)
            {
                Disconnected(this, new DisconnectedEventArgs(e.discReason));
            }
        }

        #endregion // Event Handling

    }

    //public enum MsRdpClientVersion
    //{
    //    Unknown,
    //    MsClient50,
    //    MsClient60,
    //    MsClient61,
    //    MsClient70,
    //    MsClient80
    //}

}
