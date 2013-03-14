using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.Common
{
    public interface ITransportSettings
    {
        uint GatewayCredsSource { get; set; }
        uint GatewayProfileUsageMethod { get; set; }
        string GatewayHostname { get; set; }
        string GatewayUsername { get; set; }
        string GatewayDomain { get; set; }
        string GatewayPassword { set; }
        uint GatewayUsageMethod { get; set; }
        uint GatewayCredSharing { get; set; }

        uint GatewayDefaultUsageMethod { get; }
        string GatewayEncryptedOtpCookie { get; set; }
        uint GatewayEncryptedOtpCookieSize { get; set; }
        int GatewayIsSupported { get; }
        uint GatewayPreAuthRequirement { get; set; }
        string GatewayPreAuthServerAddr { get; set; }
        string GatewaySupportUrl { get; set; }
        uint GatewayUserSelectedCredsSource { get; set; }
    
    }
}
