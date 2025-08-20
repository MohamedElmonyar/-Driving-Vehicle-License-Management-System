using DVLD_Businees;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageApplicationType : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        public frmManageApplicationType()
        {
            InitializeComponent();
        }
        private void _LoadDataIndvgManageApp() 
        {
            DataTable dtAppType = clsApplicationsTypes_DB.GetALLApplicationsTypes();
            bindingSource.DataSource = dtAppType;
            dgvAppType.DataSource = bindingSource;
            bindingSource.DataSource = dtAppType;
            dgvAppType.DataSource = bindingSource;
            laRecords.Text = (dgvAppType.RowCount - 1).ToString();
        }
        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            _LoadDataIndvgManageApp();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAppType frmEditApp = new frmEditAppType(Convert.ToInt16(_RowSelected.Cells[0].Value));
            frmEditApp.ShowDialog();
            if (frmEditApp.Saved)
                _LoadDataIndvgManageApp();
        }
        private void dgvAppType_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppType.ClearSelection();
                dgvAppType.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvAppType.Rows[e.RowIndex];
            }
        }


    }
}
