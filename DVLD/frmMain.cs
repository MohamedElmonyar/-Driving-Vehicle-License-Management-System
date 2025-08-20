using DVLD_Businees;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmPepole frmPepole = new frmPepole();
           frmPepole.ShowDialog(); 
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails(clsUser_DB.CurrentUser.User_ID);
            frmUser.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmLogin loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)                          
                this.Show();             
            else                       
                this.Close();        
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void changePaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword(clsUser_DB.CurrentUser.User_ID);
            frmChange.ShowDialog();
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationType frmManage  = new frmManageApplicationType();
            frmManage.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestType frmManageTest = new frmManageTestType();
            frmManageTest.ShowDialog();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditLocalLicenseApp frmNewLocal = new frmAddOrEditLocalLicenseApp(-1);
            frmNewLocal.ShowDialog();
        }

        private void localDrivingLicensesApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApp frmLocalDriving = new frmLocalDrivingLicenseApp();
            frmLocalDriving.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frmDrivers = new frmDrivers();
            frmDrivers.ShowDialog();
        }

        private void interNationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenses frmInternational = new frmAddNewInternationalLicenses();
            frmInternational.ShowDialog();
        }

        private void internationalLicensesApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenses frmInternationalLicenses = new frmInternationalLicenses();
            frmInternationalLicenses.ShowDialog();    
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frmRenewLicense = new frmRenewLicense();
            frmRenewLicense.ShowDialog();
        }

        private void replaceLicenseForDamageOrLostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLicense frmReplaceLicense = new frmReplaceLicense();
            frmReplaceLicense.ShowDialog();
        }

        private void detainLicensesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense();
            frmDetainLicense.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense();
            frmReleaseLicense.ShowDialog();
        }

        private void manageDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetained frmManageDetained = new frmManageDetained();
            frmManageDetained.ShowDialog();
        }
    }
}
