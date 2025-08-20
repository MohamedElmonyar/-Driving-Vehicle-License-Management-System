using DVLD_Businees;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDrivingLicenseApp : Form
    {
        BindingSource bindingSource = new BindingSource();
        private DataGridViewRow _RowSelected;
        private string _SelectedItem { set; get; }
        private string _Filter { set; get; }
        public frmLocalDrivingLicenseApp()
        {
            InitializeComponent();
        }
        private void _RowsCount(object sender, EventArgs e)
        {
            laRecords.Text = (dgvLocalLicenseApp.Rows.Cast<DataGridViewRow>().Count(r => r.Visible) - 1).ToString();
        }
        private void _LoadData()
        {
            tbFilter.TextChanged += _RowsCount;
            DataTable dtUsers = clsLocalLicenses_DB.GetAllLocalLicensesApp() ;
            bindingSource.DataSource = dtUsers;
            dgvLocalLicenseApp.DataSource = bindingSource;
            cbFilter.SelectedIndex = 0;
            tbFilter.Text = string.Empty;
            laRecords.Text = (dgvLocalLicenseApp.RowCount - 1).ToString();
        }
        private void _Filterdgv_Apps()
        {
            _SelectedItem = cbFilter.SelectedItem?.ToString().Trim().Replace(" ","");
            _Filter = tbFilter.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(tbFilter.Text) || (cbFilter.SelectedIndex == 0))
                bindingSource.RemoveFilter();
            else
            {
                if (cbFilter.SelectedIndex == 5 || cbFilter.SelectedIndex == 1)
                    bindingSource.Filter = $"[{_SelectedItem}] = '{_Filter}'";
                else
                    bindingSource.Filter = $"[{_SelectedItem}] LIKE '%{tbFilter.Text.ToString()}%'";
            }

        }
        private void frmLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmAddOrEditLocalLicenseApp frmNewLocal = new frmAddOrEditLocalLicenseApp(-1);
            frmNewLocal.IDBack += (s, id) => _LoadData();
            frmNewLocal.ShowDialog();          
        }
        private void TurnControls(bool TurnOn) 
        {
            if (TurnOn)
            {
                showToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                CancelApplicationToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                SecduleTestToolStripMenuItem.Enabled = true;
                IssueToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
            }
            else 
            {
                showToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                CancelApplicationToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                SecduleTestToolStripMenuItem.Enabled = false;
                IssueToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            }


        }
        private void DisableTests() 
        {
            sechduleVisionTestToolStripMenuItem.Enabled = false;
            sechduleWrittenTestToolStripMenuItem.Enabled = false;
            sechduleStreettTestToolStripMenuItem.Enabled = false;
            IssueToolStripMenuItem.Enabled = false;
        } 
        private void _CheckTestPassed()
        {
            DisableTests();
            if (!clsAppointment_DB.CheckTest(Convert.ToInt32(_RowSelected.Cells[0].Value), _RowSelected.Cells[1].Value.ToString(), "Vision Test"))
            {
                sechduleVisionTestToolStripMenuItem.Enabled = true;
                return ;
            }

            if (!clsAppointment_DB.CheckTest(Convert.ToInt32(_RowSelected.Cells[0].Value), _RowSelected.Cells[1].Value.ToString(), "written (Theory) Test"))
            {
                sechduleWrittenTestToolStripMenuItem.Enabled = true;
                return ;
            }

            if (!clsAppointment_DB.CheckTest(Convert.ToInt32(_RowSelected.Cells[0].Value), _RowSelected.Cells[1].Value.ToString(), "Practical (Street) Test"))
            {
                sechduleStreettTestToolStripMenuItem.Enabled = true;
                return ;
            }              
            SecduleTestToolStripMenuItem.Enabled = false;
            IssueToolStripMenuItem.Enabled = true;

        }
        private void Completed() 
        {
            editToolStripMenuItem.Enabled = false;
            CancelApplicationToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            SecduleTestToolStripMenuItem.Enabled = false;
            IssueToolStripMenuItem.Enabled = false;
        }
        private void Cancelled()
        {
            editToolStripMenuItem.Enabled = false;
            CancelApplicationToolStripMenuItem.Enabled = false;
            SecduleTestToolStripMenuItem.Enabled = false;
            IssueToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
        }
        private void New() 
        {
            IssueToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            _CheckTestPassed();
        }
        private void dgvLocalLicenseApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvLocalLicenseApp.ClearSelection();
                dgvLocalLicenseApp.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvLocalLicenseApp.Rows[e.RowIndex];
            }
            TurnControls(true);
            if (_RowSelected?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                if (clsApplication_DB.IsApplicationCompleted(RowSelected))
                    Completed();
                else if (clsApplication_DB.IsApplicationNew(RowSelected))
                    New();
                else
                    Cancelled();
            }
            else            
                TurnControls(false);
            
        }         
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                tbFilter.Visible = false;
                bindingSource.RemoveFilter();
            }
            else
                tbFilter.Visible = true;       
            tbFilter.Text = string.Empty;
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            _Filterdgv_Apps();
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 5 || cbFilter.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmAddOrEditLocalLicenseApp addOrEditLocalLicenseApp = new frmAddOrEditLocalLicenseApp(RowSelected);
                addOrEditLocalLicenseApp.ShowDialog();
                if (addOrEditLocalLicenseApp.Saved)
                    _LoadData();
            }
        }
        private void CancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Canel This Application", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
                {
                    if (clsLocalLicenses_DB.CancelLocalLicenseApp(RowSelected))
                    {
                        MessageBox.Show("Application Canceled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadData();
                    }
                    else
                        MessageBox.Show("Failed To Cancel The Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Application", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
                {
                    if (clsLocalLicenses_DB.DeleteLocalLicenseApp(RowSelected))
                    {
                        MessageBox.Show("Application Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadData();
                    }
                    else
                        MessageBox.Show("Failed Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmTestsAppointment frmTests = new frmTestsAppointment(RowSelected,frmTestsAppointment.eAppointmentType.Vision);
                frmTests.Notification += (s) => _LoadData();
                frmTests.ShowDialog();
            }
            
        }
        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmTestsAppointment frmTests = new frmTestsAppointment(RowSelected, frmTestsAppointment.eAppointmentType.Written);
                frmTests.Notification += (s) => _LoadData();
                frmTests.ShowDialog();
            }
        }
        private void sechduleStreettTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmTestsAppointment frmTests = new frmTestsAppointment(RowSelected, frmTestsAppointment.eAppointmentType.Street);
                frmTests.Notification += (s) => _LoadData();
                frmTests.ShowDialog();
            }
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmShowApplicationDetails showApplicationDetails = new frmShowApplicationDetails(RowSelected);
                showApplicationDetails.ShowDialog();
            }
        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
                frmIssueDrivingLicense frmIssueDrivingLicense = new frmIssueDrivingLicense(RowSelected);    
                frmIssueDrivingLicense.ShowDialog();
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
               frmShowLicense frmShowLicense = new frmShowLicense(RowSelected,-1);
                frmShowLicense.ShowDialog();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected.Cells[0].Value != null && int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
               frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(RowSelected,-1);
                frmShowLicenseHistory.ShowDialog();
            }
        }
    }
}
