namespace AwakeCoding.MsRdpClient
{
	using AwakeCoding.Common;
	using AxMSTSCLib;
	using MSTSCLib;

	public class MsRDPClient70 : AxMsRdpClient7NotSafeForScripting, IMsRDPClient
	{
		public RDPClientVersion ClientVersion
		{
			get
			{
				return RDPClientVersion.MsRDPClient70;
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