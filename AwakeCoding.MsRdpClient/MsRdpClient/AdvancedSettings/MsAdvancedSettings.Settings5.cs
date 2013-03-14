using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings4
    {
        private IMsRdpClientAdvancedSettings4 advancedSettings5
        {
            get
            {
                if (client.AdvancedSettings5 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings5;
            }
        }
        
    }

}
