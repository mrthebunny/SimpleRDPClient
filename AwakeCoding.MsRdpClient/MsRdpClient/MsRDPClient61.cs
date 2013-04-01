namespace AwakeCoding.MsRdpClient
{
	using AwakeCoding.Common;
	using AxMSTSCLib;
	using MSTSCLib;

	public class MsRDPClient61 : AxMsRdpClient6, IMsRDPClient
	{
		public RDPClientVersion ClientVersion
		{
			get
			{
				return RDPClientVersion.MsRDPClient61;
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
	}
}