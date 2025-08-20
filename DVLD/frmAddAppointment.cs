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
    public partial class frmAddAppointment : Form
    {
        public delegate void DataBackNotification(object sender);

        public event DataBackNotification Notification;
        int Appointment_ID { get; set; }
        int PaidFees { get; set; }
        bool IsLocked { get; set; }
        int TestType_ID { get; set; }
        int LocalApp_ID { get; set; }

        clsAppointment_DB _oAppointment = new clsAppointment_DB();
        eAppointmentType _eAppointmen;
        public frmAddAppointment(int Appointment_ID ,int LocalApp,clsAppointment_DB._enMode mode,frmTestsAppointment.eAppointmentType eAppointment, bool IsLocked = false)
        {
            InitializeComponent();
            this.Appointment_ID = Appointment_ID;
            this._oAppointment._Mode = mode;
            this._eAppointmen = eAppointment;
            this.LocalApp_ID = LocalApp;
            this.IsLocked = IsLocked;
        }
        private void _CheckTest()
        {
            switch (_eAppointmen)
            {
                case eAppointmentType.Vision:
                    this.laTitle.Text = "Vision Test";
                    PaidFees = 10;
                    TestType_ID = 1;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageVision);
                    break;
                case eAppointmentType.Written:
                    this.laTitle.Text = "Written Test";
                    PaidFees = 20;
                    TestType_ID = 2;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageWritten);
                    break;
                case eAppointmentType.Street:
                    this.laTitle.Text = "Street Test";
                    PaidFees = 30;
                    TestType_ID = 3;
                    pbTests.Image = Image.FromFile(frmTestsAppointment.ImageStreet);
                    break;
                default:
                    break;
            }
        }
        private void StoreDataIn_oAppointment_Add() 
        {
            _oAppointment.Appointment_Date = dtpDate.Value;
            _oAppointment.LocalDrivingLicense_ID = this.LocalApp_ID;
            _oAppointment.PaidFees = Convert.ToDecimal(laFees.Text);
            _oAppointment.User_ID = clsUser_DB.CurrentUser.User_ID;
            _oAppointment.TestType_ID = TestType_ID;
            _oAppointment.IsLocked = false;
        }
        private void _LoadAppDetails(clsAppointment_DB oAppointment) 
        {
            if (oAppointment == null) return;
            laName.Text = oAppointment.PersonName;
            laAppID.Text = this.LocalApp_ID.ToString();
            laClassName.Text = oAppointment.ClassName;
            laTrial.Text = oAppointment.Trial.ToString();
            laFees.Text = PaidFees.ToString();
            if(oAppointment.Appointment_Date != null)
            dtpDate.Value = oAppointment.Appointment_Date;
        }
        private void _LoadDataIn_ControlsAdd() 
        {
            _oAppointment = clsAppointment_DB.FindAppointmentDetails(LocalApp_ID, TestType_ID);
            _LoadAppDetails(_oAppointment);
        }
        private void _LoadDataIn_ControlsUpdate() 
        {
            _oAppointment = clsAppointment_DB.FindTestAppointment(Appointment_ID, TestType_ID, this._oAppointment._Mode );
            _LoadAppDetails(_oAppointment);
        }

        private void _LoadDataIn_ControlsRetake() 
        {
            _oAppointment = clsAppointment_DB.FindTestAppointment(Appointment_ID, TestType_ID, this._oAppointment._Mode);
            _LoadAppDetails(_oAppointment);

        }
        private void _UpdateDataIn_oAppointment() 
        {
            _oAppointment.Appointment_Date = dtpDate.Value;
            _oAppointment.User_ID = clsUser_DB.CurrentUser.User_ID;
            _oAppointment.Appointment_ID = this.Appointment_ID;
        }
        private void EnableRetaked() 
        {
            laRe1.Enabled = true;
            laRe2.Enabled = true;
            laRe3.Enabled = true;
            laRe4.Enabled = true;
            laTotalFees.Enabled = true;
            laRAF.Enabled = true;
            laRAppID.Enabled = true;
        }
        private void LoadDataRetake() 
        {
            laRAF.Text = 5.ToString();
            laTotalFees.Text = (5 + PaidFees).ToString();
        }
        private void _LoadDataMode() 
        {
            switch (_oAppointment._Mode)
            {
                case clsAppointment_DB._enMode.Add:
                    _LoadDataIn_ControlsAdd();
                    break;
                case clsAppointment_DB._enMode.Retake:
                    laTitle.Text = "Retake Test";
                    _LoadDataIn_ControlsRetake();
                    LoadDataRetake();
                    EnableRetaked();
                    break;
                case clsAppointment_DB._enMode.Update:
                    if (IsLocked)
                    {
                        laWarning.Visible = true;
                        dtpDate.Enabled = false;
                        btnSave.Enabled = false;
                    }
                        _LoadDataIn_ControlsUpdate();
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            _CheckTest();
            _LoadDataMode();
        }   
        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_oAppointment._Mode)
            {
                case clsAppointment_DB._enMode.Add:
                    StoreDataIn_oAppointment_Add();
                    if (_oAppointment.Save()) 
                    {
                        laAppID.Text = _oAppointment.Appointment_ID.ToString();
                        MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Notification?.Invoke(this);
                        _oAppointment._Mode = clsAppointment_DB._enMode.Update;
                    }
                    else
                        MessageBox.Show("Add failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case clsAppointment_DB._enMode.Retake:
                    StoreDataIn_oAppointment_Add();
                    LoadDataRetake();
                    if (_oAppointment.Save())
                    {
                        laRAppID.Text = _oAppointment.Appointment_ID.ToString();
                        MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Notification?.Invoke(this);                  
                    }                  
                    else
                        MessageBox.Show("Retake failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _oAppointment._Mode = clsAppointment_DB._enMode.Update;
                    break;
                case clsAppointment_DB._enMode.Update:
                    _UpdateDataIn_oAppointment();
                    if (_oAppointment.Save())
                    {
                        MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Notification?.Invoke(this);
                    }
                    else
                        MessageBox.Show("Update failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }


    }
}
