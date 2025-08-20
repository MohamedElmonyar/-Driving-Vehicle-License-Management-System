using DVLD_Businees;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReplaceLicense : Form
    {
        public frmReplaceLicense()
        {
            InitializeComponent();
        }

        clsLicense_DB oLicense = new clsLicense_DB();
        private void _Begining()
        {
            laAppDate.Text = DateTime.Now.ToShortDateString();
            laIssueDate.Text = DateTime.Now.ToShortDateString();
            oLicense.Mode = clsLicense_DB.enMode.Replace;
            laUserName.Text = clsUser_DB.CurrentUser.UserName;
            rbDamage.Checked = true;
            laFees.Text = rbDamage.Checked ? "5.0" : "10.0";
        }

        private void _StoreDataInoLicense()
        {
            oLicense.License_ID = ctrnFindLicense1.License_ID;
            oLicense.LocalDrivingLicense_ID = ctrnFindLicense1.LocalApplication_ID;
            oLicense.ReplaceReason = rbDamage.Checked ? clsLicense_DB.enLicenseRepalceReason.Damage : clsLicense_DB.enLicenseRepalceReason.Lost;
        }
        private void ctrnFindLicense1_OnLicenseSelected(bool obj)
        {
            if (obj)
            {
                btnIssue.Enabled = true;
                lnkShowLicenseHistory.Enabled = true;
                laOldLicenseID.Text = ctrnFindLicense1.License_ID.ToString();
            }
            else
            {
                btnIssue.Enabled = false;
                lnkShowLicenseHistory.Enabled = false;
                laOldLicenseID.Text = string.Empty;
            }
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicense = new frmShowLicenseHistory(ctrnFindLicense1.LocalApplication_ID,-1,-1,ctrnFindLicense1.License_ID);
            frmShowLicense.ShowDialog();
        }

        private void lnkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(-1, -1, oLicense.ReLicense_ID);
            frmShowLicense.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        { 
                _StoreDataInoLicense();
            if (clsLicense_DB.IsLicenseActive(ctrnFindLicense1.License_ID))
            {
                if (oLicense.Save())
                {
                    MessageBox.Show("Replaced Done Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    laAppID.Text = oLicense.Application_ID.ToString();
                    laReLicenseID.Text = oLicense.ReLicense_ID.ToString();
                    lnkShowLicense.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("This License Is Not Active You Can't Replace It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReplaceLicense_Load(object sender, EventArgs e)
        {
            _Begining();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            laFees.Text = rbLost.Checked ? "5.0" : "10.0";
        }

 
    }
}
