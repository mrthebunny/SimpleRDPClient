using AwakeCoding.Common;
using AwakeCoding.FreeRDPClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    class MsRDPLoader
    {
        public enum RDPClientType
        {
            Stub,
            Microsoft,
            FreeRDP
        }

        public static IRDPClient NewRDPClient(RDPClientType clientType)
        {
            bool designMode = (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime);
            if (designMode)
            {
                clientType = RDPClientType.Stub;
            }

            switch (clientType)
            {
                case RDPClientType.Stub:
                    return new RDPClientStub();
                case RDPClientType.Microsoft:
                    string libPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AwakeCoding.MsRdpClient.dll");
                    Assembly msRdpClientAssembly = Assembly.LoadFrom(libPath);
                    return msRdpClientAssembly.CreateInstance("AwakeCoding.MsRdpClient.MsRdpClientAdapter") as IRDPClient;
                   
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
