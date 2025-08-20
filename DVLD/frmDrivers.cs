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
    public partial class frmDrivers : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; }

        public frmDrivers()
        {
            InitializeComponent();
        }

        private void _RowsCount()
        {
            laRecords.Text = (dgvDrivers.Rows.Cast<DataGridViewRow>().Count(r => r.Visible) - 1).ToString();
        }
        private void _LoadDataIndgv_Drivers() 
        {
            DataTable dtDrivers = clsDriver_DB.GetAllDriver();
            bindingSource.DataSource = dtDrivers;
            dgvDrivers.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
        } 
        private void _Filterdgv_Drivers()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString();
            _Filter = tbFilter.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrEmpty(tbFilter.Text))
            {
                if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 5)
                    bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
                else
                    bindingSource.Filter = $"[{_SelectedItem}] LIKE '%{tbFilter.Text.ToString()}%'";
            }
            else
                bindingSource.RemoveFilter();
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _Filterdgv_Drivers();
            _RowsCount();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
                tbFilter.Visible = false;
            else
                tbFilter.Visible = true;
            tbFilter.Text = string.Empty;
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 5)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void dgvDrivers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDrivers.ClearSelection();
                dgvDrivers.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvDrivers.Rows[e.RowIndex];
            }
        }
        private void _LoadData() 
        {     
            _LoadDataIndgv_Drivers();
            _RowsCount();
        }
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[1].Value != null && int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
               frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(-1,RowSelected);
                frmShowLicenseHistory.ShowDialog();

            }
        }

    }
}
