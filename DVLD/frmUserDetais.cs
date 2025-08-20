using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUserDetails : Form
    {

        public frmUserDetails(int UserID)
        {
            InitializeComponent();
            ctrnUserDetails1.User_ID= UserID;
        }


    }
}
