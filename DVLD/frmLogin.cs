using DVLD_Businees;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        private string _FolderPath = @"C:\Users\Mohamed Elmonaier\source\repos\C#Projects\DVLD\bin\Debug\LastUser.txt";
        private string[] _FileContent = new string[2];
       
        public frmLogin()
        {
            InitializeComponent();
        }
        private void _LoadUserData()
        {
            string SubKey = @"Software\DVLD_Last_User";

            try
            {
                using (RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKey))
                {
                    if (key != null)
                    {
                        tbUserName.Text = key.GetValue("DVLD_LOGIN_USERNAME") as string;
                        tbPassword.Text = key.GetValue("DVLD_LOGIN_PASSWORD") as string;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Saving User Data. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _LoadUserData();
        }
        private void _CheckLogin() 
        {
            if (clsUser_DB.IsUserExist(tbUserName.Text, tbPassword.Text))
            {
                if (clsUser_DB.IsUserActive(tbUserName.Text, tbPassword.Text))
                {
                    _StoreDataInCurrentUser(tbUserName.Text, tbPassword.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("This User Is Not Active Contact Your Admin",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Enter Correct User Name And Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void _StoreDataInCurrentUser(string UserName, string Password) 
        {
            clsUser_DB.CurrentUser = clsUser_DB.FindUser(UserName, Password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _CheckLogin();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string SubKey = @"Software\DVLD_Last_User";
            if (chbRememberMe.Checked)
            {     
                try
                {
                    using (RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(SubKey))
                    {
                        if (key != null)
                        {
                            key.SetValue("DVLD_LOGIN_USERNAME", tbUserName.Text,RegistryValueKind.String);
                            key.SetValue("DVLD_LOGIN_PASSWORD", tbPassword.Text, RegistryValueKind.String);
                        }
                    }


                }
                catch
                { 
                 MessageBox.Show("Error Saving User Data. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
          
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }
    }
}
