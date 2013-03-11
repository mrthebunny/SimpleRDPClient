using System;


namespace AwakeCoding.Common
{

    /// <summary>
    /// Common interface used to control a RDP Client component.
    /// </summary>
    public interface IRdpClient
    {
        #region Settings
        AdvancedSettings AdvancedSettings { get; }
        SecuredSettings SecuredSettings { get; }
        TransportSettings TransportSettings { get; }

        string Server { get; set; }
        string UserName { get; set; }
        string Domain { get; set; }

        int DesktopWidth { get; set; }
        int DesktopHeight { get; set; }
        #endregion // Settings

        #region Methods
        void Connect();
        void Disconnect();
        #endregion // Methods

        #region Events

        event EventHandler Connected;
        event EventHandler Disconnected;
        event FatalErrorEventHandler FatalErrorOccurred;
        event WarningEventHandler WarningOccurred;
        
        #endregion // Events
    }
}
