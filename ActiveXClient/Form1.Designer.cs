namespace ActiveXClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageActiveX = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rdpConnection = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoteProgram = new System.Windows.Forms.ToolStripButton();
            this.tabPageActiveXWrapper = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSmartSize1 = new System.Windows.Forms.ToolStripButton();
            this.tabPageFreeRDP = new System.Windows.Forms.TabPage();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSmartSize2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbColorDepth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdpClientFrame1 = new AwakeCoding.FreeRDPClient.RDPClientFrame();
            this.rdpClientFrame2 = new AwakeCoding.FreeRDPClient.RDPClientFrame();
            this.tabControl1.SuspendLayout();
            this.tabPageActiveX.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpConnection)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPageActiveXWrapper.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPageFreeRDP.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageActiveX);
            this.tabControl1.Controls.Add(this.tabPageActiveXWrapper);
            this.tabControl1.Controls.Add(this.tabPageFreeRDP);
            this.tabControl1.Location = new System.Drawing.Point(0, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 482);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageActiveX
            // 
            this.tabPageActiveX.Controls.Add(this.toolStripContainer1);
            this.tabPageActiveX.Location = new System.Drawing.Point(4, 22);
            this.tabPageActiveX.Name = "tabPageActiveX";
            this.tabPageActiveX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActiveX.Size = new System.Drawing.Size(686, 456);
            this.tabPageActiveX.TabIndex = 0;
            this.tabPageActiveX.Text = "ActiveX";
            this.tabPageActiveX.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rdpConnection);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(680, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(680, 450);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // rdpConnection
            // 
            this.rdpConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpConnection.Enabled = true;
            this.rdpConnection.Location = new System.Drawing.Point(0, 0);
            this.rdpConnection.Name = "rdpConnection";
            this.rdpConnection.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdpConnection.OcxState")));
            this.rdpConnection.Size = new System.Drawing.Size(680, 425);
            this.rdpConnection.TabIndex = 0;
            this.rdpConnection.OnConnected += new System.EventHandler(this.rdpConnection_OnConnected);
            this.rdpConnection.OnDisconnected += new AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEventHandler(this.rdpConnection_OnDisconnected);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect,
            this.toolStripButtonDisconnect,
            this.toolStripButtonRemoteProgram});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(287, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripButtonDisconnect
            // 
            this.toolStripButtonDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisconnect.Image")));
            this.toolStripButtonDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect.Name = "toolStripButtonDisconnect";
            this.toolStripButtonDisconnect.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonDisconnect.Text = "Disconnect";
            this.toolStripButtonDisconnect.Click += new System.EventHandler(this.toolStripButtonDisconnect_Click);
            // 
            // toolStripButtonRemoteProgram
            // 
            this.toolStripButtonRemoteProgram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoteProgram.Image")));
            this.toolStripButtonRemoteProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoteProgram.Name = "toolStripButtonRemoteProgram";
            this.toolStripButtonRemoteProgram.Size = new System.Drawing.Size(117, 22);
            this.toolStripButtonRemoteProgram.Text = "Remote Program";
            this.toolStripButtonRemoteProgram.Click += new System.EventHandler(this.toolStripButtonRemoteProgram_Click);
            // 
            // tabPageActiveXWrapper
            // 
            this.tabPageActiveXWrapper.Controls.Add(this.toolStripContainer2);
            this.tabPageActiveXWrapper.Location = new System.Drawing.Point(4, 22);
            this.tabPageActiveXWrapper.Name = "tabPageActiveXWrapper";
            this.tabPageActiveXWrapper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActiveXWrapper.Size = new System.Drawing.Size(686, 456);
            this.tabPageActiveXWrapper.TabIndex = 1;
            this.tabPageActiveXWrapper.Text = "ActiveX (wrapper)";
            this.tabPageActiveXWrapper.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.rdpClientFrame1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(680, 425);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(680, 450);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect2,
            this.toolStripButtonDisconnect2,
            this.toolStripSeparator1,
            this.toolStripButtonSmartSize1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(257, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // toolStripButtonConnect2
            // 
            this.toolStripButtonConnect2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect2.Image")));
            this.toolStripButtonConnect2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect2.Name = "toolStripButtonConnect2";
            this.toolStripButtonConnect2.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonConnect2.Text = "Connect";
            this.toolStripButtonConnect2.Click += new System.EventHandler(this.toolStripButtonConnect2_Click);
            // 
            // toolStripButtonDisconnect2
            // 
            this.toolStripButtonDisconnect2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisconnect2.Image")));
            this.toolStripButtonDisconnect2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect2.Name = "toolStripButtonDisconnect2";
            this.toolStripButtonDisconnect2.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonDisconnect2.Text = "Disconnect";
            this.toolStripButtonDisconnect2.Click += new System.EventHandler(this.toolStripButtonDisconnect2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSmartSize1
            // 
            this.toolStripButtonSmartSize1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSmartSize1.Image")));
            this.toolStripButtonSmartSize1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSmartSize1.Name = "toolStripButtonSmartSize1";
            this.toolStripButtonSmartSize1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButtonSmartSize1.Text = "Smart Size";
            this.toolStripButtonSmartSize1.Click += new System.EventHandler(this.toolStripButtonSmartSize1_Click);
            // 
            // tabPageFreeRDP
            // 
            this.tabPageFreeRDP.Controls.Add(this.toolStripContainer3);
            this.tabPageFreeRDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageFreeRDP.Name = "tabPageFreeRDP";
            this.tabPageFreeRDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFreeRDP.Size = new System.Drawing.Size(686, 456);
            this.tabPageFreeRDP.TabIndex = 2;
            this.tabPageFreeRDP.Text = "FreeRDP";
            this.tabPageFreeRDP.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.BackColor = System.Drawing.Color.Maroon;
            this.toolStripContainer3.ContentPanel.Controls.Add(this.rdpClientFrame2);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(680, 425);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(680, 450);
            this.toolStripContainer3.TabIndex = 1;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.toolStrip3);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect3,
            this.toolStripButtonDisconnect3,
            this.toolStripSeparator2,
            this.toolStripButtonSmartSize2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(257, 25);
            this.toolStrip3.TabIndex = 2;
            // 
            // toolStripButtonConnect3
            // 
            this.toolStripButtonConnect3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect3.Image")));
            this.toolStripButtonConnect3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect3.Name = "toolStripButtonConnect3";
            this.toolStripButtonConnect3.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonConnect3.Text = "Connect";
            this.toolStripButtonConnect3.Click += new System.EventHandler(this.toolStripButtonConnect3_Click);
            // 
            // toolStripButtonDisconnect3
            // 
            this.toolStripButtonDisconnect3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisconnect3.Image")));
            this.toolStripButtonDisconnect3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect3.Name = "toolStripButtonDisconnect3";
            this.toolStripButtonDisconnect3.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonDisconnect3.Text = "Disconnect";
            this.toolStripButtonDisconnect3.Click += new System.EventHandler(this.toolStripButtonDisconnect3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSmartSize2
            // 
            this.toolStripButtonSmartSize2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSmartSize2.Image")));
            this.toolStripButtonSmartSize2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSmartSize2.Name = "toolStripButtonSmartSize2";
            this.toolStripButtonSmartSize2.Size = new System.Drawing.Size(81, 22);
            this.toolStripButtonSmartSize2.Text = "Smart Size";
            this.toolStripButtonSmartSize2.Click += new System.EventHandler(this.toolStripButtonSmartSize2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbColorDepth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbColorDepth
            // 
            this.cbColorDepth.FormattingEnabled = true;
            this.cbColorDepth.Items.AddRange(new object[] {
            "32",
            "24",
            "16",
            "15",
            "8",
            "1"});
            this.cbColorDepth.Location = new System.Drawing.Point(462, 27);
            this.cbColorDepth.Name = "cbColorDepth";
            this.cbColorDepth.Size = new System.Drawing.Size(121, 21);
            this.cbColorDepth.TabIndex = 10;
            this.cbColorDepth.Validated += new System.EventHandler(this.cbColorDepth_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Color depth";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 52);
            this.txtPort.Mask = "00000";
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(55, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.ValidatingType = typeof(int);
            this.txtPort.Validated += new System.EventHandler(this.txtPort_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(70, 26);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Validated += new System.EventHandler(this.txtServer_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(259, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(259, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(259, 52);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(100, 20);
            this.txtDomain.TabIndex = 3;
            this.txtDomain.Validated += new System.EventHandler(this.txtDomain_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // rdpClientFrame1
            // 
            this.rdpClientFrame1.BackColor = System.Drawing.Color.Maroon;
            this.rdpClientFrame1.ClientVersion = AwakeCoding.Common.RDPClientVersion.MsRDPClient;
            this.rdpClientFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpClientFrame1.Location = new System.Drawing.Point(0, 0);
            this.rdpClientFrame1.Name = "rdpClientFrame1";
            this.rdpClientFrame1.Size = new System.Drawing.Size(680, 425);
            this.rdpClientFrame1.TabIndex = 0;
            this.rdpClientFrame1.Connected += new System.EventHandler(this.rdpClientFrame_Connected);
            this.rdpClientFrame1.Disconnected += new AwakeCoding.Common.DisconnectedEventHandler(this.rdpClientFrame_Disconnected);
            // 
            // rdpClientFrame2
            // 
            this.rdpClientFrame2.ClientVersion = AwakeCoding.Common.RDPClientVersion.FreeRDP;
            this.rdpClientFrame2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpClientFrame2.Location = new System.Drawing.Point(0, 0);
            this.rdpClientFrame2.Name = "rdpClientFrame2";
            this.rdpClientFrame2.Size = new System.Drawing.Size(680, 425);
            this.rdpClientFrame2.TabIndex = 1;
            this.rdpClientFrame2.Connected += new System.EventHandler(this.rdpClientFrame2_Connected);
            this.rdpClientFrame2.Disconnected += new AwakeCoding.Common.DisconnectedEventHandler(this.rdpClientFrame2_Disconnected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RDP Control Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPageActiveX.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpConnection)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageActiveXWrapper.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPageFreeRDP.ResumeLayout(false);
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageActiveX;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting rdpConnection;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect;
        private System.Windows.Forms.TabPage tabPageActiveXWrapper;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoteProgram;
        private AwakeCoding.FreeRDPClient.RDPClientFrame rdpClientFrame1;
        private System.Windows.Forms.TabPage tabPageFreeRDP;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect3;
        private AwakeCoding.FreeRDPClient.RDPClientFrame rdpClientFrame2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSmartSize1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSmartSize2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbColorDepth;
        private System.Windows.Forms.Label label6;

    }
}

