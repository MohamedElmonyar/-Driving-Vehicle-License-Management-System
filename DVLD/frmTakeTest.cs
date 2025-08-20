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
using static DVLD.frmTestsAppointment;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {

        public delegate void DataBackNotification(object sender);

        public event DataBackNotification Notification;
        int _Appointment_ID { set; get; }
        int LocalApp_ID { set; get; }

        int TestType_ID { get; set; }
        eAppointmentType _eAppointmen;
        clsAppointment_DB _oAppointment = new clsAppointment_DB();
        clsTests_DB _oTest = new clsTests_DB();
        public frmTakeTest(int Appointment_ID,int LocalApp_ID,frmTestsAppointment.eAppointmentType eAppointment)
        {
            InitializeComponent();
            this._eAppointmen = eAppointment;
            this._Appointment_ID = Appointment_ID;
            this.LocalApp_ID = LocalApp_ID;
            this._oTest._Mode = clsTests_DB.enMode.Add;
        }
        private void _CheckTest()
        {
            switch (_eAppointmen)
            {
                case eAppointmentType.Vision:
                    this.laTitle.Text = "Vision Test";
                    this.TestType_ID = 1;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageVision);
                    break;
                case eAppointmentType.Written:
                    this.laTitle.Text = "Written Test";
                    this.TestType_ID = 2;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageWritten);
                    break;
                case eAppointmentType.Street:
                    this.laTitle.Text = "Street Test";
                    this.TestType_ID = 3;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageStreet);
                    break;
                default:
                    break;
            }
        }
        private void _LoadAppDetails(clsAppointment_DB oAppointment)
        {
            if (oAppointment == null) return;
            laName.Text = oAppointment.PersonName;
            laAppID.Text = this.LocalApp_ID.ToString();
            laClassName.Text = oAppointment.ClassName;
            laTrial.Text = oAppointment.Trial.ToString();
            laFees.Text = oAppointment.PaidFees.ToString();
            if (oAppointment.Appointment_Date != null)
                laDate.Text = oAppointment.Appointment_Date.ToString();
            rbPass.Checked = true;
        }
        private void _LoadDataIn_Controls()
        {
            _oAppointment = clsAppointment_DB.FindTestAppointment(_Appointment_ID, TestType_ID, this._oAppointment._Mode);
            _LoadAppDetails(_oAppointment);
        }
        private void _LoadDataIn_oTest() 
        {
            _oTest.Result = rbPass.Checked;
            if (!string.IsNullOrEmpty(tbNotes.Text))
            _oTest.Notes = tbNotes.Text;
            else
                _oTest.Notes = string.Empty;
            _oTest.TestAppointment_ID = _Appointment_ID;
            _oTest.User_ID = clsUser_DB.CurrentUser.User_ID;
        }
        private void LoadData() 
        {
            _CheckTest();
            _LoadDataIn_Controls();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoadDataIn_oTest();
            if (_oTest.Save())
            {
                laTestID.Text = _oTest.Test_ID.ToString();
                MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Notification?.Invoke(this);
                _oTest._Mode = clsTests_DB.enMode.Update;
            }
            else
                MessageBox.Show("Saved failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}
