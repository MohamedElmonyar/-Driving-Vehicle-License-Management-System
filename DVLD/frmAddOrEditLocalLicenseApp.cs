using DVLD_Businees;
using System;
using System.Windows.Forms;
using static DVLD.frmAddOrEditPepole;

namespace DVLD
{
    public partial class frmAddOrEditLocalLicenseApp : Form
    {
        public delegate void DataBackLocalLicenseApp_ID(object sender, int PersonID);
        public event DataBackLocalLicenseApp_ID IDBack;
        clsLocalLicenses_DB.enMode _mode;
        int LocalLicenseApp_ID;
        public bool Saved { set; get; }
        clsLocalLicenses_DB _oLocalLicense = new clsLocalLicenses_DB();
        public frmAddOrEditLocalLicenseApp(int LocalLicenseAppID)
        {
            InitializeComponent();
            LocalLicenseApp_ID = LocalLicenseAppID;
            _CheckMode(LocalLicenseApp_ID);
            cbLicensesClasses.DataSource = clsLocalLicenses_DB.GetAllLicnesesClasses();
        }
        private void _FillControls_oLocalLicense(clsLocalLicenses_DB oLocalLicense)
        {
            ctrnFindPerson1.LoadPersonData(oLocalLicense.Person_ID);
            cbLicensesClasses.SelectedIndex = (oLocalLicense.ClassName_ID-1);
            laAPPID.Text = oLocalLicense.LocalLicenseApp_ID.ToString();
            laDate.Text = oLocalLicense.Date.ToString();
            laCurrentUser.Text = clsUser_DB.CurrentUser.UserName;
        }
        private void _CheckMode(int ID)
        {
            if (ID == -1)
                _mode = clsLocalLicenses_DB.enMode.Add;
            else
                _mode = clsLocalLicenses_DB.enMode.Update;
        }
        private void _LoadData()
        {
            cbLicensesClasses.DisplayMember = "ClassName";
            if (_mode == clsLocalLicenses_DB.enMode.Add)
            {
                laDate.Text = DateTime.Now.ToString();
                laCurrentUser.Text = clsUser_DB.CurrentUser.UserName;
                cbLicensesClasses.SelectedIndex = 0;
            }
            else
            {
                _oLocalLicense = clsLocalLicenses_DB.Find(LocalLicenseApp_ID);
                _FillControls_oLocalLicense(_oLocalLicense);
                laAPPID.Text = _oLocalLicense.LocalLicenseApp_ID.ToString();
                laStauts.Text = "Update License Driving Application";
            }
        }
        private void _FillDataIn_oLocalLicense()
        {
            _oLocalLicense.Mode = _mode;
            _oLocalLicense.Person_ID = ctrnFindPerson1.Person_ID;
            _oLocalLicense.Date = DateTime.Parse(laDate.Text); ;
            _oLocalLicense.ClassName_ID = cbLicensesClasses.SelectedIndex + 1; 
            _oLocalLicense.UserCreate_ID = clsUser_DB.CurrentUser.User_ID;
        }
        private void ctrnFindPerson1_OnPersonSelected(bool obj)
        {
            if (obj)
            btnNext.Enabled = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            TcParent.SelectedTab = TapPersonalInfo;
        }
        private void TcParent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == TapLogin && !btnNext.Enabled)
            {
                MessageBox.Show("Choose The Person First", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TcParent.SelectedTab = TapPersonalInfo;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            TcParent.SelectedTab = TapLogin;
        }
        private void frmNewLocalLicenses_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsLocalLicenses_DB.IsApplicationExist(ctrnFindPerson1.Person_ID,(cbLicensesClasses.SelectedIndex+1))) 
            {
                _FillDataIn_oLocalLicense();
                if (_oLocalLicense.Save()) 
                {
                    laAPPID.Text = _oLocalLicense.LocalLicenseApp_ID.ToString();
                    laStauts.Text = "Update License Driving Application";
                    Saved = true;
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Choose Another License Class\nThe " +
                    "Selected Person Already Have An Active Application", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frmAddOrEditLocalLicenseApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            IDBack?.Invoke(this, _oLocalLicense.LocalLicenseApp_ID);
        }
    }
}
