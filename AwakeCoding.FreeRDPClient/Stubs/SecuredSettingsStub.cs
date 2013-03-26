using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding.FreeRDPClient
{
    public class SecuredSettingsStub : ISecuredSettings
    {
        public int AudioRedirectionMode
        {
            get; 
            set;
        }

        public int FullScreen
        {
            get;
            set;
        }

        public int KeyboardHookMode
        {
            get;
            set;
        }

        public string StartProgram
        {
            get;
            set;
        }

        public string WorkDir
        {
            get;
            set;
        }
    }
}
