using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings7
    {
        private IMsRdpClientAdvancedSettings6 advancedSettings7
        {
            get
            {
                if (client.AdvancedSettings7 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings7;
            }
        }

    }

}
