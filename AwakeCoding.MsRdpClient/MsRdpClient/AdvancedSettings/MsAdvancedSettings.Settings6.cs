using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings5
    {
        private IMsRdpClientAdvancedSettings5 advancedSettings6
        {
            get
            {
                if (client.AdvancedSettings6 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings6;
            }
        }
    }

}
