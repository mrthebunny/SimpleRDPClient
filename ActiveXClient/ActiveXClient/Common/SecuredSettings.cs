using System;

namespace AwakeCoding.Common
{
    /// <summary>
    /// Contains the security-related settings for the RDP client
    /// </summary>
    public class SecuredSettings
    {
        public string ClearTextPassword { get; set; }

        public string BinaryPassword { get; set; }

        public string BinarySalt { get; set; }

        public string PortablePassword { get; set; }

        public string PortableSalt { get; set; }
    }
}
