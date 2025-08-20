using System.Data;
using DVLD_DataAccess;

namespace DVLD_Businees
{
   
    public class clsApplicationsTypes_DB
    {

        public string Title { set; get; }
        public int App_ID { set; get; }
        public decimal Fees { set; get; }

        clsClasses.clsApplicationsTypes _oAppType = new clsClasses.clsApplicationsTypes();
        private void StoreInoAppType() 
        {
            _oAppType.App_ID = this.App_ID;
            _oAppType.Title = this.Title;
            _oAppType.Fees = this.Fees; 
        }
        static public DataTable GetALLApplicationsTypes()
        {
            return clsApplicationsTypes_DA.GetAllApplicationsTypes();
        }
        private clsApplicationsTypes_DB(clsClasses.clsApplicationsTypes oAppType) 
        {
            this.Title = oAppType.Title;
            this.App_ID = oAppType.App_ID;
            this.Fees = oAppType.Fees;
        }
        public clsApplicationsTypes_DB() { }
        static public clsApplicationsTypes_DB FindAppLication(int App_ID) 
        {
            clsClasses.clsApplicationsTypes clsApp = new clsClasses.clsApplicationsTypes();
            if (clsApplicationsTypes_DA.GetApplication(App_ID, ref clsApp))
                return new clsApplicationsTypes_DB(clsApp);
            else
                return null;     
        }
        private bool _UpdateAppFees() 
        {
            return clsApplicationsTypes_DA.UpdateAppFees(this.App_ID, this.Fees);
        }
        public bool Save() 
        {
            return _UpdateAppFees();
        }



    }
}
