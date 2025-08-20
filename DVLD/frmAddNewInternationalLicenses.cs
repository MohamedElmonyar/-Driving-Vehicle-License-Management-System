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
    public partial class frmAddNewInternationalLicenses : Form
    {
        int InternationalLicense_ID { set; get; }
        clsInternationalLicense_DB oInternationalLicense = new clsInternationalLicense_DB();
        public frmAddNewInternationalLicenses()
        {
            InitializeComponent();
        }

        private void _Begining() 
        {
            laAppDate.Text = DateTime.Now.ToShortDateString();
            laIssueDate.Text = DateTime.Now.ToShortDateString();
            laExDate.Text = DateTime.Now.AddYears(1).ToShortDateString();   
            laFees.Text = "50.0";
            laUserName.Text = clsUser_DB.CurrentUser.UserName;
        }

        private void frmAddNewInternationalLicenses_Load(object sender, EventArgs e)
        {
            _Begining();
        }

        private void ctrnFindLicense1_OnLicenseSelected(bool obj)
        {
            if (obj)
            {
                btnIssue.Enabled = true;
                lnkShowLicenseHistory.Enabled = true;
                laLocalLicenseID.Text = ctrnFindLicense1.LocalApplication_ID.ToString();
            }
            else
            {
                btnIssue.Enabled = false;
                lnkShowLicenseHistory.Enabled = false;
                laLocalLicenseID.Text = string.Empty;
            }
        }

        private void _StoreDataInclsInternationalLicense()
        {

            oInternationalLicense.IssuedUsingLocalLicenseID = ctrnFindLicense1.License_ID;
            oInternationalLicense.IssueDate = DateTime.Now;
            oInternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            oInternationalLicense.CreatedByUserID = clsUser_DB.CurrentUser.User_ID;            
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!clsInternationalLicense_DB.IsInternationalLicenseExists(ctrnFindLicense1.License_ID)) 
            {
                if (clsLicense_DB.IsLicenseClass3(ctrnFindLicense1.License_ID))
                {
                    _StoreDataInclsInternationalLicense();
                    if (oInternationalLicense.Save())
                    {
                        MessageBox.Show("New International License Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lnkShowLicense.Enabled = true;
                        laILicenseID.Text = oInternationalLicense.InternationalLicenseID.ToString();
                        this.InternationalLicense_ID = oInternationalLicense.InternationalLicenseID;
                    }    
                }
                else
                    MessageBox.Show("This Local License Is Not Ordinary, Cannot Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else            
                MessageBox.Show("International License Already Exists For This Local License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  
        }

        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHist= new frmShowLicenseHistory(ctrnFindLicense1.LocalApplication_ID,-1);
            frmShowLicenseHist.ShowDialog();

        }

        private void lnkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frmShowInternationalLicenseInfo = new frmShowInternationalLicenseInfo(this.InternationalLicense_ID);
            frmShowInternationalLicenseInfo.ShowDialog();
        }  
    }
}
