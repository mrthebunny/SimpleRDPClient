using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwakeCoding.Common;
using MSTSCLib;

namespace AwakeCoding.MsRdpClient
{
    class MsSecuredSettings : ISecuredSettings
    {
        private IMsTscNonScriptable secure;

        public MsSecuredSettings(IMsRDPClient client)
        {
            this.secure = (IMsTscNonScriptable) client.GetOcx();
        }

        public string ClearTextPassword
        {
            set
            {
                secure.ClearTextPassword = value;
            }
        }

        public string BinaryPassword
        {
            get
            {
                return secure.BinaryPassword;
            }
            set
            {
                secure.BinaryPassword = value;
            }
        }

        public string BinarySalt
        {
            get
            {
                return secure.BinarySalt;
            }
            set
            {
                secure.BinarySalt = value;
            }
        }

        public string PortablePassword
        {
            get
            {
                return secure.PortablePassword;
            }
            set
            {
                secure.PortablePassword = value;
            }
        }

        public string PortableSalt
        {
            get
            {
                return secure.PortableSalt;
            }
            set
            {
                secure.PortableSalt = value;
            }
        }
    }
}
