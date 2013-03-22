using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwakeCoding.Common;

namespace AwakeCoding.FreeRDPClient
{
    public class SecuredSettingsStub : ISecuredSettings
    {
        public string ClearTextPassword
        {
            get;
            set;
        }

        public string BinaryPassword
        {
            get;
            set;
        }

        public string BinarySalt
        {
            get;
            set;
        }

        public string PortablePassword
        {
            get;
            set;
        }

        public string PortableSalt
        {
            get;
            set;
        }
    }
}
