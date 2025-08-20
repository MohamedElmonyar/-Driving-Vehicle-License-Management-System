using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Businees
{
    public class clsInternationalLicense_DB
    {
        public int InternationalLicenseID { set; get; }
        public string FullName { set; get; }

        public string Gendor { set; get; } 
        public string ImagePath { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string NationalNo { set; get; }
        public int PersonID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }

        clsClasses.clsInternationalLicense oInternationalLicense = new clsClasses.clsInternationalLicense();
        public clsInternationalLicense_DB() 
        {
            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = -1;
            this.FullName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.NationalNo = string.Empty;
            this.PersonID = -1;
        }
        clsInternationalLicense_DB(clsClasses.clsInternationalLicense oInternationalLicense)
        {
            this.InternationalLicenseID = oInternationalLicense.InternationalLicenseID;
            this.DriverID = oInternationalLicense.DriverID;
            this.IssuedUsingLocalLicenseID = oInternationalLicense.IssuedUsingLocalLicenseID;
            this.ExpirationDate = oInternationalLicense.ExpirationDate;
            this.IssueDate = oInternationalLicense.IssueDate;
            this.IsActive = oInternationalLicense.IsActive;
            this.CreatedByUserID = oInternationalLicense.CreatedByUserID;
            this.FullName = oInternationalLicense.FullName;
            this.DateOfBirth = oInternationalLicense.DateOfBirth;
            this.NationalNo = oInternationalLicense.NationalNo;
            this.PersonID = oInternationalLicense.PersonID;
            this.ImagePath = oInternationalLicense.ImagePath;
            this.Gendor = oInternationalLicense.Gendor;

        }

        static public bool IsInternationalLicenseExists(int LocalLicense_ID)
        {
            return clsInternationalLicense_DA.IsInterntaionalLicenseExists(LocalLicense_ID);
        }

        static public DataTable GetAllInternationalLicense() 
        {
         return clsInternationalLicense_DA.GetAllInternationalLicense();
        }
        static public clsInternationalLicense_DB FindInternationalLicenseByID(int InternationalLicense_ID)
        {
            clsClasses.clsInternationalLicense oInternationalLicense = new clsClasses.clsInternationalLicense();
            if(clsInternationalLicense_DA.GetInternationalLicenseInfo(InternationalLicense_ID, ref oInternationalLicense))        
                return new clsInternationalLicense_DB(oInternationalLicense);
            else            
                return null;          
        }
        private void _StoreDataInclsInternationalLicense()
        {
            this.oInternationalLicense.InternationalLicenseID = this.InternationalLicenseID;
            this.oInternationalLicense.IssuedUsingLocalLicenseID = this.IssuedUsingLocalLicenseID;
            this.oInternationalLicense.IssueDate = this.IssueDate;
            this.oInternationalLicense.ExpirationDate = this.ExpirationDate;
            this.oInternationalLicense.IsActive = this.IsActive;
            this.oInternationalLicense.CreatedByUserID = this.CreatedByUserID;
            this.oInternationalLicense.FullName = this.FullName;
            this.oInternationalLicense.DateOfBirth = this.DateOfBirth;
            this.oInternationalLicense.NationalNo = this.NationalNo;
            this.oInternationalLicense.PersonID = this.PersonID;
            this.oInternationalLicense.DriverID = this.DriverID;
        }
        private bool _AddNew() 
        {
            _StoreDataInclsInternationalLicense();
            this.InternationalLicenseID = clsInternationalLicense_DA.AddNewInternationalLicense(this.oInternationalLicense);
            return (InternationalLicenseID != -1);
        }
        public bool Save() 
        {
            return _AddNew();
        }



    }
}
