namespace DVLD
{
    partial class frmShowLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLicenseHistory));
            this.laStauts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrnLocalLicenses1 = new DVLD.ctrnLocalLicenses();
            this.ctrnFindPerson1 = new DVLD.ctrnFindPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.BackColor = System.Drawing.Color.Transparent;
            this.laStauts.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.laStauts.ForeColor = System.Drawing.Color.White;
            this.laStauts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laStauts.Location = new System.Drawing.Point(450, 64);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(339, 56);
            this.laStauts.TabIndex = 39;
            this.laStauts.Text = "License History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(444, 999);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 22);
            this.panel1.TabIndex = 42;
            // 
            // ctrnLocalLicenses1
            // 
            this.ctrnLocalLicenses1.Location = new System.Drawing.Point(6, 613);
            this.ctrnLocalLicenses1.Name = "ctrnLocalLicenses1";
            this.ctrnLocalLicenses1.Person_ID = 0;
            this.ctrnLocalLicenses1.Size = new System.Drawing.Size(1123, 387);
            this.ctrnLocalLicenses1.TabIndex = 41;
            // 
            // ctrnFindPerson1
            // 
            this.ctrnFindPerson1.BackColor = System.Drawing.Color.Transparent;
            this.ctrnFindPerson1.Location = new System.Drawing.Point(-5, 189);
            this.ctrnFindPerson1.Name = "ctrnFindPerson1";
            this.ctrnFindPerson1.NationalNo = null;
            this.ctrnFindPerson1.Person_ID = 0;
            this.ctrnFindPerson1.Size = new System.Drawing.Size(1145, 422);
            this.ctrnFindPerson1.TabIndex = 0;
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1135, 1018);
            this.Controls.Add(this.ctrnLocalLicenses1);
            this.Controls.Add(this.laStauts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrnFindPerson1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLicenseHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show License History";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrnFindPerson ctrnFindPerson1;
        private System.Windows.Forms.Label laStauts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrnLocalLicenses ctrnLocalLicenses1;
        private System.Windows.Forms.Panel panel1;
    }
}