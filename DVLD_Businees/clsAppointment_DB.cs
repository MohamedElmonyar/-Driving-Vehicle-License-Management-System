using DVLD_DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;

namespace DVLD_Businees
{
    public class clsAppointment_DB
    {
        public enum _enMode { Add,Retake,Update}
        public _enMode _Mode;
        public int Appointment_ID { get; set; }
        public int TestType_ID { get; set; }
        public int LocalDrivingLicense_ID { get; set; }
        public int User_ID { get; set; }
        public DateTime Appointment_Date { get; set; }
        public decimal PaidFees { set; get; }
        public bool IsLocked { set; get; }
        public int Trial { set; get; }
        public string PersonName { set; get; }
        public DateTime App_Date { set; get; }
        public string ClassName { set; get; }

        clsClasses.clsAppointmentInfo _oAppointment = new clsClasses.clsAppointmentInfo();
        public clsAppointment_DB() 
        {
            this.Appointment_ID = -1;
            this.LocalDrivingLicense_ID = -1;
            this.Appointment_Date = DateTime.Now;
            this.User_ID = -1 ;
            this.TestType_ID = -1;
            this.PaidFees = -1;
            this.IsLocked = false;
        }
        public clsAppointment_DB(clsClasses.clsAppointmentInfo oAppointment,_enMode enMode = _enMode.Add)
        {       
            this.App_Date = oAppointment.App_Date;
            if (oAppointment.Appointment_Date != null)
            this.Appointment_Date = oAppointment.Appointment_Date;
            this.PersonName = oAppointment.PersonName;
            this.Trial = oAppointment.Trial;
            this.ClassName = oAppointment.ClassName;
            this.PaidFees = oAppointment.PaidFees;
            this._Mode = enMode;
        }
        private void StoreInoAppointment() 
        {
            _oAppointment.User_ID = this.User_ID;
            _oAppointment.PaidFees = this.PaidFees; 
            _oAppointment.IsLocked = this.IsLocked;
            _oAppointment.LocalDrivingLicense_ID = this.LocalDrivingLicense_ID; 
            _oAppointment.Appointment_Date = this.Appointment_Date;
            _oAppointment.Appointment_ID = this.Appointment_ID;
            _oAppointment.TestType_ID = this.TestType_ID; 
        }
        static public DataTable FindAppointmentInformation(int Person_ID,string ClassName,string TestTypeTitle) 
        {
            return clsAppointment_DA.GetAppointmentInformation(Person_ID,ClassName, TestTypeTitle);
        }
        static public bool CheckTest(int Person_ID, string ClassName, string TestTypeTitle) 
        {
          return clsAppointment_DA.CheckTest(Person_ID, ClassName, TestTypeTitle);
        }
        static public bool DidHaveAppointmentActive(int Person_ID, string ClassName, string TestTypeTitle)
        {
            return clsAppointment_DA.IsAppointmentActive(Person_ID,ClassName,TestTypeTitle);
        }
        static public bool IsAppointmentRetakeTest(int Person_ID, string ClassName, string TestTypeTitle,ref int Appointment_ID) 
        {
          return clsAppointment_DA.IsAppointmentRetakeTest(Person_ID, ClassName, TestTypeTitle, ref Appointment_ID);
        }
        static public clsAppointment_DB FindAppointmentDetails(int LocalDrivingLicense_ID,int TestType_ID,_enMode mode = _enMode.Add) 
        {
            clsClasses.clsAppointmentInfo oAppointment = new clsClasses.clsAppointmentInfo();
            if (clsAppointment_DA.GetAppointmentDetails(LocalDrivingLicense_ID, TestType_ID, ref oAppointment))
                return new clsAppointment_DB(oAppointment, mode);
            else
                return null;
        }
        static public clsAppointment_DB FindTestAppointment(int Appointment_ID,int TestTypeID,_enMode mode = _enMode.Add) 
        {
            clsClasses.clsAppointmentInfo oAppointment = new clsClasses.clsAppointmentInfo();
            if (clsAppointment_DA.FindAppointment(Appointment_ID, TestTypeID, ref oAppointment))
                return new clsAppointment_DB(oAppointment,mode);
            else
                return null;
        }
        private bool _AddNew()
        {
            StoreInoAppointment();
            this.Appointment_ID = clsAppointment_DA.AddNewAppointment(_oAppointment);
            return (this.Appointment_ID != -1);
        }

        static public bool IsPassed(int LocalApp_ID, string TestType) 
        {
            return clsAppointment_DA.IsPassed(LocalApp_ID,TestType);
        }
        private bool _Update()
        {
            return clsAppointment_DA.UpdateAppointment(this.Appointment_ID,this.User_ID,this.Appointment_Date);
        }
        public bool Save()
        {
            switch (this._Mode)
            {
                case clsAppointment_DB._enMode.Add:
                    return _AddNew(); 
                case clsAppointment_DB._enMode.Retake:
                    return _AddNew(); 
                case clsAppointment_DB._enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }

    }
}
