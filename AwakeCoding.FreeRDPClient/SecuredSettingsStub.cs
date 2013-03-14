using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwakeCoding.Common;

namespace AwakeCoding.FreeRDPClient
{
    class SecuredSettingsStub : ISecuredSettings
    {
        public void SetClearTextPassword(string value)
        {
            
        }

        public string ClearTextPassword
        {
            set
            {
            }
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
