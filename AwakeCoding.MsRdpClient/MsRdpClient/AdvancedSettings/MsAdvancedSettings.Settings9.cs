using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings8
    {

        private IMsRdpClientAdvancedSettings8 advancedSettings9
        {
            get
            {
                if (client.AdvancedSettings9 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings9;
            }
        }
    }
}
