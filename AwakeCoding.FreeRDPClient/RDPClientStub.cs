using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding.FreeRDPClient
{
    class RDPClientStub : IRDPClient
    {
        private bool isConnected = false;


        private Panel panel = new Panel();
        private TextBox textBox = new TextBox();

        public RDPClientStub()
        {
            AdvancedSettings = new Common.AdvancedSettings();
            SecuredSettings = new Common.SecuredSettings();
            TransportSettings = new Common.TransportSettings();

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

        public AdvancedSettings AdvancedSettings
        {
            get;
            set;
        }

        public SecuredSettings SecuredSettings
        {
            get;
            set;
        }
        public TransportSettings TransportSettings
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

        public Control GetControl()
        {
            return panel;
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
    
    }
}
