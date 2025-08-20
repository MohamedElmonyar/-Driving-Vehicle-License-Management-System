namespace DVLD
{
    partial class frmShowInternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicenseInfo));
            this.laStauts = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrnInternationalLicenseInfo1 = new DVLD.ctrnInternationalLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.BackColor = System.Drawing.Color.Transparent;
            this.laStauts.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.laStauts.ForeColor = System.Drawing.Color.Snow;
            this.laStauts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laStauts.Location = new System.Drawing.Point(470, 41);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(369, 46);
            this.laStauts.TabIndex = 132;
            this.laStauts.Text = "International License";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 133;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(488, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 135;
            // 
            // ctrnInternationalLicenseInfo1
            // 
            this.ctrnInternationalLicenseInfo1.InternationalLicense_ID = 0;
            this.ctrnInternationalLicenseInfo1.Location = new System.Drawing.Point(8, 143);
            this.ctrnInternationalLicenseInfo1.Name = "ctrnInternationalLicenseInfo1";
            this.ctrnInternationalLicenseInfo1.Person_ID = 0;
            this.ctrnInternationalLicenseInfo1.Size = new System.Drawing.Size(1193, 284);
            this.ctrnInternationalLicenseInfo1.TabIndex = 134;
            // 
            // frmShowInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1209, 445);
            this.Controls.Add(this.ctrnInternationalLicenseInfo1);
            this.Controls.Add(this.laStauts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInternationalLicenseInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show International License";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laStauts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ctrnInternationalLicenseInfo ctrnInternationalLicenseInfo1;
        private System.Windows.Forms.Panel panel1;
    }
}