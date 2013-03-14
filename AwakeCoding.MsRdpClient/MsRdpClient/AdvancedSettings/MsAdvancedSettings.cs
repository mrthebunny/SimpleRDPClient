using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AwakeCoding.Common;
using MSTSCLib;

namespace AwakeCoding.MsRdpClient
{
    /// <summary>
    /// Contains the advanced configuration settings for a given RDP component
    /// </summary>
    public partial class MsAdvancedSettings : IAdvancedSettings, IMsTscAdvancedSettings
    {
        private IMsRDPClient client;

        private IMsTscAdvancedSettings advancedSettings
        {
            get
            {
                if (client.AdvancedSettings == null)
                {
                    throw new NotSupportedException();
                }

                return client.AdvancedSettings;
            }
        }

        public MsAdvancedSettings(IMsRDPClient client)
        {
            this.client = client;
        }

        

    }
}
