using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Businees
{
    public class clsLocalLicenses_DB
    {
        public enum enMode { Add, Update }

        public enMode Mode;
        public int Person_ID { set; get; }
        public int LocalLicenseApp_ID { set; get; }
        public int ClassName_ID { set; get; }
        public string ClassDescription { set; get; }
        public int UserCreate_ID { set; get; }
        public int Status { set; get; }
        public byte MinimumAge { set; get; }
        public byte ValidateLength { set; get; }
        public decimal Fees { set; get; }
        public DateTime Date { set; get; }

        clsClasses.clsLocalLicenses _oLocalLicense = new clsClasses.clsLocalLicenses();
        private void _StoreIn_oLocalLicense()
        {
            _oLocalLicense.Person_ID = this.Person_ID;
            _oLocalLicense.Date = this.Date;
            _oLocalLicense.Status = this.Status;
            _oLocalLicense.ClassName_ID = this.ClassName_ID;
            _oLocalLicense.UserCreate_ID = this.UserCreate_ID;
            _oLocalLicense.LocalLicenseApp_ID = this.LocalLicenseApp_ID;
        }
        static public DataTable GetAllLicnesesClasses()
        {
            return clsLocalLicenses_DA.GetLicensesClass();
        }
        private clsLocalLicenses_DB(clsClasses.clsLocalLicenses oLocalLicense)
        {
            this.LocalLicenseApp_ID = oLocalLicense.LocalLicenseApp_ID;
            this.Person_ID = oLocalLicense.Person_ID;
            this.Date = oLocalLicense.Date;
            this.Status = oLocalLicense.Status;
            this.ClassName_ID = oLocalLicense.ClassName_ID;
            this.UserCreate_ID = oLocalLicense.UserCreate_ID;
        }
        public clsLocalLicenses_DB()
        {
            this.Person_ID = -1;
            this.Date = DateTime.Now;
            this.Status = 1;
            this.ClassName_ID = 1;
            this.UserCreate_ID = 1;
        }
        static public clsLocalLicenses_DB Find(int LocalLicenseID)
        {
            clsClasses.clsLocalLicenses clsLocalLicenses = new clsClasses.clsLocalLicenses();
            if (clsLocalLicenses_DA.FindLocalLicenseApp(LocalLicenseID, ref clsLocalLicenses))
                return new clsLocalLicenses_DB(clsLocalLicenses);
            else
                return null;
        }
        static public bool IsApplicationExist(int Person_ID, int LicenseClassID)
        {
            return clsLocalLicenses_DA.IsApplicationExist(Person_ID, LicenseClassID);
        }
        static public DataTable GetAllLocalLicensesApp()
        {
            return clsLocalLicenses_DA.GetAllLocalLicensesApp();
        }
        static public bool CancelLocalLicenseApp(int LocalLicenseAppID)
        {
            return clsLocalLicenses_DA.CaneLocalLicenseApp(LocalLicenseAppID);
        }
        static public bool DeleteLocalLicenseApp(int LocalLicenseAppID)
        {
            return clsLocalLicenses_DA.DeleteLocalLicenseApp(LocalLicenseAppID);
        }
        private bool _AddNewLocalLicense()
        {
            _StoreIn_oLocalLicense();
            this.LocalLicenseApp_ID = clsLocalLicenses_DA.AddNewLocalLicense(_oLocalLicense);
            return (this.LocalLicenseApp_ID != -1);
        }
        private bool _UpdateLocalLicense()
        {
            _StoreIn_oLocalLicense();
            return clsLocalLicenses_DA.UpdateLocalLicenseApp(_oLocalLicense);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        Mode = enMode.Update;
                        return _AddNewLocalLicense();
                    }
                case enMode.Update:
                    return _UpdateLocalLicense();
            }

            return false;
        }

        static public int FindLocalAppByPersonID(int PersonID)
        {
            return clsLocalLicenses_DA.GetLocalAppByPersonID(PersonID);
        }
    }
}

