namespace AwakeCoding.MsRdpClient
{
	using AwakeCoding.Common;
	using AxMSTSCLib;

	public class MsRDPClient80 : AxMsRdpClient8NotSafeForScripting, IMsRDPClient
	{
		public RDPClientVersion ClientVersion
		{
			get
			{
				return RDPClientVersion.MsRDPClient80;
			}
		}
	}
}