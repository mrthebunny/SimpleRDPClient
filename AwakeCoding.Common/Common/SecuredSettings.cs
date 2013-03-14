using System;

namespace AwakeCoding.Common
{
    /// <summary>
    /// Contains the security-related settings for the RDP client
    /// </summary>
    public interface ISecuredSettings
    {
        string ClearTextPassword { set; }

        string BinaryPassword { get; set; }

        string BinarySalt { get; set; }

        string PortablePassword { get; set; }

        string PortableSalt { get; set; }
    }
}
