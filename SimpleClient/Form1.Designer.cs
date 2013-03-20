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
            this.tabPageActiveXWrapper = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.rdpClientFrame1 = new AwakeCoding.MsRdpClient.RDPClientFrame();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect2 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageActiveXWrapper.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageActiveXWrapper
            // 
            this.tabPageActiveXWrapper.Controls.Add(this.toolStripContainer2);
            this.tabPageActiveXWrapper.Location = new System.Drawing.Point(4, 22);
            this.tabPageActiveXWrapper.Name = "tabPageActiveXWrapper";
            this.tabPageActiveXWrapper.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(782, 525);
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
            this.rdpClientFrame1.ClientVersion = AwakeCoding.Common.RDPClientVersion.FreeRDP;
            this.rdpClientFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpClientFrame1.Location = new System.Drawing.Point(0, 0);
            this.rdpClientFrame1.Name = "rdpClientFrame1";
            this.rdpClientFrame1.Size = new System.Drawing.Size(782, 525);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageActiveXWrapper);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 582);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RDP Control Test";
            this.tabPageActiveXWrapper.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageActiveXWrapper;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private AwakeCoding.MsRdpClient.RDPClientFrame rdpClientFrame1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect2;
        private System.Windows.Forms.TabControl tabControl1;


    }
}

