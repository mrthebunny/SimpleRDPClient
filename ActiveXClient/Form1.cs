using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                toolStripButtonRemoteProgram.Enabled = connected;
                toolStripButtonConnect.Enabled = !connected;
                toolStripButtonConnect2.Enabled = !connected;
                toolStripButtonDisconnect.Enabled = connected;
                toolStripButtonDisconnect2.Enabled = connected;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Connected = false;

        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {

            rdpConnection.DesktopWidth = rdpConnection.Width;
            rdpConnection.DesktopHeight = rdpConnection.Height;

            rdpConnection.Server = "192.168.3.62";
            rdpConnection.UserName = "Administrator";
            rdpConnection.Domain = "Awake";

            IMsTscNonScriptable secured = (IMsTscNonScriptable) rdpConnection.GetOcx();
            secured.ClearTextPassword = "@wake01DC";

            rdpConnection.Connect();
        }

        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            rdpConnection.Disconnect();
        }

        private void toolStripButtonDisconnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.Disconnect();
        }

        private void toolStripButtonConnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.DesktopWidth = rdpClientFrame1.Width;
            rdpClientFrame1.DesktopHeight = rdpClientFrame1.Height;

            rdpClientFrame1.Server = "192.168.3.62";
            rdpClientFrame1.UserName = "Administrator";
            rdpClientFrame1.Domain = "Awake";
            rdpClientFrame1.SecuredSettings.ClearTextPassword = "@wake01DC";

            rdpClientFrame1.Connect();
        }

        private void toolStripButtonRemoteProgram_Click(object sender, EventArgs e)
        {
            try
            {
                rdpConnection.RemoteProgram.RemoteProgramMode = true;
                rdpConnection.RemoteProgram.ServerStartProgram(@"c:\windows\system32\cmd.exe", @"c:\windows\system32\", "", false, "", false);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

        }

        private void rdpConnection_OnConnected(object sender, EventArgs e)
        {
            Connected = true;
        }

        private void rdpConnection_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            Connected = false;
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
