using DVLD_Businees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRenewLicense : Form
    {

        clsLicense_DB oLicense = new clsLicense_DB();
        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void _Begining()
        {
            laAppDate.Text = DateTime.Now.ToShortDateString();
            laIssueDate.Text = DateTime.Now.ToShortDateString();
            laExDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            laFees.Text = "27.0";
            laUserName.Text = clsUser_DB.CurrentUser.UserName;
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            _Begining();
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


        private void _StoreDataInoLicense() 
        {
            oLicense.License_ID = ctrnFindLicense1.License_ID;
            oLicense.LocalDrivingLicense_ID = ctrnFindLicense1.LocalApplication_ID;
            oLicense.Mode = clsLicense_DB.enMode.Renew;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsLicense_DB.IsLicenseActive(ctrnFindLicense1.License_ID)) 
            {
                if (clsLicense_DB.IsLicenseEnded(ctrnFindLicense1.License_ID))
                {
                    _StoreDataInoLicense();
                    if (oLicense.Save())
                    {
                        MessageBox.Show("Renewed Done Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        laAppID.Text = oLicense.Application_ID.ToString();
                        laReLicenseID.Text = oLicense.ReLicense_ID.ToString();
                        lnkShowLicense.Enabled = true;
                    }
                    

                }
                else
                    MessageBox.Show("This License Has Not Expired Yet Cannot Renew License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("This License Is Not Active Cannot Renew License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicense = new frmShowLicenseHistory(ctrnFindLicense1.LocalApplication_ID);
            frmShowLicense.ShowDialog();
        }

        private void lnkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(-1, -1, oLicense.ReLicense_ID);
            frmShowLicense.ShowDialog();
        }
    }
}
