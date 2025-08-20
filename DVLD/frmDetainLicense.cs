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
    public partial class frmDetainLicense : Form
    {

        public bool IsSaved { get; set; } = false;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        clsLicense_DB oLicense = new clsLicense_DB();

        private void _Begining()
        {
            laAppDate.Text = DateTime.Now.ToShortDateString();
            laDetainedDate.Text = DateTime.Now.ToShortDateString();
            laUserName.Text = clsUser_DB.CurrentUser.UserName;
            oLicense.Mode = clsLicense_DB.enMode.Detain;
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicense = new frmShowLicenseHistory(ctrnFindLicense1.LocalApplication_ID);
            frmShowLicense.ShowDialog();
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
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _Begining();
        }


        private void _StoreDataInoLicense()
        {
            oLicense.License_ID = ctrnFindLicense1.License_ID;
            string Input = tbFineFees.Text.Trim().Replace(" ", "");
            oLicense.FineFees = string.IsNullOrEmpty(Input) ? 100 : Convert.ToDecimal(Input);
            oLicense.User_ID = clsUser_DB.CurrentUser.User_ID;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsLicense_DB.IsLicenseActive(ctrnFindLicense1.License_ID))
            {
                if (!clsLicense_DB.IsLicenseDetained(ctrnFindLicense1.License_ID))
                {
                    _StoreDataInoLicense();
                    if (oLicense.Save())
                    {
                        MessageBox.Show("Detained Done Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        laDetainID.Text = oLicense.DeLicense_ID.ToString();
                        lnkShowLicense.Enabled = true;
                        IsSaved = true;
                    }
                    else
                        MessageBox.Show("Detained Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("This License Is Already Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("This License Is Not Active Cannot Renew License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lnkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(-1, -1, oLicense.License_ID);
            frmShowLicense.ShowDialog();
        }
    }
}
