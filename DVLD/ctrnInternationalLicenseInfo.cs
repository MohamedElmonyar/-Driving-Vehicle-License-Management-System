using DVLD_Businees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrnInternationalLicenseInfo : UserControl
    {
        public int InternationalLicense_ID { get; set; }
        private string _ImageMalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Male.png";
        private string _ImageFemalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Female.png";
        public int Person_ID { get; set; }
        clsInternationalLicense_DB oInternationalLicense = new clsInternationalLicense_DB();
        public ctrnInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void pbPicture_Load(clsInternationalLicense_DB oLicense)
        {
            if (!string.IsNullOrEmpty(oLicense.ImagePath) && File.Exists(oLicense.ImagePath))
                pbPicture.Load(oLicense.ImagePath);
            else if (oLicense.Gendor == "Male")
                pbPicture.Load(_ImageMalePath);
            else
                pbPicture.Load(_ImageFemalePath);
        }
        private void _LoadDataInControls(clsInternationalLicense_DB oInternationalLicense)
        {

            if (oInternationalLicense != null)
            {
                this.InternationalLicense_ID = oInternationalLicense.InternationalLicenseID;
                laInterLicense.Text = oInternationalLicense.InternationalLicenseID.ToString();
                laName.Text = oInternationalLicense.FullName;
                laBirthOfDate.Text = oInternationalLicense.DateOfBirth.ToShortDateString();
                laNationalNo.Text = oInternationalLicense.NationalNo;
                laLicenseID.Text = oInternationalLicense.IssuedUsingLocalLicenseID.ToString();
                laIssueDate.Text = oInternationalLicense.IssueDate.ToShortDateString();
                laExDate.Text = oInternationalLicense.ExpirationDate.ToShortDateString();
                laDriverID.Text = oInternationalLicense.DriverID.ToString();
                laIsActive.Text = oInternationalLicense.IsActive ? "Yes" : "NO";
                this.Person_ID = oInternationalLicense.PersonID;
                pbPicture_Load(oInternationalLicense);
            }

        }

        public void _LoadData()
        {
            oInternationalLicense = clsInternationalLicense_DB.FindInternationalLicenseByID(InternationalLicense_ID);
            _LoadDataInControls(oInternationalLicense);
        }
        private void ctrnInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void lnEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(Person_ID);
            frm.ShowDialog();
        }


    }
}
