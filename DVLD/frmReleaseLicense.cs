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
    public partial class frmReleaseLicense : Form
    {

        public bool IsSaved { get; set; } = false;

        clsLicense_DB oLicense = new clsLicense_DB();
        public frmReleaseLicense(int License_ID = -1)
        {
            InitializeComponent();
            oLicense.Mode = clsLicense_DB.enMode.Release;
            this.ctrnFindLicense1.License_ID = License_ID;
        }

        private void _Begining()
        {
            laAppFees.Text = "15.00";
            laUserName.Text = clsUser_DB.CurrentUser.UserName;      
        }
        private void lnkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicense = new frmShowLicenseHistory(ctrnFindLicense1.LocalApplication_ID,-1,-1, this.ctrnFindLicense1.License_ID);
            frmShowLicense.ShowDialog();
        }
        private void ctrnFindLicense1_OnLicenseSelected(bool obj)
        {

            if (obj)
            {
                btnIssue.Enabled = true;
                lnkShowLicenseHistory.Enabled = true;
                
                laOldLicenseID.Text = ctrnFindLicense1.License_ID.ToString();
                _LoadData();
            }
            else
            {

                btnIssue.Enabled = false;
                lnkShowLicenseHistory.Enabled = false;
                laOldLicenseID.Text = string.Empty;
            }
        }



        
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsLicense_DB.IsLicenseDetained(ctrnFindLicense1.License_ID))
            {
                _StoreDataInoLicense();
                if (this.oLicense.Save())
                {
                    MessageBox.Show("Released Done Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lnkShowLicense.Enabled = true;
                    btnIssue.Enabled = false;
                    laReAppID.Text = oLicense.Application_ID.ToString();
                    IsSaved = true;
                }
                else
                    MessageBox.Show("Released Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("This License Is Not Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillControls(clsLicense_DB oLicense)
        {
            if (oLicense != null) 
            {
                laDetainID.Text = oLicense.DeLicense_ID.ToString();
                laDetainedDate.Text = oLicense.IssueDate.ToShortDateString();
                laFineFees.Text = oLicense.FineFees.ToString("0.00");   
                laTotalFess.Text = (oLicense.FineFees + 15).ToString("0.00");
            }       
        }
        private void _LoadData() 
        {
            _Begining();
            clsLicense_DB _oLicense = clsLicense_DB.FindDetainedLicense(ctrnFindLicense1.License_ID);
            _FillControls(_oLicense);
        }
        private void _StoreDataInoLicense()
        {
            oLicense.License_ID = ctrnFindLicense1.License_ID;
            oLicense.User_ID = clsUser_DB.CurrentUser.User_ID;
        }
        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            _Begining();
        }
        private void lnkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(-1, -1, oLicense.License_ID);
            frmShowLicense.ShowDialog();
        }


    }
}
