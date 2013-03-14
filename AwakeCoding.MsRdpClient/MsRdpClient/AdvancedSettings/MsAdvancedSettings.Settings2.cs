using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.MsRdpClient
{
    partial class MsAdvancedSettings : IMsRdpClientAdvancedSettings
    {
        private IMsRdpClientAdvancedSettings advancedSettings2
        {
            get
            {
                if (client.AdvancedSettings2 == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings2;
            }
        }
    }
}
