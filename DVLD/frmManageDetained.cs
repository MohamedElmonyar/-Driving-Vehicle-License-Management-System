using DVLD_Businees;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageDetained : Form
    {

        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; }
        private int Person_ID { set; get; } 
        public frmManageDetained()
        {
            InitializeComponent();
        }
        private void _RowsCount(object sender, EventArgs e)
        {
            laRecords.Text = (dgvDetainedLicenses.Rows.Cast<DataGridViewRow>().Count(r => r.Visible) - 1).ToString();
        }
        private void _LoadData()
        {
            tbFilter.TextChanged += _RowsCount;
            DataTable dtDetainedLicenses = clsLicense_DB.GetDetainedLicenses();
            bindingSource.DataSource = dtDetainedLicenses;
            dgvDetainedLicenses.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
            tbFilter.Text = string.Empty;
            cbIsActive.SelectedIndex = 0;
            laRecords.Text = (dgvDetainedLicenses.RowCount - 1).ToString();
        }
        private void _Filterdgv_DetainedLicenses()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString().Trim().Replace(" ", "");
            _Filter = tbFilter.Text.Trim().Replace(" ", "");

            if (string.IsNullOrEmpty(tbFilter.Text) || (cbFilter.SelectedIndex == 0))
                bindingSource.RemoveFilter();
            else
            {
                if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 3 || cbFilter.SelectedIndex == 7)
                    bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
                else
                    bindingSource.Filter = $"[{_SelectedItem}] LIKE '%{tbFilter.Text.ToString()}%'";
            }

        }
        private void frmManageDetained_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _CheckIsDetained() 
        {
            if (_RowSelected?.Cells[1]?.Value != null &&
         int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
                if (!clsLicense_DB.IsLicenseDetained(RowSelected))
                    ReleaseDetainedToolStripMenuItem.Enabled = false;
                else
                    ReleaseDetainedToolStripMenuItem.Enabled = true;
            }  
        }
        private void dgvDetainedLicenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDetainedLicenses.ClearSelection();
                dgvDetainedLicenses.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvDetainedLicenses.Rows[e.RowIndex];
            }
            Person_ID = clsPepole_DB.FindPersonByLicenseID(Convert.ToInt32(_RowSelected.Cells[1].Value));
            _CheckIsDetained();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 4)
            {
                cbIsActive.Visible = true;
                tbFilter.Visible = false;
            }
            else if (cbFilter.SelectedIndex != 0)
            {
                cbIsActive.Visible = false;
                tbFilter.Visible = true;
            }
            else
            {
                bindingSource.RemoveFilter();
                cbIsActive.Visible = false;
                tbFilter.Visible = false;
            }
            tbFilter.Text = string.Empty;
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 3 || cbFilter.SelectedIndex == 7)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void _FilterCb_IsActive(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 4 && cbIsActive.SelectedIndex != 0)
            {
                _SelectedItem = cbFilter.SelectedItem?.ToString().Trim().Replace(" ", ""); ;
                _Filter = cbIsActive.SelectedItem?.ToString().Trim().Replace(" ", "");

                if (_Filter == "Yes")
                    bindingSource.Filter = $"[{_SelectedItem}] = true";
                else if (_Filter == "No")
                    bindingSource.Filter = $"[{_SelectedItem}] = false";
            }
            else
                bindingSource.RemoveFilter();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterCb_IsActive(sender, e);
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 4 && cbFilter.SelectedIndex != 0)
                _Filterdgv_DetainedLicenses();
        }
        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[1].Value != null && int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
                frmShowLicense frmShowLicense = new frmShowLicense(-1,-1, RowSelected);
                frmShowLicense.ShowDialog();
            }
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[1].Value != null && int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
                frmPersonDetails frmPersonDetails = new frmPersonDetails(Person_ID);
                frmPersonDetails.ShowDialog();
            }
        }
        private void ShowPersonLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(-1,Person_ID, -1);
                frmShowLicenseHistory.ShowDialog();
            }
        }
        private void ReleaseDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[1].Value != null && int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
                frmReleaseLicense frmReleaseLicense = new frmReleaseLicense(RowSelected);
                frmReleaseLicense.ShowDialog();
                _LoadData();
            }
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense();
            frmDetainLicense.ShowDialog();
                _LoadData();

        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense();          
            frmReleaseLicense.ShowDialog();
                _LoadData();
        }


    }
}
