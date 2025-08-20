using DVLD_Businees;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrnApplicationInfo : UserControl
    {
        public int AppLication_ID { get; set; }
        public int LocalApp_ID { get { return _oApplication.LocalLicenseApp_ID; } }
        public int Person_ID { get { return _oApplication.Person_ID; } }
        public string ClassName { get { return _oApplication.ClassName; } }


        public clsApplication_DB _oApplication = new clsApplication_DB();
        public ctrnApplicationInfo()
        {
            InitializeComponent();
        }
        private void _CheckLinkShowLicense() 
        {
            if (clsApplication_DB.DidHaveLicense(_oApplication.App_ID, _oApplication.ClassName))
            {
                lnShowLicense.Enabled = true;
                //Here Put Form Show License Information
            }
        }
        private void _FillDataInControls(clsApplication_DB oApplication) 
        {
            if (oApplication != null)
            {
                laAppID.Text = oApplication.App_ID.ToString();
                laLocalAppID.Text = oApplication.LocalLicenseApp_ID.ToString();
                laPassedTest.Text = oApplication.PassedTestCount.ToString() + "/3";
                laStatus.Text = oApplication.Status;
                laStatusDate.Text = oApplication.LastStatusDate.ToShortDateString();
                laDate.Text = oApplication.App_Date.ToShortDateString();
                laClassName.Text = oApplication.ClassName;
                laFees.Text = oApplication.Fees.ToString();
                laUserCreation.Text = oApplication.UserName;
                laTestType.Text = oApplication.ApplicationTypeTitle;
                laApplicant.Text = oApplication.PersonName;
                _CheckLinkShowLicense();
            }
        }
        public void _LoadData(object sender) 
        {
            _oApplication = clsApplication_DB.FindApp(AppLication_ID);
            _FillDataInControls(_oApplication);
        }
        private void lnkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(Person_ID);
            personDetails.ShowDialog();
        }
        private void ctrnApplicationInfo_Load(object sender, EventArgs e)
        {
            _LoadData(sender);
        }

        private void lnShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_oApplication.LocalLicenseApp_ID,-1);
            frmShowLicense.ShowDialog();
        }
    }
}
