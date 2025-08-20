using DVLD_Businees;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DVLD
{
    public partial class frmTestsAppointment : Form
    {
        public delegate void DataBackNotification(object sender);

        public event DataBackNotification Notification;
        private int App_ID { get; set; }
        private int Appointment_ID;
        private DataGridViewRow _RowSelected;
        private int Person_ID { get; set; }
        static public string ImageVision = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\eye.png";
        static public string ImageStreet = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\motorway.png";
        static public string ImageWritten = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\writing.png";
        private string _TestTypeTitle { get; set; }

        clsAppointment_DB _oAppointment = new clsAppointment_DB();
        public enum eAppointmentType {Vision,Written,Street};
        eAppointmentType _eAppointmen;
        public frmTestsAppointment(int AppID,eAppointmentType eAppointmenType)
        {
            InitializeComponent();
            this.App_ID = AppID;
            this._eAppointmen = eAppointmenType; 
            ctrnApplicationInfo1.AppLication_ID = this.App_ID;
            _Checkenum();
        }
        private void _Checkenum() 
        {
            switch (_eAppointmen) 
            {
               case eAppointmentType.Vision:
                    this.Text = "Vision Test Appointment";
                    _TestTypeTitle = "Vision Test";
                    pbTests.Image = Image.FromFile(ImageVision);
                    break;
                case eAppointmentType.Written:
                    this.Text = "Written Test Appointment";
                    _TestTypeTitle = "written (Theory) Test";
                    pbTests.Image = Image.FromFile(ImageWritten);
                    break;
                case eAppointmentType.Street:
                    this.Text = "Street Test Appointment";
                    _TestTypeTitle = "Practical (Street) Test";
                    pbTests.Image = Image.FromFile(ImageStreet);
                    break;
                default:
                    break;
            }
       
        }
        private void _LoadDataIn_dgvAppointment(object sender ) 
        {
            dgvAppointment.DataSource = clsAppointment_DB.FindAppointmentInformation(ctrnApplicationInfo1.Person_ID,ctrnApplicationInfo1.ClassName,_TestTypeTitle);
        }
        private void _LoadData(object sender)
        {
            _LoadDataIn_dgvAppointment(sender);            
        }
        private void frmTestsAppointment_Load(object sender, EventArgs e)
        {
            _LoadData(sender);
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (clsAppointment_DB.IsPassed(App_ID, _TestTypeTitle)) 
            {
                MessageBox.Show("This Person Has Already Passed This Test", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsAppointment_DB.DidHaveAppointmentActive(ctrnApplicationInfo1.Person_ID, ctrnApplicationInfo1.ClassName, _TestTypeTitle))
            {
                MessageBox.Show("Person Already Have An Active Appointment For This Test\nYou " +
                       "Cannot Add New Appointment", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsAppointment_DB.IsAppointmentRetakeTest(ctrnApplicationInfo1.Person_ID, ctrnApplicationInfo1.ClassName, _TestTypeTitle,ref this.Appointment_ID))
                {
                  
                        frmAddAppointment oAddAppointment = new frmAddAppointment(Appointment_ID, ctrnApplicationInfo1.LocalApp_ID, clsAppointment_DB._enMode.Retake, _eAppointmen);
                        oAddAppointment.Notification += _LoadDataIn_dgvAppointment;
                        oAddAppointment.Notification += ctrnApplicationInfo1._LoadData;
                        oAddAppointment.ShowDialog();
                    
                  
                }
                else
                {
                    frmAddAppointment oAddAppointment = new frmAddAppointment(-1, ctrnApplicationInfo1.LocalApp_ID, clsAppointment_DB._enMode.Add, _eAppointmen);
                    oAddAppointment.Notification += _LoadDataIn_dgvAppointment;
                    oAddAppointment.Notification += ctrnApplicationInfo1._LoadData;
                    oAddAppointment.ShowDialog();

                }
            
            }
        }
        private void dgvAppointment_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppointment.ClearSelection();
                dgvAppointment.Rows[e.RowIndex].Selected = true;
                _RowSelected = dgvAppointment.Rows[e.RowIndex];
            }
            if (_RowSelected != null && _RowSelected?.Cells[5]?.Value != null &&
    bool.TryParse(_RowSelected.Cells[5].Value.ToString(), out bool IsLocked))
            {
                if (IsLocked)
                    takeTestToolStripMenuItem.Enabled = false;
                else
                    takeTestToolStripMenuItem.Enabled = true;
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_RowSelected?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
               if(_RowSelected?.Cells[5]?.Value != null && bool.TryParse(_RowSelected.Cells[5].Value.ToString(), out bool IsLocked))
                {
                    frmAddAppointment oAddAppointment = new frmAddAppointment(RowSelected, ctrnApplicationInfo1.LocalApp_ID, clsAppointment_DB._enMode.Update, _eAppointmen, IsLocked);
                    oAddAppointment.Notification += _LoadDataIn_dgvAppointment;
                    oAddAppointment.ShowDialog();
                }
            }
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_RowSelected?.Cells[0]?.Value != null &&
            int.TryParse(_RowSelected.Cells[0].Value.ToString(), out int RowSelected))
            {
              frmTakeTest frmTakeTest = new frmTakeTest(RowSelected, ctrnApplicationInfo1.LocalApp_ID, _eAppointmen);
                frmTakeTest.Notification += _LoadDataIn_dgvAppointment;
                frmTakeTest.Notification += ctrnApplicationInfo1._LoadData;
                frmTakeTest.ShowDialog();
            }
        }
        private void frmTestsAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Notification?.Invoke(this);
        }


    }
}
