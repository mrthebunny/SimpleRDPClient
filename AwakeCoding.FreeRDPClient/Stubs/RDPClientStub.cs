using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
    public class RDPClientStub : IRDPClient
    {
        private bool isConnected = false;


        private Panel panel = new Panel();
        private TextBox textBox = new TextBox();

        public RDPClientStub()
        {
            AdvancedSettings = new AdvancedSettingsStub();
            TransportSettings = new TransportSettingsStub();
            SecuredSettings = new SecuredSettingsStub();

            textBox.Dock = DockStyle.Fill;
            textBox.ReadOnly = true;
            textBox.Multiline = true;
            textBox.BackColor = System.Drawing.Color.White;
            panel.Controls.Add(textBox);

            panel.HandleCreated += panel_HandleCreated;
        }

        void panel_HandleCreated(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        public RDPClientVersion ClientVersion 
        {
            get
            {
                return RDPClientVersion.Stub;
            }
        }

        public IAdvancedSettings AdvancedSettings
        {
            get;
            set;
        }

        public ITransportSettings TransportSettings
        {
            get;
            set;
        }

        public ISecuredSettings SecuredSettings
        {
            get;
            set;
        }

        public string Server
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }
        public string Domain
        {
            get;
            set;
        }

        public int DesktopWidth
        {
            get;
            set;
        }

        public int DesktopHeight
        {
            get;
            set;
        }

        public int ColorDepth
        {
            get;
            set;
        }

        public void Connect()
        {
            isConnected = true;
            UpdateDisplay();

            if (Connected != null)
            {
                Connected(this, EventArgs.Empty);
            }
        }

        public void Disconnect()
        {
            isConnected = false;
            UpdateDisplay();

            if (Disconnected != null)
            {
                Disconnected(this, new DisconnectedEventArgs(0));
            }
        }

        public void Attach(Control parent)
        {
            parent.Controls.Add(panel);
        }

        public event EventHandler Connected;

        public event DisconnectedEventHandler Disconnected;

        public event FatalErrorEventHandler FatalErrorOccurred;

        public event WarningEventHandler WarningOccurred;


        private void UpdateDisplay()
        {
            textBox.Text = String.Format(
                "Dummy remote control" + Environment.NewLine +
                "Connection: {0}" + Environment.NewLine +
                "DesktopWidth: {1}" + Environment.NewLine +
                "DesktopHeight: {2}",

                isConnected ? Server + " as " + UserName : "(disconnected)",
                DesktopWidth,
                DesktopHeight);       
        }



        public bool ContainsFocus
        {
            get;
            set;
        }

        public string ConnectedStatusText
        {
            get;
            set;
        }

        public string ConnectingText
        {
            get;
            set;
        }

        public string DisconnectedText
        {
             get;
             set;
        }

        public bool FullScreen
        {
            get;
            set;
        }

        public string FullScreenTitle
        {
            get;
            set;
        }

        public bool HorizontalScrollBarVisible
        {
            get;
            set;        
        }

        public bool IsConnected
        {
            get;
            set;       
        }

        public bool VerticalScrollBarVisible
        {
            get;
            set;
        }


        public string GetErrorDescription(uint discReason, uint extendedDisconnectReason)
        {
            return "";
        }
    }
}
