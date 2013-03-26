using System;
using System.Windows.Forms;

namespace AwakeCoding.Common
{

    /// <summary>
    /// Common interface used to control a RDP Client component.
    /// </summary>
    public interface IRDPClient
    {
        RDPClientVersion ClientVersion { get; }

        #region Settings
        IAdvancedSettings AdvancedSettings { get; }
        ISecuredSettings SecuredSettings { get; }
        ITransportSettings TransportSettings { get; }

        int ColorDepth { get; set; }
        bool ContainsFocus { get; }
        string ConnectedStatusText { get; set; }
        string ConnectingText { get; set; }
        int DesktopHeight { get; set; }
        int DesktopWidth { get; set; }
        string DisconnectedText { get; set; }
        string Domain { get; set; }
        bool FullScreen { get; set; }
        string FullScreenTitle { set; }
        bool HorizontalScrollBarVisible { get; }
        bool IsConnected { get; }
        string Server { get; set; }
        string UserName { get; set; }
        bool VerticalScrollBarVisible { get; } 
        
        #endregion // Settings

        #region Methods
        void Connect();
        void Disconnect();
        void Attach(Control parent);
        string GetErrorDescription(uint discReason, uint extendedDisconnectReason);
        #endregion // Methods

        #region Events

        event EventHandler Connected;
        event DisconnectedEventHandler Disconnected;
        event FatalErrorEventHandler FatalErrorOccurred;
        event WarningEventHandler WarningOccurred;
        
        #endregion // Events

        
    }
}
