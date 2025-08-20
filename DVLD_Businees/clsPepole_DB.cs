using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Businees
{
    public class clsPepole_DB
    {
        public int Persone_ID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecoundName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CountryName { get; set; }
        public string ImagePath { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enum _enMode { Update ,AddNew };

        public clsClasses.clsPeopleInformation sPeopleInformation = new clsClasses.clsPeopleInformation();
        public _enMode _Mode;
        private void StoreDataInclsPerson() 
        {
            this.sPeopleInformation.ID = this.Persone_ID;
            this.sPeopleInformation.NationalNo = this.NationalNumber;
            this.sPeopleInformation.FirstName = this.FirstName;
            this.sPeopleInformation.SecondName = this.SecoundName;
            this.sPeopleInformation.ThirdName = this.ThirdName;
            this.sPeopleInformation.LastName = this.LastName;
            this.sPeopleInformation.Email = this.Email;
            this.sPeopleInformation.CountryName = this.CountryName;
            this.sPeopleInformation.Phone = this.Phone;
            this.sPeopleInformation.Address = this.Address;
            this.sPeopleInformation.DateOfBirth = this.DateOfBirth;
            this.sPeopleInformation.ImagePath = this.ImagePath;
            this.sPeopleInformation.Gendor = this.Gendor;
        }
        private clsPepole_DB(clsClasses.clsPeopleInformation PersonInformation) 
        {
            Persone_ID = PersonInformation.ID;
            NationalNumber = PersonInformation.NationalNo;
            FirstName = PersonInformation.FirstName;
            SecoundName = PersonInformation.SecondName;
            ThirdName = PersonInformation.ThirdName;
            LastName = PersonInformation.LastName;
            Email = PersonInformation.Email;
            CountryName = PersonInformation.CountryName;
            Phone = PersonInformation.Phone;
            Address = PersonInformation.Address;
            DateOfBirth = PersonInformation.DateOfBirth;
            ImagePath = PersonInformation.ImagePath;
            Gendor = PersonInformation.Gendor;       
            _Mode = _enMode.Update;
        } 
        public clsPepole_DB() 
        {
            this.Persone_ID = -1;
            this.NationalNumber = "";
            this.FirstName = "";
            this.SecoundName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.CountryName = "";
            this.Phone = "";
            this.Gendor = true;
            this.Address = "";
            this.DateOfBirth = DateTime.Now.AddYears(-18) ;
            this.ImagePath = "";
            _Mode = _enMode.AddNew;
        }
        static public clsPepole_DB FindPerson(int Persone_ID) 
        { 
            clsClasses.clsPeopleInformation sInformation = new clsClasses.clsPeopleInformation();
            if (clsPepole_DA.GetPersonByID(Persone_ID, ref sInformation))
                return new clsPepole_DB(sInformation);
            else
                return null;
        }
        static public clsPepole_DB FindPerson(string NationalNumber) 
        {
            clsClasses.clsPeopleInformation sInformation = new clsClasses.clsPeopleInformation();
            if (clsPepole_DA.GetPersonByNationalNumber(NationalNumber, ref sInformation))
                return new clsPepole_DB(sInformation);
            else
                return null;
        }
        static public DataTable GetAllPepole() 
        {          
            return clsPepole_DA.GetAllPepole();
        }
        static public bool IsPersonExist(string NationalNumber) 
        {
            return clsPepole_DA.IsPersonExist(NationalNumber);
        }
        static public bool IsPersonExist(int Person_ID) 
        {
            return clsPepole_DA.IsPersonExist(Person_ID);
        }
        private bool _AddNewPerson() 
        {
            StoreDataInclsPerson();
            this.Persone_ID = clsPepole_DA.AddNewPerson(this.sPeopleInformation);
            return (Persone_ID != -1);       
        }
        private bool _UpdatePerson() 
        {
            StoreDataInclsPerson();
            return clsPepole_DA.UpdatePerson(this.sPeopleInformation);
        }
        static public bool DeletePerson(int Person_ID) 
        {
            return clsPepole_DA.DeletePersons(Person_ID);
        }
        static public int FindPersonByLocalApp(int LocalApp_ID) 
        {
            return clsPepole_DA.GetPersonByLocalApp(LocalApp_ID);
        }

        static public int FindPersonByLicenseID(int License_ID) 
        {
            return clsPepole_DA.GetPersonByLicenseID(License_ID);
        }

        static public int FindPersonByInterLicenseID(int App_ID) 
        {
            return clsPepole_DA.GetPersonByInterLicenseID(App_ID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case _enMode.Update:
                    if (_UpdatePerson())
                        return true;
                    else
                        return false;

                default:
                    return false;
            }
        } 



    }

}
