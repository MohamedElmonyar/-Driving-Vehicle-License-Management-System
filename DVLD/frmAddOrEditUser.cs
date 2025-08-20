using DVLD_Businees;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddOrEditUser : Form
    {
        clsUser_DB clsUser = new clsUser_DB();
        clsUser_DB._enMode _Mode;
        public bool _Saved { set; get; }
        public frmAddOrEditUser(int UserID,int PersonID)
        {
            InitializeComponent();  
            clsUser.User_ID= UserID;
            clsUser.Person_ID= PersonID;
            _CheckMode();
        }
        private void _CheckMode() 
        {
            if (clsUser.User_ID == -1)
                _Mode = clsUser_DB._enMode.Add;
            else
                _Mode = clsUser_DB._enMode.Update;
        }
        private void _FillDataInControl(clsUser_DB _clsUser) 
        {
            laUserID.Text = _clsUser.User_ID.ToString();
            tbUserName.Text = _clsUser.UserName;
            tbPassword.Text = _clsUser.Password;
            chbIsActive.Checked = _clsUser.IsActive;
            tbConfirmPassword.Text = _clsUser.Password;
        }
        private void _FillDataInclsUser() 
        {
            //clsUser.User_ID = Convert.ToInt32(laUserID.Text);
            clsUser.Person_ID = ctrnFindPerson1.Person_ID;
            clsUser.UserName = tbUserName.Text;
            clsUser.Password = tbPassword.Text;
            clsUser.IsActive = chbIsActive.Checked;
            clsUser._Mode = _Mode;
        }
        private void _ModeUpdate() 
        {
            laStauts.Text = "Update User";
            laS2.Text = "Update User";
            clsUser = clsUser_DB.FindUser(clsUser.User_ID);
            ctrnFindPerson1.LoadPersonData(clsUser.Person_ID);
            _FillDataInControl(clsUser);
        }
        private void _LoadData() 
        {
            if (_Mode == clsUser_DB._enMode.Update)
                _ModeUpdate();
            else if (_Mode == clsUser_DB._enMode.Add)
            {
                laStauts.Text = "Add New User";
                laS2.Text = "Add New User";
                _FillDataInControl(clsUser);
                laUserID.Text = "N/A";
            }
        }
        private void frmAddOrEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (_Mode == clsUser_DB._enMode.Update)
                TcParent.SelectedTab = TapLogin;
            else if (!clsUser_DB.IsPersonUser(ctrnFindPerson1.Person_ID))
                TcParent.SelectedTab = TapLogin;
            else
            {
                btnNext.Enabled = false;
                MessageBox.Show("Selected Person Already Has a User", "Select Another Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TcParent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == TapLogin && !btnNext.Enabled)
            {
                MessageBox.Show("Choose The Person First","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TcParent.SelectedTab = TapPersonalInfo;
            }
        }
        private bool _IsTextBoxesNotNull(TabPage tab)
        {
            return tab.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void TextValidation(object sender, CancelEventArgs e)
        {
            TextBox Texts = sender as TextBox;
            if (Texts != null)
            {
                if (string.IsNullOrEmpty(Texts.Text))
                {
                    erp.SetError(Texts, "This Field Is Required");
                    e.Cancel = true;
                }
                else
                    erp.SetError(Texts, "");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsTextBoxesNotNull(TapLogin)) 
            {
                _FillDataInclsUser();
                if (clsUser.Save())
                {
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == clsUser_DB._enMode.Add)
                        _Mode = clsUser_DB._enMode.Update;
                    laUserID.Text = clsUser.User_ID.ToString();
                    _CheckMode();
                    this._Saved = true;
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter the Data Correctly", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void tbConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                erp.SetError(tbConfirmPassword, "Password Confirmation Does Not Match Password !");
                e.Cancel = true;
            }
            else
                erp.SetError(tbConfirmPassword, "");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            TcParent.SelectedTab = TapPersonalInfo;
        }
        private void ctrnFindPerson1_OnPersonSelected(bool obj)
        {
            if(obj)
                btnNext.Enabled = true;
        }
        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbConfirmPassword.PasswordChar = '*';       
            }
        }
    }
}
