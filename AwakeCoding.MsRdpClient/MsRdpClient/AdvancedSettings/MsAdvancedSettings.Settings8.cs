using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings7
    {

        private IMsRdpClientAdvancedSettings7 advancedSettings8
        {
            get
            {
                if (client.AdvancedSettings8 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings8;
            }
        }

    }

}
