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
            this.rdpClientFrame1 = new AwakeCoding.FreeRDPClient.RDPClientFrame();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect2 = new System.Windows.Forms.ToolStripButton();
            this.tabPageFreeRDP = new System.Windows.Forms.TabPage();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect3 = new System.Windows.Forms.ToolStripButton();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageActiveX);
            this.tabControl1.Controls.Add(this.tabPageActiveXWrapper);
            this.tabControl1.Controls.Add(this.tabPageFreeRDP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 582);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageActiveX
            // 
            this.tabPageActiveX.Controls.Add(this.toolStripContainer1);
            this.tabPageActiveX.Location = new System.Drawing.Point(4, 22);
            this.tabPageActiveX.Name = "tabPageActiveX";
            this.tabPageActiveX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActiveX.Size = new System.Drawing.Size(788, 556);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(782, 525);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(782, 550);
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
            this.rdpConnection.Size = new System.Drawing.Size(782, 525);
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
            this.tabPageActiveXWrapper.Size = new System.Drawing.Size(788, 556);
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
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(757, 525);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(782, 550);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // rdpClientFrame1
            // 
            this.rdpClientFrame1.ClientVersion = AwakeCoding.Common.RDPClientVersion.MsRDPClient;
            this.rdpClientFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpClientFrame1.Location = new System.Drawing.Point(0, 0);
            this.rdpClientFrame1.Name = "rdpClientFrame1";
            this.rdpClientFrame1.Size = new System.Drawing.Size(757, 525);
            this.rdpClientFrame1.TabIndex = 0;
            this.rdpClientFrame1.Connected += new System.EventHandler(this.rdpClientFrame_Connected);
            this.rdpClientFrame1.Disconnected += new AwakeCoding.Common.DisconnectedEventHandler(this.rdpClientFrame_Disconnected);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect2,
            this.toolStripButtonDisconnect2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(170, 25);
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
            // tabPageFreeRDP
            // 
            this.tabPageFreeRDP.Controls.Add(this.toolStripContainer3);
            this.tabPageFreeRDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageFreeRDP.Name = "tabPageFreeRDP";
            this.tabPageFreeRDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFreeRDP.Size = new System.Drawing.Size(788, 556);
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
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(782, 525);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(782, 550);
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
            this.toolStripButtonDisconnect3});
            this.toolStrip3.Location = new System.Drawing.Point(3, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(170, 25);
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
            // rdpClientFrame2
            // 
            this.rdpClientFrame2.ClientVersion = AwakeCoding.Common.RDPClientVersion.FreeRDP;
            this.rdpClientFrame2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpClientFrame2.Location = new System.Drawing.Point(0, 0);
            this.rdpClientFrame2.Name = "rdpClientFrame2";
            this.rdpClientFrame2.Size = new System.Drawing.Size(782, 525);
            this.rdpClientFrame2.TabIndex = 1;
            this.rdpClientFrame2.Connected += new System.EventHandler(this.rdpClientFrame2_Connected);
            this.rdpClientFrame2.Disconnected += new AwakeCoding.Common.DisconnectedEventHandler(this.rdpClientFrame2_Disconnected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 582);
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

    }
}

