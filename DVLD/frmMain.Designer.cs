namespace DVLD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interNationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceLicenseForDamageOrLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicensesApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicensesApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(-1);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.pepoleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1920, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.manageApplicationToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationToolStripMenuItem.Image")));
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(199, 49);
            this.applicationToolStripMenuItem.Text = "Applications";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replaceLicenseForDamageOrLostToolStripMenuItem});
            this.drivingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingToolStripMenuItem.Image")));
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(410, 56);
            this.drivingToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingToolStripMenuItem
            // 
            this.newDrivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.interNationalLicensesToolStripMenuItem});
            this.newDrivingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingToolStripMenuItem.Image")));
            this.newDrivingToolStripMenuItem.Name = "newDrivingToolStripMenuItem";
            this.newDrivingToolStripMenuItem.Size = new System.Drawing.Size(474, 38);
            this.newDrivingToolStripMenuItem.Text = "New Driving Licenses";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localToolStripMenuItem.Image")));
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.localToolStripMenuItem.Text = "Local Licenses";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // interNationalLicensesToolStripMenuItem
            // 
            this.interNationalLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("interNationalLicensesToolStripMenuItem.Image")));
            this.interNationalLicensesToolStripMenuItem.Name = "interNationalLicensesToolStripMenuItem";
            this.interNationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.interNationalLicensesToolStripMenuItem.Text = "International Licenses";
            this.interNationalLicensesToolStripMenuItem.Click += new System.EventHandler(this.interNationalLicensesToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renewDrivingLicenseToolStripMenuItem.Image")));
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(474, 38);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replaceLicenseForDamageOrLostToolStripMenuItem
            // 
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replaceLicenseForDamageOrLostToolStripMenuItem.Image")));
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Name = "replaceLicenseForDamageOrLostToolStripMenuItem";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Size = new System.Drawing.Size(474, 38);
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Text = "Replace License For Damage Or Lost";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Click += new System.EventHandler(this.replaceLicenseForDamageOrLostToolStripMenuItem_Click);
            // 
            // manageApplicationToolStripMenuItem
            // 
            this.manageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicensesApplicationsToolStripMenuItem,
            this.internationalLicensesApplicationToolStripMenuItem});
            this.manageApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationToolStripMenuItem.Image")));
            this.manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            this.manageApplicationToolStripMenuItem.Size = new System.Drawing.Size(410, 56);
            this.manageApplicationToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicensesApplicationsToolStripMenuItem
            // 
            this.localDrivingLicensesApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localDrivingLicensesApplicationsToolStripMenuItem.Image")));
            this.localDrivingLicensesApplicationsToolStripMenuItem.Name = "localDrivingLicensesApplicationsToolStripMenuItem";
            this.localDrivingLicensesApplicationsToolStripMenuItem.Size = new System.Drawing.Size(461, 38);
            this.localDrivingLicensesApplicationsToolStripMenuItem.Text = "Local Driving Licenses Applications";
            this.localDrivingLicensesApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicensesApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicensesApplicationToolStripMenuItem
            // 
            this.internationalLicensesApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicensesApplicationToolStripMenuItem.Image")));
            this.internationalLicensesApplicationToolStripMenuItem.Name = "internationalLicensesApplicationToolStripMenuItem";
            this.internationalLicensesApplicationToolStripMenuItem.Size = new System.Drawing.Size(461, 38);
            this.internationalLicensesApplicationToolStripMenuItem.Text = "International Licenses Application";
            this.internationalLicensesApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalLicensesApplicationToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedToolStripMenuItem,
            this.detainLicensesToolStripMenuItem1,
            this.reToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(410, 56);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedToolStripMenuItem
            // 
            this.manageDetainedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedToolStripMenuItem.Image")));
            this.manageDetainedToolStripMenuItem.Name = "manageDetainedToolStripMenuItem";
            this.manageDetainedToolStripMenuItem.Size = new System.Drawing.Size(402, 56);
            this.manageDetainedToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem1
            // 
            this.detainLicensesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem1.Image")));
            this.detainLicensesToolStripMenuItem1.Name = "detainLicensesToolStripMenuItem1";
            this.detainLicensesToolStripMenuItem1.Size = new System.Drawing.Size(402, 56);
            this.detainLicensesToolStripMenuItem1.Text = "Detain Licenses";
            this.detainLicensesToolStripMenuItem1.Click += new System.EventHandler(this.detainLicensesToolStripMenuItem1_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reToolStripMenuItem.Image")));
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(402, 56);
            this.reToolStripMenuItem.Text = "Release Detained License";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // manageApplicationsTypesToolStripMenuItem
            // 
            this.manageApplicationsTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsTypesToolStripMenuItem.Image")));
            this.manageApplicationsTypesToolStripMenuItem.Name = "manageApplicationsTypesToolStripMenuItem";
            this.manageApplicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(410, 56);
            this.manageApplicationsTypesToolStripMenuItem.Text = "Manage Applications Types";
            this.manageApplicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(410, 56);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // pepoleToolStripMenuItem
            // 
            this.pepoleToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pepoleToolStripMenuItem.Image")));
            this.pepoleToolStripMenuItem.Name = "pepoleToolStripMenuItem";
            this.pepoleToolStripMenuItem.Size = new System.Drawing.Size(143, 49);
            this.pepoleToolStripMenuItem.Text = "Pepole";
            this.pepoleToolStripMenuItem.Click += new System.EventHandler(this.pepoleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(146, 49);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(131, 49);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePaToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSettingToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingToolStripMenuItem.Image")));
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(229, 49);
            this.accountSettingToolStripMenuItem.Text = "Account Setting";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("currentUserInfoToolStripMenuItem.Image")));
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePaToolStripMenuItem
            // 
            this.changePaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePaToolStripMenuItem.Image")));
            this.changePaToolStripMenuItem.Name = "changePaToolStripMenuItem";
            this.changePaToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.changePaToolStripMenuItem.Text = "Change Password";
            this.changePaToolStripMenuItem.Click += new System.EventHandler(this.changePaToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interNationalLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicensesApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicensesApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceLicenseForDamageOrLostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
    }
}

