namespace DVLD
{
    partial class frmAddOrEditUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditUser));
            this.TapLogin = new System.Windows.Forms.TabPage();
            this.chbPassword = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.laS2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.laUserID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TapPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrnFindPerson1 = new DVLD.ctrnFindPerson();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.laStauts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TcParent = new System.Windows.Forms.TabControl();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.TapLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TapPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TcParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // TapLogin
            // 
            this.TapLogin.BackColor = System.Drawing.Color.White;
            this.TapLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TapLogin.BackgroundImage")));
            this.TapLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TapLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TapLogin.Controls.Add(this.chbPassword);
            this.TapLogin.Controls.Add(this.button1);
            this.TapLogin.Controls.Add(this.label9);
            this.TapLogin.Controls.Add(this.btnBack);
            this.TapLogin.Controls.Add(this.label8);
            this.TapLogin.Controls.Add(this.chbIsActive);
            this.TapLogin.Controls.Add(this.laS2);
            this.TapLogin.Controls.Add(this.pictureBox6);
            this.TapLogin.Controls.Add(this.pictureBox3);
            this.TapLogin.Controls.Add(this.label5);
            this.TapLogin.Controls.Add(this.tbConfirmPassword);
            this.TapLogin.Controls.Add(this.tbPassword);
            this.TapLogin.Controls.Add(this.tbUserName);
            this.TapLogin.Controls.Add(this.laUserID);
            this.TapLogin.Controls.Add(this.pictureBox5);
            this.TapLogin.Controls.Add(this.pictureBox4);
            this.TapLogin.Controls.Add(this.label7);
            this.TapLogin.Controls.Add(this.label6);
            this.TapLogin.Controls.Add(this.pictureBox2);
            this.TapLogin.Controls.Add(this.label4);
            this.TapLogin.Controls.Add(this.btnSave);
            this.TapLogin.Controls.Add(this.label1);
            this.TapLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.TapLogin.Location = new System.Drawing.Point(4, 38);
            this.TapLogin.Name = "TapLogin";
            this.TapLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TapLogin.Size = new System.Drawing.Size(1131, 696);
            this.TapLogin.TabIndex = 1;
            this.TapLogin.Text = "Login Info";
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.BackColor = System.Drawing.Color.Transparent;
            this.chbPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.chbPassword.ForeColor = System.Drawing.Color.Black;
            this.chbPassword.Location = new System.Drawing.Point(786, 388);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(195, 31);
            this.chbPassword.TabIndex = 59;
            this.chbPassword.Text = "Show Password";
            this.chbPassword.UseVisualStyleBackColor = false;
            this.chbPassword.CheckedChanged += new System.EventHandler(this.chbPassword_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1071, 616);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 58;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(993, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "Close";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack.Size = new System.Drawing.Size(52, 42);
            this.btnBack.TabIndex = 56;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(66, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Back";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chbIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbIsActive.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.chbIsActive.Location = new System.Drawing.Point(577, 526);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(161, 41);
            this.chbIsActive.TabIndex = 42;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbIsActive.UseVisualStyleBackColor = false;
            // 
            // laS2
            // 
            this.laS2.AutoSize = true;
            this.laS2.BackColor = System.Drawing.Color.Transparent;
            this.laS2.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.laS2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laS2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laS2.Location = new System.Drawing.Point(388, 157);
            this.laS2.Name = "laS2";
            this.laS2.Size = new System.Drawing.Size(320, 56);
            this.laS2.TabIndex = 39;
            this.laS2.Text = "Add New User";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(459, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 132);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(478, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(199, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "Confirm Password:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(554, 471);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(201, 37);
            this.tbConfirmPassword.TabIndex = 36;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(554, 387);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(201, 37);
            this.tbPassword.TabIndex = 35;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextValidation);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(554, 309);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(201, 37);
            this.tbUserName.TabIndex = 34;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TextValidation);
            // 
            // laUserID
            // 
            this.laUserID.AutoSize = true;
            this.laUserID.BackColor = System.Drawing.Color.Transparent;
            this.laUserID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.laUserID.Location = new System.Drawing.Point(554, 241);
            this.laUserID.Name = "laUserID";
            this.laUserID.Size = new System.Drawing.Size(56, 37);
            this.laUserID.TabIndex = 33;
            this.laUserID.Text = "???";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(478, 301);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(478, 379);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(302, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 37);
            this.label7.TabIndex = 29;
            this.label7.Text = "User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(321, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 37);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(478, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(355, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "User ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(567, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(60, 53);
            this.btnSave.TabIndex = 17;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(476, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Save";
            // 
            // TapPersonalInfo
            // 
            this.TapPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.TapPersonalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TapPersonalInfo.BackgroundImage")));
            this.TapPersonalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TapPersonalInfo.Controls.Add(this.ctrnFindPerson1);
            this.TapPersonalInfo.Controls.Add(this.button2);
            this.TapPersonalInfo.Controls.Add(this.label10);
            this.TapPersonalInfo.Controls.Add(this.label3);
            this.TapPersonalInfo.Controls.Add(this.btnNext);
            this.TapPersonalInfo.Controls.Add(this.laStauts);
            this.TapPersonalInfo.Controls.Add(this.pictureBox1);
            this.TapPersonalInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TapPersonalInfo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapPersonalInfo.Location = new System.Drawing.Point(4, 38);
            this.TapPersonalInfo.Name = "TapPersonalInfo";
            this.TapPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TapPersonalInfo.Size = new System.Drawing.Size(1131, 696);
            this.TapPersonalInfo.TabIndex = 0;
            this.TapPersonalInfo.Text = "Personal Info";
            // 
            // ctrnFindPerson1
            // 
            this.ctrnFindPerson1.Location = new System.Drawing.Point(-8, 200);
            this.ctrnFindPerson1.Name = "ctrnFindPerson1";
            this.ctrnFindPerson1.NationalNo = null;
            this.ctrnFindPerson1.Person_ID = 0;
            this.ctrnFindPerson1.Size = new System.Drawing.Size(1134, 412);
            this.ctrnFindPerson1.TabIndex = 61;
            this.ctrnFindPerson1.OnPersonSelected += new System.Action<bool>(this.ctrnFindPerson1_OnPersonSelected);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(89, 626);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 60;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 633);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 28);
            this.label10.TabIndex = 59;
            this.label10.Text = "Close";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(993, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "Next";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1070, 626);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(52, 42);
            this.btnNext.TabIndex = 55;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.laStauts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laStauts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.laStauts.Location = new System.Drawing.Point(392, 141);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(320, 56);
            this.laStauts.TabIndex = 38;
            this.laStauts.Text = "Add New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // TcParent
            // 
            this.TcParent.Controls.Add(this.TapPersonalInfo);
            this.TcParent.Controls.Add(this.TapLogin);
            this.TcParent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TcParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TcParent.ItemSize = new System.Drawing.Size(123, 34);
            this.TcParent.Location = new System.Drawing.Point(-4, 1);
            this.TcParent.Name = "TcParent";
            this.TcParent.SelectedIndex = 0;
            this.TcParent.Size = new System.Drawing.Size(1139, 738);
            this.TcParent.TabIndex = 0;
            this.TcParent.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TcParent_Selecting);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // frmAddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1139, 746);
            this.Controls.Add(this.TcParent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrEditUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit User";
            this.Load += new System.EventHandler(this.frmAddOrEditUser_Load);
            this.TapLogin.ResumeLayout(false);
            this.TapLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TapPersonalInfo.ResumeLayout(false);
            this.TapPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TcParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TapLogin;
        private System.Windows.Forms.TabPage TapPersonalInfo;
        private System.Windows.Forms.TabControl TcParent;
        private System.Windows.Forms.Label laStauts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label laUserID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label laS2;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private ctrnFindPerson ctrnFindPerson1;
        private System.Windows.Forms.CheckBox chbPassword;
    }
}