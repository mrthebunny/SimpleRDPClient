namespace AwakeCoding.MsRdpClient
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
            this.axMsRdpClient8NotSafeForScripting1 = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient8NotSafeForScripting1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsRdpClient8NotSafeForScripting1
            // 
            this.axMsRdpClient8NotSafeForScripting1.Enabled = true;
            this.axMsRdpClient8NotSafeForScripting1.Location = new System.Drawing.Point(86, 58);
            this.axMsRdpClient8NotSafeForScripting1.Name = "axMsRdpClient8NotSafeForScripting1";
            this.axMsRdpClient8NotSafeForScripting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient8NotSafeForScripting1.OcxState")));
            this.axMsRdpClient8NotSafeForScripting1.Size = new System.Drawing.Size(192, 192);
            this.axMsRdpClient8NotSafeForScripting1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.axMsRdpClient8NotSafeForScripting1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient8NotSafeForScripting1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting axMsRdpClient8NotSafeForScripting1;
    }
}