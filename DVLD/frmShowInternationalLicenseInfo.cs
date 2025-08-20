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
    public partial class frmShowInternationalLicenseInfo : Form
    {
        int InternationalLicense_ID { set; get; }
        public frmShowInternationalLicenseInfo(int InternationalLicense_ID)
        {
            InitializeComponent();
            this.InternationalLicense_ID = InternationalLicense_ID;
            ctrnInternationalLicenseInfo1.InternationalLicense_ID = InternationalLicense_ID;
        }
    }
}
