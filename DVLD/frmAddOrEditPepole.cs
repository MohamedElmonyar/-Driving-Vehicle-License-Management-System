using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddOrEditPepole : Form
    {
        public delegate void DataBackPersonID(object sender, int PersonID);

        public event DataBackPersonID IDBack;
        private int _Person_ID;
        public frmAddOrEditPepole(int person_ID)
        {                       
            InitializeComponent();
            _Person_ID = person_ID;
            ctrnAddOrEditPerson1._Person_ID = _Person_ID;
        }

        private void frmAddOrEditPepole_FormClosing(object sender, FormClosingEventArgs e)
        {
            IDBack?.Invoke(this, ctrnAddOrEditPerson1._Person_ID);
        }

    }
}
