/**
 * FreeRDP: A Remote Desktop Protocol Implementation
 *
 * Copyright 2013 Benoit LeBlanc <benoit.leblanc@awakecoding.com>
 * Copyright 2013 Awake Coding Consulting Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwakeCoding
{
	public partial class Form1 : Form
	{
		private string server;
		private string userName;
		private string domain;
		private string clearTextPassword;
		private int port = 0;
		private int bpp = 0;
		private bool smartSizing = false;

		public Form1()
		{
			InitializeComponent();

			ReadSettings(
			    Environment.GetEnvironmentVariable("HOMEDRIVE") +
			    Path.Combine(
			    Environment.GetEnvironmentVariable("HOMEPATH"),
			    @"Dropbox\connect.txt"));

		}

		private void ReadSettings(string path)
		{
			if (File.Exists(path))
			{
				Dictionary<string, string> settings = new Dictionary<string, string>();
				using (StreamReader reader = new StreamReader(path))
				{
					string line = reader.ReadLine();
					while (line != null)
					{
						if (!line.StartsWith("#")) // commented lines start with #. Ignore.
						{
							string[] tokens = line.Split(new char[] { '=' }, 2);
							if (tokens.Length == 2)
							{
								settings[tokens[0].Trim().ToLower()] = tokens[1].Trim();
							}
						}
						line = reader.ReadLine();
					}
				}

				settings.TryGetValue("domain", out domain);
				settings.TryGetValue("domain", out domain);
				settings.TryGetValue("domain", out domain);
				server = settings["server"];
				userName = settings["username"];
				clearTextPassword = settings["password"];
				settings.TryGetValue("domain", out domain);


				txtDomain.Text = domain;
				txtPassword.Text = clearTextPassword;
				txtPort.Text = "";
				txtServer.Text = server;
				txtUsername.Text = userName;
				cxSmartSize.Checked = smartSizing;
			}
		}


		private void DoConnect(AwakeCoding.FreeRDPClient.RDPClientFrame rdpClientFrame)
		{
			rdpClientFrame.DesktopWidth = rdpClientFrame.Width;
			rdpClientFrame.DesktopHeight = rdpClientFrame.Height;

			rdpClientFrame.Server = server;
			rdpClientFrame.UserName = userName;
			rdpClientFrame.Domain = domain;
			rdpClientFrame.AdvancedSettings.ClearTextPassword = clearTextPassword;
			rdpClientFrame.AdvancedSettings.SmartSizing = smartSizing;

			if (bpp > 0)
			{
				rdpClientFrame.ColorDepth = bpp;
			}

			rdpClientFrame.Connect();
		}

		private void rdpConnection_OnConnected(object sender, EventArgs e)
		{
			SetConnected(1, true);
		}

		private void rdpClientFrame_Connected(object sender, EventArgs e)
		{
			SetConnected(2, true);
		}

		private void rdpClientFrame_Disconnected(object sender, AwakeCoding.Common.DisconnectedEventArgs e)
		{
			SetConnected(2, false);
		}

		private void toolStripButtonConnect3_Click(object sender, EventArgs e)
		{
			DoConnect(rdpClientFrame2);
		}

		private void toolStripButtonDisconnect3_Click(object sender, EventArgs e)
		{
			rdpClientFrame2.Disconnect();
		}

		private void rdpClientFrame2_Connected(object sender, EventArgs e)
		{
			SetConnected(3, true);
		}

		private void rdpClientFrame2_Disconnected(object sender, AwakeCoding.Common.DisconnectedEventArgs e)
		{
			SetConnected(3, false);
		}

		private void SetConnected(int tabIndex, bool connected)
		{
			switch (tabIndex)
			{
				case 3:
					toolStripButtonConnect3.Enabled = !connected;
					toolStripButtonDisconnect3.Enabled = connected;
					break;
			}
		}

		private void txtUsername_Validated(object sender, EventArgs e)
		{
			userName = txtUsername.Text;
		}

		private void txtDomain_Validated(object sender, EventArgs e)
		{
			domain = txtDomain.Text;
		}

		private void txtPassword_Validated(object sender, EventArgs e)
		{
			clearTextPassword = txtPassword.Text;
		}

		private void txtServer_Validated(object sender, EventArgs e)
		{
			server = txtServer.Text;
		}

		private void txtPort_Validated(object sender, EventArgs e)
		{
			try
			{
				port = Convert.ToInt32(txtPort.Text);
			}
			catch
			{
				port = 0;
			}
		}

		private void cbColorDepth_Validated(object sender, EventArgs e)
		{
			bpp = Convert.ToInt32(cbColorDepth.SelectedItem);
		}

		private void cxSmartSize_CheckedChanged(object sender, EventArgs e)
		{
			smartSizing = cxSmartSize.Checked;

			if (rdpClientFrame2.IsConnected)
			{
				rdpClientFrame2.AdvancedSettings.SmartSizing = smartSizing;
			}
		}

		private void btForceSize_Click(object sender, EventArgs e)
		{
			rdpClientFrame2.ForceSize(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
		}
	}
}