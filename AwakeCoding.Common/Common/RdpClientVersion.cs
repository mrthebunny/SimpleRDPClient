using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.Common
{
    public enum RDPClientVersion
    {
        Unknown = 0
        ,Stub
        ,FreeRDP
#if !__MONO
        ,MsRDPClient
        ,MsRDPClient80
        ,MsRDPClient70
        ,MsRDPClient60
        ,MsRDPClient61
        ,MsRDPClient50
#endif
    };
}
