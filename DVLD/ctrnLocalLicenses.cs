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
    public partial class ctrnLocalLicenses : UserControl
    {
        public int Person_ID { set; get; }
        private DataGridViewRow _RowSelected1;
        private DataGridViewRow _RowSelected2;
        public ctrnLocalLicenses()
        {
            InitializeComponent();
        }
        private void ctrnLocalLicenses_Load(object sender, EventArgs e)
        {
            dgvLocalLicenseApp.DataSource = clsLicense_DB.GetAllLocalLicenseToPerson(Person_ID);
            dgvInternational.DataSource = clsLicense_DB.GetAllInternationalLicenseToPerson(Person_ID);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_RowSelected1?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected1.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(RowSelected);
                frm.ShowDialog();

            }
        }

        private void dgvInternational_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternational.ClearSelection();
                dgvInternational.Rows[e.RowIndex].Selected = true;
                _RowSelected1 = dgvInternational.Rows[e.RowIndex];
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(_RowSelected2?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected2.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowLicense frmShowLicense = new frmShowLicense(-1,-1, RowSelected);
                frmShowLicense.ShowDialog();

            }
        }

        private void dgvLocalLicenseApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvLocalLicenseApp.ClearSelection();
                dgvLocalLicenseApp.Rows[e.RowIndex].Selected = true;
                _RowSelected2 = dgvLocalLicenseApp.Rows[e.RowIndex];
            }
        }
    }
}
