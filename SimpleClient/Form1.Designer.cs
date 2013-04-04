namespace AwakeCoding
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
			this.tabPageFreeRDP = new System.Windows.Forms.TabPage();
			this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
			this.rdpClientFrame2 = new AwakeCoding.FreeRDPClient.RDPClientFrame();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonConnect3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDisconnect3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btForceSize = new System.Windows.Forms.Button();
			this.txtHeight = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtWidth = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cxSmartSize = new System.Windows.Forms.CheckBox();
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
			this.tabControl1.SuspendLayout();
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
			this.tabControl1.Controls.Add(this.tabPageFreeRDP);
			this.tabControl1.Location = new System.Drawing.Point(0, 136);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(694, 482);
			this.tabControl1.TabIndex = 1;
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
			// rdpClientFrame2
			// 
			this.rdpClientFrame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rdpClientFrame2.ClientVersion = AwakeCoding.Common.RDPClientVersion.FreeRDP;
			this.rdpClientFrame2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rdpClientFrame2.Location = new System.Drawing.Point(0, 0);
			this.rdpClientFrame2.Name = "rdpClientFrame2";
			this.rdpClientFrame2.Size = new System.Drawing.Size(680, 425);
			this.rdpClientFrame2.TabIndex = 1;
			this.rdpClientFrame2.Connected += new System.EventHandler(this.rdpClientFrame2_Connected);
			this.rdpClientFrame2.Disconnected += new AwakeCoding.Common.DisconnectedEventHandler(this.rdpClientFrame2_Disconnected);
			// 
			// toolStrip3
			// 
			this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect3,
            this.toolStripButtonDisconnect3,
            this.toolStripSeparator2});
			this.toolStrip3.Location = new System.Drawing.Point(3, 0);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(176, 25);
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btForceSize);
			this.groupBox1.Controls.Add(this.txtHeight);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtWidth);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cxSmartSize);
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
			this.groupBox1.Size = new System.Drawing.Size(680, 117);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// btForceSize
			// 
			this.btForceSize.Location = new System.Drawing.Point(520, 83);
			this.btForceSize.Name = "btForceSize";
			this.btForceSize.Size = new System.Drawing.Size(63, 21);
			this.btForceSize.TabIndex = 17;
			this.btForceSize.Text = "Force";
			this.btForceSize.UseVisualStyleBackColor = true;
			this.btForceSize.Click += new System.EventHandler(this.btForceSize_Click);
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(471, 83);
			this.txtHeight.Mask = "00000";
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(43, 20);
			this.txtHeight.TabIndex = 16;
			this.txtHeight.Text = "200";
			this.txtHeight.ValidatingType = typeof(int);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(456, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "h";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(407, 83);
			this.txtWidth.Mask = "00000";
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(43, 20);
			this.txtWidth.TabIndex = 14;
			this.txtWidth.Text = "200";
			this.txtWidth.ValidatingType = typeof(int);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(392, 86);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "w";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cxSmartSize
			// 
			this.cxSmartSize.AutoSize = true;
			this.cxSmartSize.Location = new System.Drawing.Point(462, 54);
			this.cxSmartSize.Name = "cxSmartSize";
			this.cxSmartSize.Size = new System.Drawing.Size(82, 17);
			this.cxSmartSize.TabIndex = 12;
			this.cxSmartSize.Text = "Smart sizing";
			this.cxSmartSize.UseVisualStyleBackColor = true;
			this.cxSmartSize.CheckedChanged += new System.EventHandler(this.cxSmartSize_CheckedChanged);
			// 
			// cbColorDepth
			// 
			this.cbColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbColorDepth.FormattingEnabled = true;
			this.cbColorDepth.Items.AddRange(new object[] {
            "0",
            "32",
            "16"});
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
        private System.Windows.Forms.TabPage tabPageFreeRDP;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect3;
		private AwakeCoding.FreeRDPClient.RDPClientFrame rdpClientFrame2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
        private System.Windows.Forms.CheckBox cxSmartSize;
        private System.Windows.Forms.Button btForceSize;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.Label label7;

    }
}

