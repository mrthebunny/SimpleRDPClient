using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ActiveXClient
{
    public partial class Form1 : Form
    {
        private bool connected;

        public bool Connected
        {
            get
            {
                return connected;
            }
            set
            {
                connected = value;
                toolStripButtonConnect2.Enabled = !connected;
                toolStripButtonDisconnect2.Enabled = connected;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Connected = false;

        }


        private void toolStripButtonDisconnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.Disconnect();
        }

        private void toolStripButtonConnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.Server = "192.168.3.62";
            rdpClientFrame1.UserName = "Administrator";
            rdpClientFrame1.Domain = "Awake";

            rdpClientFrame1.DesktopWidth = rdpClientFrame1.Width;
            rdpClientFrame1.DesktopHeight = rdpClientFrame1.Height;

            rdpClientFrame1.SecuredSettings.ClearTextPassword = "@wake01DC";

            rdpClientFrame1.Connect();
        }

        private void rdpConnection_OnConnected(object sender, EventArgs e)
        {
            Connected = true;
        }

        private void rdpClientFrame_Connected(object sender, EventArgs e)
        {
            Connected = true;
        }

        private void rdpClientFrame_Disconnected(object sender, AwakeCoding.Common.DisconnectedEventArgs e)
        {
            Connected = false;
        }
    }
}
