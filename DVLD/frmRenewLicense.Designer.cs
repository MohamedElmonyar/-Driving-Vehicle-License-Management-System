namespace DVLD
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            this.ctrnFindLicense1 = new DVLD.ctrnFindLicense();
            this.laExDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laIssueDate = new System.Windows.Forms.Label();
            this.laOldLicenseID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.laAppID = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkShowLicense = new System.Windows.Forms.LinkLabel();
            this.lnkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.laAppDate = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.laFees = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.laReLicenseID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.u = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laStauts = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrnFindLicense1
            // 
            this.ctrnFindLicense1.BackColor = System.Drawing.Color.Transparent;
            this.ctrnFindLicense1.License_ID = 0;
            this.ctrnFindLicense1.LocalApplication_ID = 0;
            this.ctrnFindLicense1.Location = new System.Drawing.Point(-1, 103);
            this.ctrnFindLicense1.Name = "ctrnFindLicense1";
            this.ctrnFindLicense1.Size = new System.Drawing.Size(1221, 471);
            this.ctrnFindLicense1.TabIndex = 0;
            this.ctrnFindLicense1.OnLicenseSelected += new System.Action<bool>(this.ctrnFindLicense1_OnLicenseSelected);
            // 
            // laExDate
            // 
            this.laExDate.AutoSize = true;
            this.laExDate.BackColor = System.Drawing.Color.White;
            this.laExDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laExDate.ForeColor = System.Drawing.Color.Black;
            this.laExDate.Location = new System.Drawing.Point(262, 718);
            this.laExDate.Name = "laExDate";
            this.laExDate.Size = new System.Drawing.Size(65, 31);
            this.laExDate.TabIndex = 160;
            this.laExDate.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 158;
            this.label3.Text = "Expration Date :";
            // 
            // laIssueDate
            // 
            this.laIssueDate.AutoSize = true;
            this.laIssueDate.BackColor = System.Drawing.Color.White;
            this.laIssueDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laIssueDate.ForeColor = System.Drawing.Color.Black;
            this.laIssueDate.Location = new System.Drawing.Point(260, 670);
            this.laIssueDate.Name = "laIssueDate";
            this.laIssueDate.Size = new System.Drawing.Size(65, 31);
            this.laIssueDate.TabIndex = 154;
            this.laIssueDate.Text = "[???]";
            // 
            // laOldLicenseID
            // 
            this.laOldLicenseID.AutoSize = true;
            this.laOldLicenseID.BackColor = System.Drawing.Color.White;
            this.laOldLicenseID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.laOldLicenseID.Location = new System.Drawing.Point(265, 768);
            this.laOldLicenseID.Name = "laOldLicenseID";
            this.laOldLicenseID.Size = new System.Drawing.Size(61, 31);
            this.laOldLicenseID.TabIndex = 149;
            this.laOldLicenseID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 148;
            this.label1.Text = "Old.License.ID :";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.BackColor = System.Drawing.Color.White;
            this.r.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.r.ForeColor = System.Drawing.Color.Black;
            this.r.Location = new System.Drawing.Point(56, 56);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(146, 31);
            this.r.TabIndex = 140;
            this.r.Text = "Issue Date :";
            // 
            // laAppID
            // 
            this.laAppID.AutoSize = true;
            this.laAppID.BackColor = System.Drawing.Color.White;
            this.laAppID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laAppID.ForeColor = System.Drawing.Color.Black;
            this.laAppID.Location = new System.Drawing.Point(253, 12);
            this.laAppID.Name = "laAppID";
            this.laAppID.Size = new System.Drawing.Size(65, 31);
            this.laAppID.TabIndex = 141;
            this.laAppID.Text = "[???]";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.BackColor = System.Drawing.Color.White;
            this.i.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.i.ForeColor = System.Drawing.Color.Black;
            this.i.Location = new System.Drawing.Point(53, 13);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(150, 31);
            this.i.TabIndex = 144;
            this.i.Text = "R.L.App.ID :";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssue.BackgroundImage")));
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Location = new System.Drawing.Point(621, 814);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(74, 57);
            this.btnIssue.TabIndex = 168;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(418, 831);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 167;
            this.label6.Text = "Renew License :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(409, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 35);
            this.label2.TabIndex = 166;
            this.label2.Text = "Application Basic Info";
            // 
            // lnkShowLicense
            // 
            this.lnkShowLicense.AutoSize = true;
            this.lnkShowLicense.BackColor = System.Drawing.Color.Transparent;
            this.lnkShowLicense.Enabled = false;
            this.lnkShowLicense.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lnkShowLicense.LinkColor = System.Drawing.Color.Snow;
            this.lnkShowLicense.Location = new System.Drawing.Point(864, 831);
            this.lnkShowLicense.Name = "lnkShowLicense";
            this.lnkShowLicense.Size = new System.Drawing.Size(284, 32);
            this.lnkShowLicense.TabIndex = 165;
            this.lnkShowLicense.TabStop = true;
            this.lnkShowLicense.Text = "Show New License Info";
            this.lnkShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicense_LinkClicked);
            // 
            // lnkShowLicenseHistory
            // 
            this.lnkShowLicenseHistory.AutoSize = true;
            this.lnkShowLicenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lnkShowLicenseHistory.Enabled = false;
            this.lnkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lnkShowLicenseHistory.LinkColor = System.Drawing.Color.Snow;
            this.lnkShowLicenseHistory.Location = new System.Drawing.Point(61, 831);
            this.lnkShowLicenseHistory.Name = "lnkShowLicenseHistory";
            this.lnkShowLicenseHistory.Size = new System.Drawing.Size(264, 32);
            this.lnkShowLicenseHistory.TabIndex = 164;
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
            this.laAppDate.Location = new System.Drawing.Point(982, 671);
            this.laAppDate.Name = "laAppDate";
            this.laAppDate.Size = new System.Drawing.Size(65, 31);
            this.laAppDate.TabIndex = 163;
            this.laAppDate.Text = "[???]";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(929, 666);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 162;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(709, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 31);
            this.label5.TabIndex = 161;
            this.label5.Text = "Application Date :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(209, 715);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 159;
            this.pictureBox3.TabStop = false;
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.BackColor = System.Drawing.Color.White;
            this.laFees.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laFees.ForeColor = System.Drawing.Color.Black;
            this.laFees.Location = new System.Drawing.Point(982, 718);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(65, 31);
            this.laFees.TabIndex = 157;
            this.laFees.Text = "[???]";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.White;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(929, 710);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(47, 44);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 156;
            this.pictureBox13.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(782, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 31);
            this.label9.TabIndex = 155;
            this.label9.Text = "Total Fees :";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.BackColor = System.Drawing.Color.White;
            this.laUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laUserName.ForeColor = System.Drawing.Color.Black;
            this.laUserName.Location = new System.Drawing.Point(982, 623);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(65, 31);
            this.laUserName.TabIndex = 153;
            this.laUserName.Text = "[???]";
            // 
            // laReLicenseID
            // 
            this.laReLicenseID.AutoSize = true;
            this.laReLicenseID.BackColor = System.Drawing.Color.White;
            this.laReLicenseID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.laReLicenseID.ForeColor = System.Drawing.Color.Black;
            this.laReLicenseID.Location = new System.Drawing.Point(982, 763);
            this.laReLicenseID.Name = "laReLicenseID";
            this.laReLicenseID.Size = new System.Drawing.Size(65, 31);
            this.laReLicenseID.TabIndex = 152;
            this.laReLicenseID.Text = "[???]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 760);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(212, 665);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 44);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 151;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(929, 616);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 147;
            this.pictureBox6.TabStop = false;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.White;
            this.a.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.a.ForeColor = System.Drawing.Color.Black;
            this.a.Location = new System.Drawing.Point(778, 624);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(151, 31);
            this.a.TabIndex = 142;
            this.a.Text = "Created By :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(929, 757);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 145;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(211, 619);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 146;
            this.pictureBox5.TabStop = false;
            // 
            // u
            // 
            this.u.AutoSize = true;
            this.u.BackColor = System.Drawing.Color.White;
            this.u.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.u.ForeColor = System.Drawing.Color.Black;
            this.u.Location = new System.Drawing.Point(669, 148);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(255, 31);
            this.u.TabIndex = 143;
            this.u.Text = "Renewed.License.ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.r);
            this.panel1.Controls.Add(this.i);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.u);
            this.panel1.Controls.Add(this.laAppID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 192);
            this.panel1.TabIndex = 169;
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.BackColor = System.Drawing.Color.Transparent;
            this.laStauts.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.laStauts.ForeColor = System.Drawing.Color.Snow;
            this.laStauts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laStauts.Location = new System.Drawing.Point(614, 41);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(264, 46);
            this.laStauts.TabIndex = 170;
            this.laStauts.Text = "Renew License";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(482, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 171;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(519, 865);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 17);
            this.panel2.TabIndex = 172;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1232, 878);
            this.Controls.Add(this.laStauts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.laExDate);
            this.Controls.Add(this.laIssueDate);
            this.Controls.Add(this.laOldLicenseID);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkShowLicense);
            this.Controls.Add(this.lnkShowLicenseHistory);
            this.Controls.Add(this.laAppDate);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.laFees);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.laUserName);
            this.Controls.Add(this.laReLicenseID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrnFindLicense1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew License";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrnFindLicense ctrnFindLicense1;
        private System.Windows.Forms.Label laExDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laIssueDate;
        private System.Windows.Forms.Label laOldLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label laAppID;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkShowLicense;
        private System.Windows.Forms.LinkLabel lnkShowLicenseHistory;
        private System.Windows.Forms.Label laAppDate;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.Label laReLicenseID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label laStauts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}