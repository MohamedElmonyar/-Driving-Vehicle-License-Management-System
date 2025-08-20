using DVLD_DataAccess;

namespace DVLD_Businees
{
    public class clsTests_DB
    {
        public int Test_ID { set; get; }
        public int User_ID { set; get; }
        public int TestAppointment_ID { set; get; }
        public bool Result { set; get; }
        public string Notes { set; get; }

        public enum enMode {Add,Update }
        public enMode _Mode;

        clsClasses.clsTestsInfo oTest = new clsClasses.clsTestsInfo();

        public clsTests_DB()
        {
            this.Test_ID = -1;
            this.User_ID = -1;
            this.TestAppointment_ID = -1;
            this.Result = false;
            this.Notes = string.Empty;
        }
        private void StoreTestInfo()
        {
            oTest.Test_ID = this.Test_ID;
            oTest.User_ID = this.User_ID;
            oTest.TestAppointment_ID = this.TestAppointment_ID;
            oTest.Result = this.Result;
            oTest.Notes = this.Notes;
        }
        private bool AddNewTest()
        {
            StoreTestInfo();
            this.Test_ID = clsTests_DA.AddNewTest(oTest);
            return (Test_ID != -1);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    return AddNewTest();
                case enMode.Update:
                    return false;
                default:
                    return false;
            }
        }

    }
}
