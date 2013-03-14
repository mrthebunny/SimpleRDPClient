using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings2 
    {
        private IMsRdpClientAdvancedSettings2 advancedSettings3
        {
            get
            {
                if (client.AdvancedSettings3 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings3;
            }
        }
    }

}
