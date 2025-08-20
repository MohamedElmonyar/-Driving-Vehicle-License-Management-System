using DVLD_Businees;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {

        public int User_ID { get; set; }

        public string Password { get; set; }
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            ctrnUserDetails1.User_ID = UserID;
            User_ID = UserID;
            Password = clsUser_DB.FindUserPassword(User_ID);
        }
        private void tbCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbCurrentPass.Text != Password) 
            {
                erp.SetError(tbCurrentPass, "Enter Correct Password !");
                e.Cancel = true;
            }
            else
                erp.SetError(tbCurrentPass, "");
        }
        private void tbConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPass.Text != tbNewPass.Text)
            {
                erp.SetError(tbConfirmPass, "Password Confirmation Does Not Match Password !");
                e.Cancel = true;
            }
            else
                erp.SetError(tbConfirmPass, "");
        }
        private bool _IsTextNotNull()
        {
            return this.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsTextNotNull()) 
            {
                if (clsUser_DB.ChangeUserPassword(User_ID, tbNewPass.Text))
                {
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter the Data Correctly", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void chBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chBShowPass.Checked)
            {
                tbNewPass.PasswordChar = '\0';
                tbConfirmPass.PasswordChar = '\0';
                tbCurrentPass.PasswordChar = '\0';
            }
            else
            {
                tbNewPass.PasswordChar = '*';
                tbConfirmPass.PasswordChar = '*';
                tbCurrentPass.PasswordChar = '*';
            }
        }

    }
}
