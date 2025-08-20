using DVLD_Businees;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrnFindPerson : UserControl
    {
        public event Action<bool> OnPersonSelected;
        protected virtual void PersonSelected(bool Selected) 
        {
            Action<bool> handler = OnPersonSelected;
            if (handler != null )
                handler(Selected);
        }
        public int Person_ID { get; set; }
        public string NationalNo { get; set; }
        public ctrnFindPerson()
        {
            InitializeComponent();
        }
        public void LoadPersonData(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            tbFilter.Text= PersonID.ToString();
            Person_ID = PersonID;
            ctrnPI.LoadPersonData(PersonID);
            NationalNo = ctrnPI.NationalNumber;
            if (OnPersonSelected != null)            
                PersonSelected(true);          
            btnAddnew.Enabled = false;
            btnSearchPerson.Enabled = false;
            cbFilter.Enabled = false;
            tbFilter.Enabled = false;
            ctrnPI.Enabled = true;
        }
        private void LoadPersonData(object sender, int PersonID)
        {
            if (PersonID != -1)
            {
                cbFilter.SelectedIndex = 0;
                tbFilter.Text = PersonID.ToString();
                Person_ID = PersonID;
                ctrnPI.Enabled = true;
                ctrnPI.LoadPersonData(PersonID);
            }
        }
        private void btnSearchPerson_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFilter.Text) && cbFilter.SelectedIndex != -1)
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    if (clsPepole_DB.IsPersonExist(Convert.ToInt32(tbFilter.Text)))
                    {
                        ctrnPI.LoadPersonData(Convert.ToInt16(tbFilter.Text));
                        NationalNo = ctrnPI.NationalNumber;
                        Person_ID = Convert.ToInt16(tbFilter.Text);
                        ctrnPI.Enabled = true;
                        if (OnPersonSelected != null)
                            PersonSelected(true);
                    }
                    else
                    {
                        ctrnPI.LoadPersonData(-1);
                        MessageBox.Show("The Person Was Not Found.", "Search Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    if (clsPepole_DB.IsPersonExist(tbFilter.Text))
                    {
                        NationalNo = tbFilter.Text;
                        Person_ID = clsPepole_DB.FindPerson(NationalNo).Persone_ID;
                        ctrnPI.LoadPersonData(Person_ID);
                        ctrnPI.Enabled = true;
                        if (OnPersonSelected != null)
                            PersonSelected(true);
                    }
                    else
                    {
                        ctrnPI.LoadPersonData(-1);
                        MessageBox.Show("The Person Was Not Found", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
        }
        private void btnAddnew_Click_1(object sender, EventArgs e)
        {
            frmAddOrEditPepole frmAddOrEditPepole = new frmAddOrEditPepole(-1);
            frmAddOrEditPepole.IDBack += LoadPersonData;
            frmAddOrEditPepole.ShowDialog();
        }
        private void tbFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void ctrnFindPerson_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }



    }
}
