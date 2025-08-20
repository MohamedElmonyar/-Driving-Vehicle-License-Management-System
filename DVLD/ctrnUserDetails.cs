using DVLD_Businees;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrnUserDetails : UserControl
    {
        public int User_ID {get;set;}

        clsUser_DB clsUser = new clsUser_DB();
        public ctrnUserDetails()
        {
            InitializeComponent();
        }

        private string _CheckActive(bool Active) 
        {
            return (Active) ? "Yes" : "No";
        }
        private void _FillDataInControl(clsUser_DB user_DB) 
        {
            if (user_DB != null)
            {
                laUserID.Text = user_DB.User_ID.ToString();
                laUserName.Text = user_DB.UserName;
                laActive.Text = _CheckActive(user_DB.IsActive);
                ctrnPersonDetails1.LoadPersonData(user_DB.Person_ID);
            }
            else 
            {
                laUserID.Text = "[???]";
                laUserName.Text = "[???]";
                laActive.Text = "[???]";
                ctrnPersonDetails1.LoadPersonData(-1);
            }
        }
        public void _LoadData() 
        {
            clsUser = clsUser_DB.FindUser(User_ID);
            _FillDataInControl(clsUser);
        }
        private void ctrnUserDetails_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


    }
}
