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

            IRDPClient client;

            switch (clientType)
            {
                case RDPClientType.Stub:
                    client = new RDPClientStub();
                    break;

                case RDPClientType.Microsoft:
                    string libPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AwakeCoding.MsRdpClient.dll");
                    Assembly msRdpClientAssembly = Assembly.LoadFrom(libPath);
                    client = msRdpClientAssembly.CreateInstance("AwakeCoding.MsRdpClient.MsRdpClientAdapter") as IRDPClient;
                    break;

                case RDPClientType.FreeRDP:
                    client = new RDPClientStub();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return client;
        }
    }
}
