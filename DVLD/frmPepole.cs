using DVLD_Businees;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPepole : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; } 
        public frmPepole()
        {
            InitializeComponent();
        }
        private void _LoadData() 
        {
            tbFilter.TextChanged += _RowsCount;
            DataTable dataTable = clsPepole_DB.GetAllPepole(); 
            bindingSource.DataSource = dataTable;
            dgvPepole.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
            tbFilter.Text = string.Empty;
            laRecords.Text = (dgvPepole.RowCount-1).ToString();
        }
        private void frmPepole_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmAddOrEditPepole persone = new frmAddOrEditPepole(-1);
            persone.ShowDialog();
            _LoadData();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected != null)
            {
                frmPersonDetails frmPersonDetails = new frmPersonDetails(Convert.ToInt16(_RowSelected.Cells[0].Value));
                frmPersonDetails.ShowDialog();
            }
           
        }
        private void dgvPepole_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvPepole.ClearSelection();
                dgvPepole.Rows[e.RowIndex].Selected = true;               
                _RowSelected = dgvPepole.Rows[e.RowIndex];
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected != null)
            {
                frmAddOrEditPepole persone = new frmAddOrEditPepole(Convert.ToInt16(_RowSelected.Cells[0].Value));
                persone.ShowDialog();
                _LoadData();
            }
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddnew_Click(sender,e);
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void _FilterGridView()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString();
            _Filter = tbFilter.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(cbFilter.Text) || (cbFilter.SelectedIndex == 0))
            {
                bindingSource.RemoveFilter();
            }
            else if (cbFilter.SelectedIndex != 0 && !string.IsNullOrEmpty(tbFilter.Text))
            {
                if (cbFilter.SelectedIndex == 1 || cbFilter.SelectedIndex == 8)
                    bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
                else if (cbFilter.SelectedIndex == 7)
                {
                    DateTime.TryParse(tbFilter.Text, out DateTime date);
                    bindingSource.Filter = $"[DateOfBirth] = #{date:MM/dd/yyyy}#";
                }
                else if (cbFilter.SelectedIndex != 1)
                    bindingSource.Filter = $"[{_SelectedItem}] LIKE '%{tbFilter.Text.ToString()}%'";
            }
            else
                bindingSource.RemoveFilter();
        }
        private void _ChecktbFiltersVisible(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 0)
                tbFilter.Visible = true;
            else
                tbFilter.Visible = false;
            tbFilter.Text = string.Empty;
        }
        private void _Filters(object sender, EventArgs e) 
        {           
           _FilterGridView();
        }
        private void _RowsCount(object sender, EventArgs e) 
        {
            laRecords.Text = (dgvPepole.Rows.Cast<DataGridViewRow>().Count(r => r.Visible)-1).ToString();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected != null)
            {
                if (MessageBox.Show("Are You Sure You Want Delete This Person ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsPepole_DB.DeletePerson(Convert.ToInt32(_RowSelected.Cells[0].Value)))
                    {
                        MessageBox.Show("Person Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadData();
                    }
                    else
                        MessageBox.Show("This Person Is Tied To Other Things In The System.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
