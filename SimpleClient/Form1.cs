using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AwakeCoding
{
    public partial class Form1 : Form
    {
        private bool connected;

        private string server;
        private string userName;
        private string domain;
        private string clearTextPassword;      

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

            ReadSettings(
                Environment.GetEnvironmentVariable("HOMEDRIVE") +
                Path.Combine(
                Environment.GetEnvironmentVariable("HOMEPATH"), 
                @"Dropbox\connect.txt"));

        }

        private void ReadSettings(string path)
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] tokens = line.Split(new char[] { '=' }, 2);
                    if (tokens.Length == 2)
                    {
                        settings[tokens[0].Trim().ToLower()] = tokens[1].Trim();
                    }
                    line = reader.ReadLine();
                }
            }

            server = settings["server"];
            userName = settings["username"];
            domain = settings["domain"];
            clearTextPassword = settings["password"];
        }

        private void toolStripButtonDisconnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.Disconnect();
        }

        private void toolStripButtonConnect2_Click(object sender, EventArgs e)
        {
            rdpClientFrame1.DesktopWidth = rdpClientFrame1.Width;
            rdpClientFrame1.DesktopHeight = rdpClientFrame1.Height;

            rdpClientFrame1.Server = server;
            rdpClientFrame1.UserName = userName;
            rdpClientFrame1.Domain = domain;
            rdpClientFrame1.SecuredSettings.ClearTextPassword = clearTextPassword;
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
