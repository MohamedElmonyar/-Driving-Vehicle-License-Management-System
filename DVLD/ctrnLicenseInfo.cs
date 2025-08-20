using DVLD_Businees;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrnLicenseInfo : UserControl
    {

        public int LocalLicenseApp_ID { get; set; } = -1;
        public int License_ID { get; set; } = -1;
        private string _ImageMalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Male.png";
        private string _ImageFemalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Female.png";
        int Person_ID { get; set; } = -1;

        public ctrnLicenseInfo()
        {
            InitializeComponent();
        }

        private void _FillDataInControls(clsLicense_DB oLicense)
        {
            if (oLicense != null)
            {
                laLicenseID.Text = oLicense.License_ID.ToString();
                laName.Text = oLicense.PersonName;
                laClass.Text = oLicense.ClassName;
                laBirthOfDate.Text = oLicense.DateOfBirth.ToShortDateString();
                laIssueDate.Text = oLicense.IssueDate.ToShortDateString();
                laExDate.Text = oLicense.ExpireDate.ToShortDateString();
                laGendor.Text = oLicense.Gendor;
                pbPicture_Load(oLicense);
                laNationalNo.Text = oLicense.NationalNo;
                laDriverID.Text = oLicense.Driver_ID.ToString();
                laIsActive.Text = oLicense.IsActive ? "Yes" : "No";
                laIsDetained.Text = oLicense.IsDetained;
                laIssueReason.Text = oLicense.IssueReason;
                laNotes.Text = oLicense.Notes ?? "N/A";
                Person_ID = oLicense.Person_ID;
            }
        }

        private void pbPicture_Load(clsLicense_DB oLicense)
        {
            if (!string.IsNullOrEmpty(oLicense.ImagePath) && File.Exists(oLicense.ImagePath))
                pbPicture.Load(oLicense.ImagePath);
            else if (oLicense.Gendor == "Male")
                pbPicture.Load(_ImageMalePath);
            else
                pbPicture.Load(_ImageFemalePath);
        }
        private void _LoadData()
        {
            if (LocalLicenseApp_ID != -1)
            {
                clsLicense_DB oLicense = clsLicense_DB.FindLicense(LocalLicenseApp_ID);
                _FillDataInControls(oLicense);
            }
        }

        public void LoadData(int LocalAppID)
        {
            clsLicense_DB oLicense = clsLicense_DB.FindLicense(LocalAppID);
            _FillDataInControls(oLicense);
        }

        public void LoadDataLicense(int LicenseID)
        {
            clsLicense_DB oLicense = clsLicense_DB.FindLicenseID(LicenseID);
            _FillDataInControls(oLicense);
        }
        private void ctrnLicenseInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void lnEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(Person_ID);
            personDetails.ShowDialog();
        }
    }
}
