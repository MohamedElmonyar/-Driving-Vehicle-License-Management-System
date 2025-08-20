namespace DVLD
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.panel2 = new System.Windows.Forms.Panel();
            this.laStauts = new System.Windows.Forms.Label();
            this.ctrnFindLicense1 = new DVLD.ctrnFindLicense();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkShowLicense = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.laAppDate = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.r = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laOldLicenseID = new System.Windows.Forms.Label();
            this.laDetainedDate = new System.Windows.Forms.Label();
            this.laDetainID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(331, 867);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 54);
            this.panel2.TabIndex = 213;
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.BackColor = System.Drawing.Color.Transparent;
            this.laStauts.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.laStauts.ForeColor = System.Drawing.Color.Snow;
            this.laStauts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laStauts.Location = new System.Drawing.Point(544, 41);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(262, 46);
            this.laStauts.TabIndex = 211;
            this.laStauts.Text = "Detain License";
            // 
            // ctrnFindLicense1
            // 
            this.ctrnFindLicense1.BackColor = System.Drawing.Color.Transparent;
            this.ctrnFindLicense1.License_ID = 0;
            this.ctrnFindLicense1.LocalApplication_ID = 0;
            this.ctrnFindLicense1.Location = new System.Drawing.Point(8, 122);
            this.ctrnFindLicense1.Name = "ctrnFindLicense1";
            this.ctrnFindLicense1.Size = new System.Drawing.Size(1221, 471);
            this.ctrnFindLicense1.TabIndex = 198;
            this.ctrnFindLicense1.OnLicenseSelected += new System.Action<bool>(this.ctrnFindLicense1_OnLicenseSelected);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssue.BackgroundImage")));
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Location = new System.Drawing.Point(588, 837);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(74, 57);
            this.btnIssue.TabIndex = 209;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(426, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 35);
            this.label2.TabIndex = 207;
            this.label2.Text = "Application Basic Info";
            // 
            // lnkShowLicense
            // 
            this.lnkShowLicense.AutoSize = true;
            this.lnkShowLicense.BackColor = System.Drawing.Color.Transparent;
            this.lnkShowLicense.Enabled = false;
            this.lnkShowLicense.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lnkShowLicense.LinkColor = System.Drawing.Color.Snow;
            this.lnkShowLicense.Location = new System.Drawing.Point(933, 850);
            this.lnkShowLicense.Name = "lnkShowLicense";
            this.lnkShowLicense.Size = new System.Drawing.Size(284, 32);
            this.lnkShowLicense.TabIndex = 206;
            this.lnkShowLicense.TabStop = true;
            this.lnkShowLicense.Text = "Show New License Info";
            this.lnkShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicense_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(484, 850);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 208;
            this.label6.Text = "Detain :";
            // 
            // lnkShowLicenseHistory
            // 
            this.lnkShowLicenseHistory.AutoSize = true;
            this.lnkShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnkShowLicenseHistory.Enabled = false;
            this.lnkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lnkShowLicenseHistory.LinkColor = System.Drawing.Color.Snow;
            this.lnkShowLicenseHistory.Location = new System.Drawing.Point(17, 850);
            this.lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            this.lnkShowLicenseHistory.Size = new System.Drawing.Size(264, 32);
            this.lnkShowLicenseHistory.TabIndex = 205;
            this.lnkShowLicenseHistory.TabStop = true;
            this.lnkShowLicenseHistory.Text = "Show License History";
            this.lnkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseHistory_LinkClicked);
            // 
            // laAppDate
            // 
            this.laAppDate.AutoSize = true;
            this.laAppDate.BackColor = System.Drawing.Color.White;
            this.laAppDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laAppDate.ForeColor = System.Drawing.Color.Black;
            this.laAppDate.Location = new System.Drawing.Point(976, 69);
            this.laAppDate.Name = "laAppDate";
            this.laAppDate.Size = new System.Drawing.Size(65, 31);
            this.laAppDate.TabIndex = 204;
            this.laAppDate.Text = "[???]";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(926, 62);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 203;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(709, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 31);
            this.label5.TabIndex = 202;
            this.label5.Text = "Application Date :";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.BackColor = System.Drawing.Color.White;
            this.laUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laUserName.ForeColor = System.Drawing.Color.Black;
            this.laUserName.Location = new System.Drawing.Point(991, 643);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(65, 31);
            this.laUserName.TabIndex = 201;
            this.laUserName.Text = "[???]";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(942, 636);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 200;
            this.pictureBox6.TabStop = false;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.White;
            this.a.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.a.ForeColor = System.Drawing.Color.Black;
            this.a.Location = new System.Drawing.Point(792, 646);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(151, 31);
            this.a.TabIndex = 199;
            this.a.Text = "Created By :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbFineFees);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.r);
            this.panel1.Controls.Add(this.i);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.laOldLicenseID);
            this.panel1.Controls.Add(this.laDetainedDate);
            this.panel1.Controls.Add(this.laDetainID);
            this.panel1.Controls.Add(this.laAppDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 192);
            this.panel1.TabIndex = 210;
            // 
            // tbFineFees
            // 
            this.tbFineFees.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.tbFineFees.Location = new System.Drawing.Point(249, 117);
            this.tbFineFees.Multiline = true;
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(273, 61);
            this.tbFineFees.TabIndex = 207;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(202, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 206;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 205;
            this.label3.Text = "Fine Fees :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(202, 55);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 44);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 178;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(202, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 174;
            this.pictureBox5.TabStop = false;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.BackColor = System.Drawing.Color.White;
            this.r.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.r.ForeColor = System.Drawing.Color.Black;
            this.r.Location = new System.Drawing.Point(40, 65);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(163, 31);
            this.r.TabIndex = 140;
            this.r.Text = "Detain Date :";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.BackColor = System.Drawing.Color.White;
            this.i.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.i.ForeColor = System.Drawing.Color.Black;
            this.i.Location = new System.Drawing.Point(67, 10);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(136, 31);
            this.i.TabIndex = 144;
            this.i.Text = "Detain ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(785, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 148;
            this.label1.Text = "License ID :";
            // 
            // laOldLicenseID
            // 
            this.laOldLicenseID.AutoSize = true;
            this.laOldLicenseID.BackColor = System.Drawing.Color.White;
            this.laOldLicenseID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.laOldLicenseID.Location = new System.Drawing.Point(978, 125);
            this.laOldLicenseID.Name = "laOldLicenseID";
            this.laOldLicenseID.Size = new System.Drawing.Size(61, 31);
            this.laOldLicenseID.TabIndex = 176;
            this.laOldLicenseID.Text = "N/A";
            // 
            // laDetainedDate
            // 
            this.laDetainedDate.AutoSize = true;
            this.laDetainedDate.BackColor = System.Drawing.Color.White;
            this.laDetainedDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laDetainedDate.ForeColor = System.Drawing.Color.Black;
            this.laDetainedDate.Location = new System.Drawing.Point(247, 64);
            this.laDetainedDate.Name = "laDetainedDate";
            this.laDetainedDate.Size = new System.Drawing.Size(65, 31);
            this.laDetainedDate.TabIndex = 181;
            this.laDetainedDate.Text = "[???]";
            // 
            // laDetainID
            // 
            this.laDetainID.AutoSize = true;
            this.laDetainID.BackColor = System.Drawing.Color.White;
            this.laDetainID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laDetainID.ForeColor = System.Drawing.Color.Black;
            this.laDetainID.Location = new System.Drawing.Point(248, 10);
            this.laDetainID.Name = "laDetainID";
            this.laDetainID.Size = new System.Drawing.Size(65, 31);
            this.laDetainID.TabIndex = 141;
            this.laDetainID.Text = "[???]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(929, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 177;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 212;
            this.pictureBox2.TabStop = false;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1235, 914);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.laStauts);
            this.Controls.Add(this.ctrnFindLicense1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkShowLicense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnkShowLicenseHistory);
            this.Controls.Add(this.laUserName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label laStauts;
        private ctrnFindLicense ctrnFindLicense1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkShowLicense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkShowLicenseHistory;
        private System.Windows.Forms.Label laAppDate;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laOldLicenseID;
        private System.Windows.Forms.Label laDetainedDate;
        private System.Windows.Forms.Label laDetainID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}