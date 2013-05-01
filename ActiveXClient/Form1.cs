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

using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActiveXClient
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
		private int backgroundInput = 0;

		private AxHost rdpConnection;

		public Form1()
		{
			InitializeComponent();

			this.Load += Form1_HandleCreated;
		}

		void Form1_HandleCreated(object sender, EventArgs e)
		{
			TryCreateRDPControl();
			ReadSettings(
				Environment.GetEnvironmentVariable("HOMEDRIVE") +
				Path.Combine(
				Environment.GetEnvironmentVariable("HOMEPATH"),
				@"Dropbox\connect.txt"));

		}

		void Form1_Shown(object sender, EventArgs e)
		{
			//TryCreateRDPControl();
			//ReadSettings(
			//	Environment.GetEnvironmentVariable("HOMEDRIVE") +
			//	Path.Combine(
			//	Environment.GetEnvironmentVariable("HOMEPATH"),
			//	@"Dropbox\connect.txt"));

		}

		private void TryCreateRDPControl()
		{
			this.rdpConnection = null;
			try
			{
				this.rdpConnection = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
				//this.rdpConnection.CreateControl();

				((AxMSTSCLib.AxMsRdpClient8NotSafeForScripting)this.rdpConnection).OnConnected += new System.EventHandler(this.rdpConnection_OnConnected);
				((AxMSTSCLib.AxMsRdpClient8NotSafeForScripting)this.rdpConnection).OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.rdpConnection_OnDisconnected);
				InitRDPControl();
			
				txtStatus.Text = "Ms RDP Component version 8";
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				this.rdpConnection = null;
			}

			try
			{
				if (this.rdpConnection == null)
				{
					this.rdpConnection = new AxMSTSCLib.AxMsRdpClient7NotSafeForScripting();
					((AxMSTSCLib.AxMsRdpClient7NotSafeForScripting)this.rdpConnection).OnConnected += new System.EventHandler(this.rdpConnection_OnConnected);
					((AxMSTSCLib.AxMsRdpClient7NotSafeForScripting)this.rdpConnection).OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.rdpConnection_OnDisconnected);
					InitRDPControl();

					txtStatus.Text = "Ms RDP Component version 6";
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				this.rdpConnection = null;
			}

			try
			{
				if (this.rdpConnection == null)
				{
					this.rdpConnection = new AxMSTSCLib.AxMsRdpClient6NotSafeForScripting();
					((AxMSTSCLib.AxMsRdpClient6NotSafeForScripting)this.rdpConnection).OnConnected += new System.EventHandler(this.rdpConnection_OnConnected);
					((AxMSTSCLib.AxMsRdpClient6NotSafeForScripting)this.rdpConnection).OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.rdpConnection_OnDisconnected);
					InitRDPControl();
					txtStatus.Text = "Ms RDP Component version 6";
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				rdpConnection = null;
			}

			try
			{
				if (rdpConnection == null)
				{
					rdpConnection = new AxMSTSCLib.AxMsRdpClient5NotSafeForScripting();
					((AxMSTSCLib.AxMsRdpClient5NotSafeForScripting)this.rdpConnection).OnConnected += new System.EventHandler(this.rdpConnection_OnConnected);
					((AxMSTSCLib.AxMsRdpClient5NotSafeForScripting)this.rdpConnection).OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.rdpConnection_OnDisconnected);
					InitRDPControl();
					txtStatus.Text = "Ms RDP Component version 5";
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				rdpConnection = null;
			}


			if (rdpConnection == null)
			{
				txtStatus.Text = "ERROR instanciating Ms RDP Component version";
				this.tabControl1.Controls.Remove(tabPageActiveX);
				return;
			}
		}

		private void InitRDPControl()
		{
			try
			{
				this.rdpConnection.BeginInit();
				this.rdpConnection.Dock = System.Windows.Forms.DockStyle.Fill;
				this.rdpConnection.Enabled = true;
				this.rdpConnection.Location = new System.Drawing.Point(0, 0);
				this.rdpConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
				this.rdpConnection.Name = "rdpConnection";
				//this.rdpConnection.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdpConnection.OcxState")));
				this.rdpConnection.Size = new System.Drawing.Size(909, 529);
				this.rdpConnection.TabIndex = 0;
				this.rdpConnection.EndInit();

				this.toolStripContainer1.ContentPanel.Controls.Add(this.rdpConnection);
				this.rdpConnection.CreateControl();
			}
			catch
			{
				if (this.toolStripContainer1.ContentPanel.Controls.Contains(rdpConnection))
					this.toolStripContainer1.ContentPanel.Controls.Remove(rdpConnection);

				throw;
			}
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
				settings.TryGetValue("server", out server);
				settings.TryGetValue("username", out userName);
				settings.TryGetValue("password", out clearTextPassword);

				txtDomain.Text = domain;
				txtPassword.Text = clearTextPassword;
				txtPort.Text = "";
				txtServer.Text = server;
				txtUsername.Text = userName;
				cxSmartSize.Checked = smartSizing;
				cxBackgroundInput.Checked = backgroundInput == 0 ? false : true;
			}
		}

		private void toolStripButtonConnect_Click(object sender, EventArgs e)
		{
			//rdpConnection.DesktopWidth = rdpConnection.Width;
			//rdpConnection.DesktopHeight = rdpConnection.Height;

			((IMsRdpClient) rdpConnection.GetOcx()).Server = server;
			((IMsRdpClient) rdpConnection.GetOcx()).UserName = userName;
			((IMsRdpClient) rdpConnection.GetOcx()).Domain = domain;

			if (bpp > 0)
			{
				((IMsRdpClient) rdpConnection.GetOcx()).ColorDepth = bpp;
			}

			((IMsRdpClient) rdpConnection.GetOcx()).AdvancedSettings2.ClearTextPassword = clearTextPassword;
			((IMsRdpClient) rdpConnection.GetOcx()).AdvancedSettings2.SmartSizing = smartSizing;
			((IMsRdpClient) rdpConnection.GetOcx()).AdvancedSettings.allowBackgroundInput = backgroundInput;
			((IMsRdpClient) rdpConnection.GetOcx()).Connect();
		}


		private void DoConnect(AwakeCoding.FreeRDPClient.RDPClientFrame rdpClientFrame)
		{
			//rdpClientFrame.DesktopWidth = rdpClientFrame.Width;
			//rdpClientFrame.DesktopHeight = rdpClientFrame.Height;

			if (!String.IsNullOrEmpty(server))
				rdpClientFrame.Server = server;

			if (!String.IsNullOrEmpty(userName))
				rdpClientFrame.UserName = userName;

			if (!String.IsNullOrEmpty(domain))
				rdpClientFrame.Domain = domain;

			if (!String.IsNullOrEmpty(clearTextPassword))
				rdpClientFrame.AdvancedSettings.ClearTextPassword = clearTextPassword;

			rdpClientFrame.AdvancedSettings.SmartSizing = smartSizing;

			if (bpp > 0)
			{
				rdpClientFrame.ColorDepth = bpp;
			}

			rdpClientFrame.Connect();
		}

		private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
		{
			((IMsRdpClient) rdpConnection.GetOcx()).Disconnect();
		}

		private void toolStripButtonDisconnect2_Click(object sender, EventArgs e)
		{
			rdpClientFrame1.Disconnect();
		}

		private void toolStripButtonConnect2_Click(object sender, EventArgs e)
		{
			DoConnect(rdpClientFrame1);
		}

		private void rdpConnection_OnConnected(object sender, EventArgs e)
		{
			SetConnected(1, true);
		}

		private void rdpConnection_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
		{
			SetConnected(1, false);
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


		private void toolStripButtonConnect4_Click(object sender, EventArgs e)
		{
			DoConnect(rdpClientFrame3);
		}

		private void toolStripButtonDisconnect4_Click(object sender, EventArgs e)
		{
			rdpClientFrame3.Disconnect();
		}

		private void rdpClientFrame2_Connected(object sender, EventArgs e)
		{
			SetConnected(3, true);
		}

		private void rdpClientFrame2_Disconnected(object sender, AwakeCoding.Common.DisconnectedEventArgs e)
		{
			SetConnected(3, false);
		}

		private void rdpClientFrame3_Connected(object sender, EventArgs e)
		{
			SetConnected(4, true);
		}

		private void rdpClientFrame3_Disconnected(object sender, AwakeCoding.Common.DisconnectedEventArgs e)
		{
			SetConnected(4, false);
		}

		private void SetConnected(int tabIndex, bool connected)
		{
			switch (tabIndex)
			{
				case 1:
					toolStripButtonConnect.Enabled = !connected;
					toolStripButtonDisconnect.Enabled = connected;
					break;
				case 2:
					toolStripButtonConnect2.Enabled = !connected;
					toolStripButtonDisconnect2.Enabled = connected;
					break;
				case 3:
					toolStripButtonConnect3.Enabled = !connected;
					toolStripButtonDisconnect3.Enabled = connected;
					break;
				case 4:
					toolStripButtonConnect4.Enabled = !connected;
					toolStripButtonDisconnect4.Enabled = connected;
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

			if (((IMsRdpClient) rdpConnection.GetOcx()).Connected != 0)
			{
				try
				{
					((IMsRdpClient5)rdpConnection.GetOcx()).AdvancedSettings2.SmartSizing = smartSizing;
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.Message);
				}
			}

			if (rdpClientFrame1.IsConnected)
			{
				rdpClientFrame1.AdvancedSettings.SmartSizing = smartSizing;
				System.Diagnostics.Debug.WriteLine("test: SmartSizing=" + rdpClientFrame1.AdvancedSettings.SmartSizing);
			}

			if (rdpClientFrame2.IsConnected)
			{
				rdpClientFrame2.AdvancedSettings.SmartSizing = smartSizing;
				System.Diagnostics.Debug.WriteLine("test: SmartSizing=" + rdpClientFrame2.AdvancedSettings.SmartSizing);
			}

			if (rdpClientFrame3.IsConnected)
			{
				rdpClientFrame3.AdvancedSettings.SmartSizing = smartSizing;
				System.Diagnostics.Debug.WriteLine("test: SmartSizing=" + rdpClientFrame3.AdvancedSettings.SmartSizing);
			}
		}

		private void cxBackgroundInput_CheckedChanged(object sender, EventArgs e)
		{
			backgroundInput = cxBackgroundInput.Checked ? 1 : 0;

			//if (rdpConnection.Connected != 0)
			//{
			//	rdpConnection.AdvancedSettings.allowBackgroundInput = backgroundInput;
			//}

			//if (rdpClientFrame1.IsConnected)
			//{
			//	rdpClientFrame1.AdvancedSettings.allowBackgroundInput = backgroundInput;
			//}

			//if (rdpClientFrame2.IsConnected)
			//{
			//	rdpClientFrame2.AdvancedSettings.allowBackgroundInput = backgroundInput;
			//}

			//if (rdpClientFrame3.IsConnected)
			//{
			//	rdpClientFrame3.AdvancedSettings.allowBackgroundInput = backgroundInput;
			//}
		}


		private void btForceSize_Click(object sender, EventArgs e)
		{
			rdpClientFrame2.ForceSize(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
		}

		private void toolStripButtonOpenRDP_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Remote Desktop Connection files (*.RDP)|*.rdp|All files (*.*)|*.*";
			if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				rdpClientFrame2.LoadSettings(dlg.FileName);

				txtDomain.Text = rdpClientFrame2.Domain;
				txtPassword.Text = rdpClientFrame2.AdvancedSettings.ClearTextPassword;
				txtPort.Text = rdpClientFrame2.AdvancedSettings.RDPPort.ToString();
				txtServer.Text = rdpClientFrame2.Server;
				txtUsername.Text = rdpClientFrame2.UserName;
				cxSmartSize.Checked = rdpClientFrame2.AdvancedSettings.SmartSizing;
			}
		}

		private void toolStripButtonSaveRDP_Click(object sender, EventArgs e)
		{
			rdpClientFrame2.Domain = txtDomain.Text;
			rdpClientFrame2.AdvancedSettings.ClearTextPassword = txtPassword.Text;
			try
			{
				rdpClientFrame2.AdvancedSettings.RDPPort = Convert.ToInt32(txtPort.Text);
			}
			catch { }

			rdpClientFrame2.Server = txtServer.Text;
			rdpClientFrame2.UserName = txtUsername.Text;

			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "Remote Desktop Connection files (*.RDP)|*.rdp|All files (*.*)|*.*";
			if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				rdpClientFrame2.SaveSettings(dlg.FileName);
			}
		}
	}
}