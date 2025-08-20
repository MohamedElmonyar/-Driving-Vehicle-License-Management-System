using DVLD_Businees;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUsers : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; }
        public frmUsers()
        {
            InitializeComponent();
        }
        private void _RowsCount(object sender, EventArgs e)
        {
            laRecords.Text = (dgvUsers.Rows.Cast<DataGridViewRow>().Count(r => r.Visible) - 1).ToString();
        }
        public void _LoadDataIndvgUsers() 
        {
            tbFilter.TextChanged += _RowsCount;
            DataTable dtUsers = clsUser_DB.GetAllUsers();
            bindingSource.DataSource = dtUsers;
            dgvUsers.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            tbFilter.Text = string.Empty;
            laRecords.Text = (dgvUsers.RowCount - 1).ToString();
        }
        private void _Filterdgv_Users()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString();
            _Filter = tbFilter.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(tbFilter.Text) || (cbFilter.SelectedIndex == 0 && !tbFilter.Visible))
                bindingSource.RemoveFilter();
            else if (cbFilter.SelectedIndex != 0 && !string.IsNullOrEmpty(tbFilter.Text))
            {
                if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2)
                    bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
                else
                    bindingSource.Filter = $"[{_SelectedItem}] LIKE '%{tbFilter.Text.ToString()}%'";
            }
            else
                bindingSource.RemoveFilter();
        }
        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUsers.ClearSelection();
                dgvUsers.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvUsers.Rows[e.RowIndex];
            }
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            _LoadDataIndvgUsers();
        }
        private void _FiltersOf_TextFilter(object sender, EventArgs e)
        {
            _Filterdgv_Users();
        }
        private void _FilterCb_IsActive(object sender, EventArgs e) 
        {
            
            if (cbFilter.SelectedIndex == 6 && cbIsActive.SelectedIndex != 0)
            {
                _SelectedItem = cbFilter.SelectedItem?.ToString();
                _Filter = cbIsActive.SelectedItem?.ToString().Trim().Replace("'", "''");
                bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
            }
            else 
                bindingSource.RemoveFilter();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 6)
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
            if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected?.Cells[0]?.Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmUserDetails frmUser = new frmUserDetails(RowSelected);
                frmUser.ShowDialog();
            }
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddnew_Click(sender,e);
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frmAddOrEdit = new frmAddOrEditUser(-1,-1);
            frmAddOrEdit.ShowDialog();
            if (frmAddOrEdit._Saved)
                _LoadDataIndvgUsers();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmAddOrEditUser frmUser = new frmAddOrEditUser(Convert.ToInt16(RowSelected), Convert.ToInt16(_RowSelected.Cells[1].Value));

                frmUser.ShowDialog();

                if (frmUser._Saved)
                    _LoadDataIndvgUsers();
            }
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword(Convert.ToInt16(_RowSelected.Cells[0].Value));
            frmChange.ShowDialog();
            _LoadDataIndvgUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected?.Cells[1]?.Value != null &&
            int.TryParse(_RowSelected.Cells[1].Value.ToString(), out int RowSelected))
            {
                if (MessageBox.Show("Are You Sure You Want Delete This User ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsPepole_DB.DeletePerson(RowSelected))
                    {
                        MessageBox.Show("User Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadDataIndvgUsers();
                    }
                    else
                        MessageBox.Show("This User Is Tied To Other Things In The System.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
