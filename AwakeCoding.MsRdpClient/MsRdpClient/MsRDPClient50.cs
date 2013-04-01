namespace AwakeCoding.MsRdpClient
{
	using AwakeCoding.Common;
	using AxMSTSCLib;
	using MSTSCLib;

	public class MsRDPClient50 : AxMsRdpClient4, IMsRDPClient
	{
		public RDPClientVersion ClientVersion
		{
			get
			{
				return RDPClientVersion.MsRDPClient50;
			}
		}

		public IMsRdpClientAdvancedSettings5 AdvancedSettings6
		{
			get
			{
				return null;
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

		public string GetErrorDescription(uint discReason, uint extendedDisconnectReason)
		{
			return string.Empty;
		}
	}
}