using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Businees
{
    public class clsLicense_DB
    {
        public int License_ID { set; get; }
        public int ReLicense_ID { set; get; }
        public int Application_ID { set; get; }
        public int Person_ID { set; get; }
        public int LocalDrivingLicense_ID { set; get; }
        public string PersonName { set; get; }
        public string ClassName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpireDate { set; get; }
        public string Gendor { set; get; }
        public string ImagePath { set; get; }
        public string NationalNo { set; get; }
        public int Driver_ID { set; get; }
        public bool IsActive { set; get; }
        public string IsDetained { set; get; }
        public string IssueReason { set; get; }
        public int DeLicense_ID { set; get; }
        public decimal FineFees { set; get; }
        public int User_ID { set; get; }
        public string Notes { set; get; }
        public enum enLicenseRepalceReason { Lost, Damage}

        public enLicenseRepalceReason ReplaceReason { set; get; }
        public enum enMode { Add,Update,Renew,Replace,Detain,Release}
        public enMode Mode { set; get; }

        clsClasses.clsLicense oLicense = new clsClasses.clsLicense();
        private void _StoreInoLicense()
        {
            oLicense.License_ID = this.License_ID;
            oLicense.LocalDrivingLicense_ID = this.LocalDrivingLicense_ID;
            oLicense.PersonName = this.PersonName;
            oLicense.ClassName = this.ClassName;
            oLicense.DateOfBirth = this.DateOfBirth;
            oLicense.IssueDate = this.IssueDate;
            oLicense.ExpireDate = this.ExpireDate;
            oLicense.Gendor = this.Gendor;
            oLicense.ImagePath = this.ImagePath;
            oLicense.NationalNo = this.NationalNo;
            oLicense.Driver_ID = this.Driver_ID;
            oLicense.IsActive = this.IsActive;
            oLicense.IsDetained = this.IsDetained;
            oLicense.IssueReason = this.IssueReason;
            oLicense.Person_ID = this.Person_ID;
            oLicense.Application_ID = this.Application_ID;
            oLicense.Notes = this.Notes;
            oLicense.ReLicense_ID = this.ReLicense_ID;
            oLicense.DeLicense_ID = this.DeLicense_ID;
            oLicense.FineFees = this.FineFees;
            oLicense.User_ID = clsUser_DB.CurrentUser.User_ID;
        }
        public clsLicense_DB()
        {
            this.License_ID = -1;
            this.LocalDrivingLicense_ID = -1;
            this.Person_ID = -1;
            this.PersonName = string.Empty;
            this.ClassName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.IssueDate = DateTime.Now;
            this.ExpireDate = DateTime.Now.AddYears(5);
            this.Gendor = string.Empty;
            this.ImagePath = string.Empty;
            this.NationalNo = string.Empty;
            this.Driver_ID = -1;
            this.IsActive = true;
            this.IsDetained = string.Empty;
            this.IssueReason = string.Empty;
            this.Notes = string.Empty;
            this.Application_ID = -1;
            this.Mode = enMode.Add;
            this.ReLicense_ID = -1;
            this.DeLicense_ID = -1;
            this.License_ID = -1;
            this.FineFees = 0.0M;
        }
        public clsLicense_DB(clsClasses.clsLicense oLicense)
        {
            this.License_ID = oLicense.License_ID;
            this.LocalDrivingLicense_ID = oLicense.LocalDrivingLicense_ID;
            this.PersonName = oLicense.PersonName;
            this.ClassName = oLicense.ClassName;
            this.DateOfBirth = oLicense.DateOfBirth;
            this.IssueDate = oLicense.IssueDate;
            this.ExpireDate = oLicense.ExpireDate;
            this.Gendor = oLicense.Gendor;
            this.ImagePath = oLicense.ImagePath;
            this.NationalNo = oLicense.NationalNo;
            this.Driver_ID = oLicense.Driver_ID;
            this.IsActive = oLicense.IsActive;
            this.IsDetained = oLicense.IsDetained;
            this.IssueReason = oLicense.IssueReason;
            this.Notes = oLicense.Notes;
            this.Person_ID = oLicense.Person_ID;
            this.Application_ID = oLicense.Application_ID;
            this.ReLicense_ID = oLicense.ReLicense_ID;
            this.DeLicense_ID = oLicense.DeLicense_ID;
            this.FineFees = oLicense.FineFees;
            this.User_ID = oLicense.User_ID;
        }
        static public bool IsLicenseExist(int License_ID)
        {
            return clsLicense_DA.IsLicenseExist(License_ID);
        }
        static public clsLicense_DB FindLicense(int Local_ID)
        {
            clsClasses.clsLicense oLicense = new clsClasses.clsLicense();
            if (clsLicense_DA.GetLicenseInformation(Local_ID, ref oLicense))
                return new clsLicense_DB(oLicense);
            else
                return null;
        }
        static public clsLicense_DB FindLicenseID(int License_ID)
        {
            clsClasses.clsLicense oLicense = new clsClasses.clsLicense();
            if (clsLicense_DA.FindLicenseInformation(License_ID, ref oLicense))
                return new clsLicense_DB(oLicense);
            else
                return null;
        }
        static public clsLicense_DB FindDetainedLicense(int License_ID)
        {
            clsClasses.clsLicense oLicense = new clsClasses.clsLicense();
            if (clsLicense_DA.GetLicenseDetainedInformation(License_ID, ref oLicense))
                return new clsLicense_DB(oLicense);
            else
                return null;
        }
        static public DataTable GetAllLocalLicenseToPerson(int Person_ID) 
        {
            return clsLicense_DA.GetAllLocalLicenseToPerson(Person_ID);
        }
        static public DataTable GetAllInternationalLicenseToPerson(int Person_ID) 
        {
          return clsLicense_DA.GetAllInternationalLicenseToPerson(Person_ID);
        }

        private bool _AddNew()
        {
            _StoreInoLicense();
            this.License_ID = clsLicense_DA.AddNewLicense(oLicense);
            return (this.License_ID != -1);
        }
        private bool _Renew()
        {
            _StoreInoLicense();
            clsLicense_DA.RenewLicense(ref oLicense);
            this.ReLicense_ID = oLicense.ReLicense_ID;
            this.Application_ID = oLicense.Application_ID;
            return (this.ReLicense_ID != -1);
        }
        private bool _Damage()
        {
            _StoreInoLicense();
            clsLicense_DA.ReplaceLicenseForDamage(ref oLicense);
            this.ReLicense_ID = oLicense.ReLicense_ID;
            this.Application_ID = oLicense.Application_ID;
            return (oLicense.ReLicense_ID != -1);
        }
        private bool _Lost()
        {
            _StoreInoLicense();
            clsLicense_DA.ReplaceLicenseForLost(ref oLicense);
            this.ReLicense_ID = oLicense.ReLicense_ID;
            this.Application_ID = oLicense.Application_ID;
            return (oLicense.ReLicense_ID != -1);
        }
        private bool _Detain()
        {
            _StoreInoLicense();
            clsLicense_DA.DetainedLicense(ref oLicense);
            this.DeLicense_ID = oLicense.DeLicense_ID;
            return (oLicense.DeLicense_ID != -1);
        }
        private bool _Release()
        {
            _StoreInoLicense();
            clsLicense_DA.ReleaseLicense(ref oLicense);
            this.Application_ID = oLicense.Application_ID;
            return (oLicense.Application_ID != -1);
        }
        static public bool IsLicenseDetained(int License_ID)
        {
            return clsLicense_DA.IsLicenseDetained(License_ID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    Mode = enMode.Update;
                    return _AddNew();

                case enMode.Update:
                    return false;

                case enMode.Renew:
                    Mode = enMode.Update;
                    return _Renew();

                case enMode.Replace:
                    Mode = enMode.Update;
                    if (this.ReplaceReason == enLicenseRepalceReason.Lost)
                        return _Lost();
                    else if (this.ReplaceReason == enLicenseRepalceReason.Damage)
                        return _Damage();
                    else
                        return false;

                case enMode.Detain:
                    Mode = enMode.Update;
                    return _Detain();

                case enMode.Release:
                    Mode = enMode.Update;
                    return _Release();

                default:
                    return false;
            }
        }
        static public bool IsLicenseClass3(int LocalLicense_ID)
        {
            return clsLicense_DA.IsLicenseClass3(LocalLicense_ID);
        }
        static public int FindLocalAppByLicense(int License_ID)
        {
            return clsLicense_DA.GetLocalAppByLicenseID(License_ID);
        }
        static public bool IsLicenseActive(int License_ID) 
        {
            return clsLicense_DA.IsLicenseActive(License_ID);
        }
        static public bool IsLicenseEnded(int License_ID) 
        {
            return clsLicense_DA.IsLicenseEnded(License_ID);        
        }
        static public DataTable GetDetainedLicenses() 
        {
            return clsLicense_DA.GetDetainedLicenses();
        }


     }
}
