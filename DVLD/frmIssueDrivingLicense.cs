using DVLD_Businees;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmIssueDrivingLicense : Form
    {
        int LocalApp_ID { get; set; }
        clsLicense_DB oLicense = new clsLicense_DB();
        public frmIssueDrivingLicense(int LocalApp_ID)
        {
            InitializeComponent();
            this.ctrnApplicationInfo1.AppLication_ID = LocalApp_ID;
            this.LocalApp_ID = LocalApp_ID;
        }
        private void _StoreDataInoLicense()
        {
            oLicense.Notes = tbNotes.Text;
            oLicense.LocalDrivingLicense_ID = LocalApp_ID;
        }
        private void btnIssue_Click(object sender, System.EventArgs e)
        {
            _StoreDataInoLicense();
            if (oLicense.Save())                          
                MessageBox.Show("License Issued Successfully With License ID = " + oLicense.License_ID, "Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
