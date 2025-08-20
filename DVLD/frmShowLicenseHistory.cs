using DVLD_Businees;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowLicenseHistory : Form
    {
        int LocalAppID { set; get; }
        int Person_ID { set; get; }
        public frmShowLicenseHistory(int LocalApp_ID = -1,int PersonID =-1,int InterLicense_ID =-1,int License_ID =-1)
        {
            InitializeComponent();
            if (InterLicense_ID != -1)
                this.Person_ID = clsPepole_DB.FindPersonByInterLicenseID(InterLicense_ID);
            else if (License_ID != -1)
                this.Person_ID = clsPepole_DB.FindPersonByLicenseID(License_ID);
            else if (PersonID == -1 && LocalApp_ID != -1)
                this.Person_ID = clsPepole_DB.FindPersonByLocalApp(LocalApp_ID);
          
            else
                this.Person_ID = PersonID;
                this.ctrnLocalLicenses1.Person_ID = this.Person_ID;
        }

        private void frmShowLicenseHistory_Load(object sender, System.EventArgs e)
        {
            ctrnFindPerson1.LoadPersonData(Person_ID);
        }
    }
}
