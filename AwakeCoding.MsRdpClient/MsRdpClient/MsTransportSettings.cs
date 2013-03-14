using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AwakeCoding.Common;
using MSTSCLib;

namespace AwakeCoding.MsRdpClient
{
    public class MsTransportSettings : ITransportSettings
    {
        private IMsRdpClientTransportSettings2 transport;

        public MsTransportSettings(IMsRDPClient client)
        {
            transport = client.TransportSettings2;
        }

        public uint GatewayCredsSource
        {
            get
            {
                return transport.GatewayCredsSource;
            }
            set
            {
                transport.GatewayCredsSource = value;
            }
        }

        public uint GatewayProfileUsageMethod
        {
            get
            {
                return transport.GatewayProfileUsageMethod;
            }
            set
            {
                transport.GatewayProfileUsageMethod = value;
            }
        }

        public string GatewayHostname
        {
            get
            {
                return transport.GatewayHostname;
            }
            set
            {
                transport.GatewayHostname = value;
            }
        }

        public string GatewayUsername
        {
            get
            {
                return transport.GatewayUsername;
            }
            set
            {
                transport.GatewayUsername = value;
            }
        }

        public string GatewayDomain
        {
            get
            {
                return transport.GatewayDomain;
            }
            set
            {
                transport.GatewayDomain = value;
            }
        }

        public string GatewayPassword
        {
            set 
            {
                transport.GatewayPassword = value;
            }
        }

        public uint GatewayUsageMethod
        {
            get
            {
                return transport.GatewayUsageMethod;
            }
            set
            {
                transport.GatewayUsageMethod = value;
            }
        }

        public uint GatewayCredSharing
        {
            get
            {
                return transport.GatewayCredSharing;
            }
            set
            {
                transport.GatewayCredSharing = value;
            }
        }


        public uint GatewayDefaultUsageMethod
        {
            get { throw new NotImplementedException(); }
        }

        public string GatewayEncryptedOtpCookie
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

        public uint GatewayEncryptedOtpCookieSize
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

        public int GatewayIsSupported
        {
            get { throw new NotImplementedException(); }
        }

        public uint GatewayPreAuthRequirement
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

        public string GatewayPreAuthServerAddr
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

        public string GatewaySupportUrl
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

        public uint GatewayUserSelectedCredsSource
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
    }
}
