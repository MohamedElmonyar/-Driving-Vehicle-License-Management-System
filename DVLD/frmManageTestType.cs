using DVLD_Businees;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageTestType : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;

        public frmManageTestType()
        {
            InitializeComponent();
        }
        private void _LoadDataIndvgManageTests()
        {
            DataTable dtTests = clsTestsTypes_DB.GetAllTests();
            bindingSource.DataSource = dtTests;
            dgvTests.DataSource = bindingSource;
            bindingSource.DataSource = dtTests;
            dgvTests.DataSource = bindingSource;
            laRecords.Text = (dgvTests.RowCount - 1).ToString();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmEditTests frmEditTest = new frmEditTests(RowSelected);
                frmEditTest.ShowDialog();
                if (frmEditTest.Saved)
                    _LoadDataIndvgManageTests();
            }
         
        }
        private void dgvTests_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvTests.ClearSelection();
                dgvTests.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvTests.Rows[e.RowIndex];
            }
        }
        private void frmManageTestType_Load(object sender, EventArgs e)
        {
            _LoadDataIndvgManageTests();
        }

    
    }
}
