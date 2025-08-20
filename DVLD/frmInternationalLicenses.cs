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
    public partial class frmInternationalLicenses : Form
    {

        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; }
        public frmInternationalLicenses()
        {
            InitializeComponent();
        }
        public void _LoadDataIndvgInterLicenses()
        {
            tbFilter.TextChanged += _RowsCount;
            DataTable dtInternationalLicenseApp = clsInternationalLicense_DB.GetAllInternationalLicense();
            bindingSource.DataSource = dtInternationalLicenseApp;
            dgvInternationalLicenseApp.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            tbFilter.Text = string.Empty;
            laRecords.Text = (dgvInternationalLicenseApp.RowCount - 1).ToString();
        }
        private void _RowsCount(object sender, EventArgs e)
        {
            laRecords.Text = (dgvInternationalLicenseApp.Rows.Cast<DataGridViewRow>().Count(r => r.Visible) - 1).ToString();
        }

        private void _Filterdgv_Apps()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString().Trim().Replace(" ", "");
            _Filter = tbFilter.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(tbFilter.Text) || (cbFilter.SelectedIndex == 0))
                bindingSource.RemoveFilter();
            else
            {
              bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'"; 
            }

        }
        private void _FilterCb_IsActive(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 5 && cbIsActive.SelectedIndex != 0)
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
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 5)
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

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 5 && cbFilter.SelectedIndex != 0)
                _Filterdgv_Apps();

        }

        private void frmInternationalLicenses_Load(object sender, EventArgs e)
        {
            _LoadDataIndvgInterLicenses();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowInternationalLicenseInfo frmShowInternationalLicenseInfo = new frmShowInternationalLicenseInfo(RowSelected);
                frmShowInternationalLicenseInfo.ShowDialog();
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void showLicensePersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(-1,-1,RowSelected);
                frmShowLicenseHistory.ShowDialog();
            }
        }

        private void dgvInternationalLicenseApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternationalLicenseApp.ClearSelection();
                dgvInternationalLicenseApp.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvInternationalLicenseApp.Rows[e.RowIndex];
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
           _FilterCb_IsActive(sender, e);
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenses frmAddNewInternational  = new frmAddNewInternationalLicenses();
            frmAddNewInternational.ShowDialog();
            _LoadDataIndvgInterLicenses();
        }
    }
}
