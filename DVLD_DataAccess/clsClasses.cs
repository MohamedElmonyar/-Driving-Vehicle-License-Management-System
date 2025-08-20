using System;

static public class clsClasses
{ 
    public class clsPeopleInformation
    {
        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CountryName { get; set; }
        public string ImagePath { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class clsUserInformation 
    {
        public int User_ID { get; set; }
        public int Person_ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }
    public class clsApplicationsTypes
    {
        public string Title { set; get; }
        public int App_ID { set; get; }
        public decimal Fees { set; get; }
    }
    public class clsTestsTypes
    {
        public int Test_ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public decimal Fees { set; get; }
    }
    public class clsLocalLicenses
    {
        public int Person_ID { set; get; }
        public int LocalLicenseApp_ID { set; get; }
        public int ClassName_ID { set; get; }
        public int UserCreate_ID { set; get; }
        public string ClassDescription { set; get; }
        public int Status { set; get; }
        public DateTime LastStatusDate { set; get; }
        public byte MinimumAge { set; get; }
        public byte ValidateLength { set; get; }
        public decimal Fees { set; get; }
        public DateTime Date { set; get; }
    }
    public class clsApplicationInfo
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
    }
    public class clsAppointmentInfo
    {
        public int LocalDrivingLicense_ID { set; get; }
        public string ClassName { set; get; }
        public int Appointment_ID { set; get; }
        public int TestType_ID { set; get; }
        public int User_ID { set; get; }
        public DateTime Appointment_Date { set; get; }
        public int Trial { set; get; }
        public string PersonName { set; get; }
        public DateTime App_Date { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsLocked { set; get; }
    }
    public class clsTestsInfo
    {
        public int Test_ID { set; get; }
        public int User_ID { set; get; }
        public int TestAppointment_ID { set; get; }
        public bool Result { set; get; }
        public string Notes { set; get; }
    }
    public class clsLicense
    {
        public int License_ID { set; get; }

        public int DeLicense_ID { set; get; }

        public decimal FineFees { set; get; }
        public int User_ID { set; get; }
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
        public string Notes { set; get; }

    }
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { set; get; }

        public string FullName { set; get; }

        public string ImagePath { set; get; }
        public string Gendor { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string NationalNo { set; get; }
        public int PersonID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID  { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }
    }


}

;