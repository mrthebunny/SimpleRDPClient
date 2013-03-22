using AwakeCoding.Common;
using AwakeCoding.Reflection;
using AxMSTSCLib;
using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IMsTscAxEvents_OnDisconnectedEventHandler = AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler;
using IMsTscAxEvents_OnFatalErrorEventHandler = AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEventHandler;
using IMsTscAxEvents_OnWarningEventHandler = AxMSTSCLib.IMsTscAxEvents_OnWarningEventHandler;

namespace AwakeCoding.MsRdpClient
{
    public class MsRdpClientAdapter : IRDPClient, IDisposable
    {

        // Last detected version of the ActiveX control
        private static RDPClientVersion lastDetectedVersion = RDPClientVersion.Unknown;

        private IMsRDPClient client;
        private InterfaceProxy<ISecuredSettings> securedSettingsProxy;
        private InterfaceProxy<IAdvancedSettings> advancedSettingsProxy;
        private InterfaceProxy<ITransportSettings> transportSettingsProxy;


        public MsRdpClientAdapter()
        {
            try
            {
                TryVersion(RDPClientVersion.MsRDPClient80, () => { client = new MsRDPClient80(); });
                TryVersion(RDPClientVersion.MsRDPClient70, () => { client = new MsRDPClient70(); });
                TryVersion(RDPClientVersion.MsRDPClient61, () => { client = new MsRDPClient61(); });
                TryVersion(RDPClientVersion.MsRDPClient60, () => { client = new MsRDPClient60(); });
                TryVersion(RDPClientVersion.MsRDPClient50, () => { client = new MsRDPClient50(); });

                if (lastDetectedVersion == RDPClientVersion.Unknown)
                {
                    throw new NotSupportedException("MsRrdpClient could not be instanciated");
                }

                System.Diagnostics.Debug.WriteLine("AxRDPClient version instanciated: " + lastDetectedVersion);

                ((AxHost)client).HandleCreated += MsRdpClientAdapter_HandleCreated;

                RegisterEvents();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        void MsRdpClientAdapter_HandleCreated(object sender, EventArgs e)
        {
            // Finish initialization - com object proxies

            IMsTscNonScriptable securedSettingsOcx = (IMsTscNonScriptable)client.GetOcx();
            securedSettingsProxy = new InterfaceProxy<ISecuredSettings>();
            securedSettingsProxy.TargetInstance = securedSettingsOcx;
            securedSettingsProxy.TargetType = typeof(IMsTscNonScriptable);
            SecuredSettings = securedSettingsProxy.GetStrongTypedProxy();

            TrySetAdvancedSettings(client.AdvancedSettings9, typeof(MSTSCLib.IMsRdpClientAdvancedSettings8));
            TrySetAdvancedSettings(client.AdvancedSettings8, typeof(MSTSCLib.IMsRdpClientAdvancedSettings7));
            TrySetAdvancedSettings(client.AdvancedSettings7, typeof(MSTSCLib.IMsRdpClientAdvancedSettings6));
            TrySetAdvancedSettings(client.AdvancedSettings6, typeof(MSTSCLib.IMsRdpClientAdvancedSettings5));
            TrySetAdvancedSettings(client.AdvancedSettings5, typeof(MSTSCLib.IMsRdpClientAdvancedSettings4));
            TrySetAdvancedSettings(client.AdvancedSettings3, typeof(MSTSCLib.IMsRdpClientAdvancedSettings2));
            TrySetAdvancedSettings(client.AdvancedSettings2, typeof(MSTSCLib.IMsRdpClientAdvancedSettings));
            TrySetAdvancedSettings(client.AdvancedSettings, typeof(MSTSCLib.IMsTscAdvancedSettings));

            securedSettingsProxy = new InterfaceProxy<ISecuredSettings>();
            securedSettingsProxy.TargetInstance = securedSettingsOcx;
            securedSettingsProxy.TargetType = typeof(IMsTscNonScriptable);
            SecuredSettings = securedSettingsProxy.GetStrongTypedProxy();

            transportSettingsProxy = new InterfaceProxy<ITransportSettings>();
            transportSettingsProxy.TargetInstance = client.TransportSettings2;
            transportSettingsProxy.TargetType = typeof(IMsRdpClientTransportSettings2);
            TransportSettings = transportSettingsProxy.GetStrongTypedProxy();

            AxHost host = (AxHost)client;

            host.Dock = DockStyle.Fill;
        }

        private void TrySetAdvancedSettings(object targetInstance, Type targetType)
        {
            if (AdvancedSettings == null && targetInstance != null)
            {
                advancedSettingsProxy = new InterfaceProxy<IAdvancedSettings>();
                advancedSettingsProxy.TargetInstance = targetInstance;
                advancedSettingsProxy.TargetType = targetType;
                AdvancedSettings = advancedSettingsProxy.GetStrongTypedProxy();
            }
        }

        public RDPClientVersion ClientVersion
        {
            get
            {
                return lastDetectedVersion;
            }
        }

        public void Attach(Control parent)
        {
            parent.Controls.Add((Control) client);
        }

        private void RegisterEvents()
        {
            if (client != null)
            {
                client.OnConnected += client_OnConnected;
                client.OnDisconnected += client_OnDisconnected;
                client.OnFatalError += client_OnFatalError;
                client.OnWarning += client_OnWarning;
            }
        }

        void client_OnConnected(object sender, EventArgs e)
        {
            if (Connected != null)
            {
                Connected(this, e);
            }
        }

        void client_OnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
        {
            if (WarningOccurred != null)
            {
                WarningOccurred(this, new WarningEventArgs(e.warningCode));
            }
        }

        void client_OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
        {
            if (FatalErrorOccurred != null)
            {
                FatalErrorOccurred(this, new FatalErrorEventArgs(e.errorCode));
            }
        }

        void client_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
        {
            if (Disconnected != null)
            {
                Disconnected(this, new DisconnectedEventArgs(e.discReason));
            }
        }

        private void UnregisterEvents()
        {
        }


        private void TryVersion(RDPClientVersion clientVersion, MethodInvoker doApplyVersion)
        {
            try
            {
                if (lastDetectedVersion == RDPClientVersion.Unknown || lastDetectedVersion == clientVersion)
                {
                    doApplyVersion();
                    lastDetectedVersion = clientVersion;
                }
            }
            catch
            {

                lastDetectedVersion = RDPClientVersion.Unknown;
            }
        }

        public static RDPClientVersion LastDetectedVersion
        {
            get
            {
                return lastDetectedVersion;
            }
        }

        public void Dispose()
        {
            UnregisterEvents();
        }

        public IAdvancedSettings AdvancedSettings
        {
            get;
            private set;
        }

        public ISecuredSettings SecuredSettings
        {
            get; 
            private set;
        }

        public ITransportSettings TransportSettings
        {
            get;
            private set;
        }

        public string Server
        {
            get
            {
                return client.Server;
            }
            set
            {
                client.Server = value;
            }
        }

        public string UserName
        {
            get
            {
                return client.UserName;
            }
            set
            {
                client.UserName = value;
            }
        }

        public string Domain
        {
            get
            {
                return client.Domain;
            }
            set
            {
                client.Domain = value;
            }
        }

        public int DesktopWidth
        {
            get
            {
                return client.DesktopWidth;
            }
            set
            {
                client.DesktopWidth = value;
            }
        }

        public int DesktopHeight
        {
            get
            {
                return client.DesktopHeight;
            }
            set
            {
                client.DesktopHeight = value;
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
            //IMsTscNonScriptable secured = (IMsTscNonScriptable) client.GetOcx();

            //secured.ClearTextPassword = SecuredSettings.ClearTextPassword;
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


        public void Connect()
        {
            ApplySettings();
            ApplyAdvancedSettings();
            ApplySecuredSettings();
            ApplyTransportSettings();

            client.Connect();
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;
    }
}
