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
    public partial class frmShowApplicationDetails : Form
    {
        public frmShowApplicationDetails(int App_ID)
        {
            InitializeComponent();
            ctrnApplicationInfo1.AppLication_ID = App_ID;
        }

    }
}
