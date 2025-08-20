using DVLD_Businees;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
     public partial class ctrnPersonDetails : UserControl
    {
        public int Person_ID { get; set; }
        public string NationalNumber { get; set; }
        private string _ImageMalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Male.png";
        private string _ImageFemalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Female.png";

        clsPepole_DB _oPerson = new clsPepole_DB();
        public ctrnPersonDetails()
        {
            InitializeComponent();
        }
        private string _GetFullName(clsPepole_DB oPerson)
        {
            return oPerson.FirstName + " " + oPerson.SecoundName + " " + oPerson.ThirdName + " " + oPerson.LastName;
        }
        private string GetGendorName(bool Gendor) 
        {
            return (Gendor) ? "Male" : "Female";
        }
        private void SetImage(bool GendorNumber) 
        {
            if (GendorNumber)
                pbPicture.Load(_ImageMalePath);
            else 
                pbPicture.Load(_ImageFemalePath);               
        }
        private void _FillDataInControl(clsPepole_DB oPersone) 
        {
            if (oPersone != null)
            {
                laPersonID.Text = oPersone.Persone_ID.ToString();
                laNationalNo.Text = oPersone.NationalNumber;
                laName.Text = _GetFullName(oPersone);
                laCountryName.Text = oPersone.CountryName;
                laEmail.Text = oPersone.Email;
                laGendor.Text = GetGendorName(oPersone.Gendor);
                laBirthOfDate.Text = oPersone.DateOfBirth.ToString();
                laPhone.Text = oPersone.Phone;
                laAddress.Text = oPersone.Address;
                NationalNumber = _oPerson.NationalNumber;
                if (!string.IsNullOrEmpty(oPersone.ImagePath)  && File.Exists(oPersone.ImagePath))
                    pbPicture.Load(oPersone.ImagePath);
                else
                    SetImage(oPersone.Gendor);
            }
            else
            {
                laPersonID.Text = "N/A";
                laNationalNo.Text = "[????]";
                laName.Text = "[????]";
                laCountryName.Text = "[????]";
                laEmail.Text = "[????]";
                laGendor.Text = "[????]";
                laBirthOfDate.Text = "[????]";
                laPhone.Text = "[????]";
                laAddress.Text = "[????]";
                SetImage(true);
            }
        }
        public void LoadPersonData(int person_ID)
        {
            Person_ID = person_ID;
            _oPerson = clsPepole_DB.FindPerson(person_ID);         
            _FillDataInControl(_oPerson);
        }
        public void LoadPersonData(object sender,int person_ID)
        {
            Person_ID = person_ID;
            _oPerson = clsPepole_DB.FindPerson(person_ID);
            _FillDataInControl(_oPerson);
        }
        private void _LoadPersonData() 
        {
            _oPerson = clsPepole_DB.FindPerson(Person_ID);
            _FillDataInControl(_oPerson);
        }
        private void ctrnPersonDetails_Load(object sender, EventArgs e)
        {
            _LoadPersonData();
        }
        private void lnEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditPepole persone = new frmAddOrEditPepole(Person_ID);
            persone.IDBack += LoadPersonData;
            persone.ShowDialog();
        }


    }
}
