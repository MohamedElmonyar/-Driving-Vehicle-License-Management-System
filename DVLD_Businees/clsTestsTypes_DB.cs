using DVLD_DataAccess;
using System.Data;


namespace DVLD_Businees
{
    public class clsTestsTypes_DB
    {
        public int Test_ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public decimal Fees { set; get; }

        clsClasses.clsTestsTypes _oTests = new clsClasses.clsTestsTypes();
        private void StoreIn_oTests()
        {
            _oTests.Test_ID = this.Test_ID;
            _oTests.Description = this.Description;
            _oTests.Title = this.Title;
            _oTests.Fees = this.Fees;
        }
        private clsTestsTypes_DB(clsClasses.clsTestsTypes oTests)
        {
            this.Test_ID = oTests.Test_ID;
            this.Title = oTests.Title;
            this.Description = oTests.Description;
            this.Fees = oTests.Fees;
        }
        public clsTestsTypes_DB() { }
        static public DataTable GetAllTests() 
        {
            return clsTestsTypes_DA.GetAllTests();
        }
        static public clsTestsTypes_DB FindTest(int Test_ID) 
        {
            clsClasses.clsTestsTypes oTests = new clsClasses.clsTestsTypes();
            if (clsTestsTypes_DA.GetTest(Test_ID,ref oTests))
                return new clsTestsTypes_DB(oTests);
            else
                return null;
        }
        private bool _UpdateTest() 
        {
            StoreIn_oTests();
            return clsTestsTypes_DA.UpdateTest(_oTests);
        }
        public bool Save() 
        {
            return _UpdateTest();
        }


    }
}
