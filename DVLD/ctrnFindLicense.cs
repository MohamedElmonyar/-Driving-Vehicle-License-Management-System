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
    public partial class ctrnFindLicense : UserControl
    {

        public bool IsSearched { get; set; } = false;

        public event Action<bool> OnLicenseSelected;
        protected virtual void LicenseSelected(bool Selected)
        {
            Action<bool> handler = OnLicenseSelected;
            if (handler != null)
                handler(Selected);
        }

        public event Action<bool> OnLicenseSelectetion;
        protected virtual void LicenseSelection(bool Selected)
        {
            Action<bool> handler = OnLicenseSelected;
            if (handler != null)
                handler(Selected);
        }
        enum enMode { Search,UnSearch}
        private enMode CurrentMode = enMode.UnSearch;
        public int LocalApplication_ID { set; get; }
        public int License_ID { set; get; } = -1;
        public ctrnFindLicense()
        {
            InitializeComponent();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                MessageBox.Show("Enter A Valid License ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LicenseSelected(false);
                return;
            }
            this.License_ID = Convert.ToInt32(tbFilter.Text.Trim().Replace(" ",""));
            if (clsLicense_DB.IsLicenseExist(License_ID))
            {
                IsSearched = true;
                ctrnLicenseInfo1.LoadDataLicense(License_ID);
                if (OnLicenseSelected != null)
                    LicenseSelected(true);
            }
            else
            {
                if (OnLicenseSelected != null)
                    LicenseSelected(false);
                MessageBox.Show("Enter A Correct License ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
                
            
              IsSearched = false;
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void _CheckMode() 
        {
            if (this.License_ID != -1 && this.License_ID != 0)
                this.CurrentMode = enMode.UnSearch;
            else
                this.CurrentMode = enMode.Search;
        }
        private void TurnOffSearchMode()
        {
            this.tbFilter.Enabled = false;
            this.btnSearchPerson.Enabled = false;
            this.IsSearched = true;
            tbFilter.Text = License_ID.ToString();
        }
        private void ctrnFindLicense_Load(object sender, EventArgs e)
        {
            _CheckMode();
            if (this.CurrentMode == enMode.UnSearch)
            {
                TurnOffSearchMode();
                LicenseSelected(true);               
                ctrnLicenseInfo1.LoadDataLicense(this.License_ID);
            }
        }

    }
}
