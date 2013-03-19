namespace AwakeCoding.MsRdpClient
{
    using AwakeCoding.Common;
    using AxMSTSCLib;
    using MSTSCLib;

    public class MsRDPClient60 : AxMsRdpClient5, IMsRDPClient
    {
        public RDPClientVersion ClientVersion
        {
            get
            {
                return RDPClientVersion.MsRDPClient60;
            }
        }

        public IMsRdpClientAdvancedSettings6 AdvancedSettings7
        {
            get
            {
                return null;
            }
        }

        public IMsRdpClientAdvancedSettings7 AdvancedSettings8
        {
            get
            {
                return null;
            }
        }

        public MSTSCLib.IMsRdpClientAdvancedSettings8 AdvancedSettings9
        {
            get
            {
                return null;
            }
        }

        public IMsRdpClientTransportSettings2 TransportSettings2
        {
            get
            {
                return null;
            }
        }
    }
}