using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Businees
{
    public class clsApplication_DB
    {
        public int Person_ID { set; get; }
        public int App_ID { set; get; }
        public string PersonName { set; get; }
        public int LocalLicenseApp_ID { set; get; }
        public string ClassName { set; get; }
        public string UserName { set; get; }
        public int PassedTestCount { set; get; }
        public string Status { set; get; }
        public DateTime LastStatusDate { set; get; }
        public DateTime App_Date { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal Fees { set; get; }

        public clsApplication_DB() { }
        private clsApplication_DB(clsClasses.clsApplicationInfo oAppInfo) 
        {
        
            this.App_ID = oAppInfo.App_ID;
            this.Person_ID = oAppInfo.Person_ID;
            this.PersonName = oAppInfo.PersonName;
            this.ClassName = oAppInfo.ClassName;
            this.Status = oAppInfo.Status;
            this.UserName = oAppInfo.UserName;
            this.ApplicationTypeTitle = oAppInfo.ApplicationTypeTitle;
            this.App_Date = oAppInfo.App_Date;
            this.LocalLicenseApp_ID = oAppInfo.LocalLicenseApp_ID;
            this.LastStatusDate = oAppInfo.LastStatusDate;
            this.Fees = oAppInfo.Fees;
            this.PassedTestCount = oAppInfo.PassedTestCount;
        }
        static public bool IsApplicationExist(int App_ID) 
        {
            return clsApplication_DA.IsApplicationExist(App_ID);
        }   
        static public clsApplication_DB FindApp(int App_ID)
        {
            clsClasses.clsApplicationInfo oAppInfo = new clsClasses.clsApplicationInfo();
            if (clsApplication_DA.GetAllApplicationinformation(App_ID, ref oAppInfo))
                return new clsApplication_DB(oAppInfo);
            else 
                return null;
        }
        static public bool DidHaveLicense(int App_ID, string ClassName) 
        {
            return clsApplication_DA.DidHaveLicense(App_ID,ClassName);
        }
        static public bool IsApplicationCompleted(int App_ID) 
        {
            return clsApplication_DA.IsApplicationCompleted(App_ID);
        }
        static public bool IsApplicationNew(int App_ID) 
        {
            return clsApplication_DA.IsApplicationNew(App_ID);
        }



    }
}
