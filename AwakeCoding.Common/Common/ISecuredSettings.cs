using System;

namespace AwakeCoding.Common
{
    /// <summary>
    /// Contains the security-related settings for the RDP client
    /// </summary>
    public interface ISecuredSettings
    {
        int AudioRedirectionMode { get; set; }
        int FullScreen { get; set; }
        int KeyboardHookMode { get; set; }
        string StartProgram { get; set; }
        string WorkDir { get; set; }
    }
}
