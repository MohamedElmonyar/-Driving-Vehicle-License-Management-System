using DVLD_Businees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowLicense : Form
    {
        int LocalApp_ID { set; get; }
        public frmShowLicense(int LocalApp_ID = -1,int PersonID = -1,int License_ID = -1)
        {
            InitializeComponent();
            if (License_ID != -1)
                ctrnLicenseInfo1.LoadDataLicense(License_ID);
            else if (PersonID == -1 && LocalApp_ID != -1)
                this.LocalApp_ID = LocalApp_ID;
            ctrnLicenseInfo1.LocalLicenseApp_ID = this.LocalApp_ID;
        }



    }
}
