using DVLD_Businees;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace DVLD
{
    public partial class ctrnAddOrEditPerson : UserControl
    {
 
        public int _Person_ID { set; get; }
        private string _CurrentNationalNumber;
        private bool _IsSets { set; get; }
        private string _ImageMalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Male.png";
        private string _ImageFemalePath = @"C:\Users\Mohamed Elmonaier\Downloads\Pictures\Female.png";
        clsPepole_DB._enMode _Mode;

        clsPepole_DB _oPerson = new clsPepole_DB();
        public ctrnAddOrEditPerson()
        {            
            InitializeComponent();
        }
        private string _LoadPhoto(clsPepole_DB oPersone)
        {
            if (File.Exists(oPersone.ImagePath))
                return (oPersone.ImagePath);
            else  if (oPersone.Gendor)
                return (_ImageMalePath);
            else
                return (_ImageFemalePath);        
        }
        private void _CheckMode() 
        {
            if (_Person_ID == -1)
                _Mode = clsPepole_DB._enMode.AddNew;
            else
                _Mode = clsPepole_DB._enMode.Update;
        }
        private void _CheckChangeStatus() 
        {
            if (_Mode == clsPepole_DB._enMode.AddNew)
                laStauts.Text = "Add New Person";
            else
                laStauts.Text = "Update Person";
        }
        private void _FillCountriesInCombo() 
        {
            cbCountry.DataSource = clsCountries_DB.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.Text = _oPerson.CountryName;
        } 
        private void _FillDataInControl(clsPepole_DB oPersone) 
        {
            dtpBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirth.MinDate = DateTime.Now.AddYears(-90);
            if (oPersone != null)
            {
                _CheckChangeStatus();
                laPersonID.Text = oPersone.Persone_ID.ToString();
                tbFirstName.Text = oPersone.FirstName;
                tbSecoundName.Text = oPersone.SecoundName;
                tbThirdName.Text = oPersone.ThirdName;
                tbLastName.Text = oPersone.LastName;
                tbNationalNo.Text = oPersone.NationalNumber;
                tbPhone.Text = oPersone.Phone;
                tbEmail.Text = oPersone.Email;
                cbCountry.Text = oPersone.CountryName;
                tbAddress.Text = oPersone.Address;
                dtpBirth.Value = _oPerson.DateOfBirth;
                _CurrentNationalNumber = oPersone.NationalNumber;
                pbGendor.Load(_LoadPhoto(oPersone));
                _IsSets = (oPersone.ImagePath != "");
                rbMale.Checked = (_oPerson.Gendor); 
                rbFemale.Checked = !rbMale.Checked;                
                lnRemove.Visible = (_IsSets);
            }
          
        }
        private void _FillDataIn_oPerson() 
        {
            _oPerson.NationalNumber = tbNationalNo.Text;
            _oPerson.FirstName = tbFirstName.Text;
            _oPerson.SecoundName = tbSecoundName.Text;
            _oPerson.ThirdName = tbThirdName.Text;
            _oPerson.LastName = tbLastName.Text;
            _oPerson.Email = tbEmail.Text;
            _oPerson.CountryName = cbCountry.Text;
            _oPerson.Phone = tbPhone.Text;
            _oPerson.Address = tbAddress.Text;
            _oPerson.DateOfBirth = dtpBirth.Value;
            _oPerson.ImagePath = _oPerson.ImagePath;
            _oPerson.Gendor = rbMale.Checked;
            _oPerson._Mode = _Mode;
           
        }
        private void _LoadData()
        {
            _CheckMode();
            _FillCountriesInCombo();
            if (_Mode == clsPepole_DB._enMode.AddNew)
            {                
                _FillDataInControl(_oPerson);
                _CurrentNationalNumber = _oPerson.NationalNumber;
                laPersonID.Text = "N/A";
                
            }
            else if (_Mode == clsPepole_DB._enMode.Update)
            {
                _oPerson = clsPepole_DB.FindPerson(_Person_ID);
                _FillDataInControl(_oPerson);
            }  
        }
        private void ctrnAddNewPepole_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private bool _IsTextNotNull()
        {
            return panel1.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void _CheckedChanged_btnGendor(object sender, EventArgs e)
        {
           if (rbMale.Checked && !_IsSets)
           {
               pbGendor.Load(_ImageMalePath);
               return;
           }
           if (rbFemale.Checked && !_IsSets ) 
           {
               pbGendor.Load(_ImageFemalePath);
               return;
           }

        }
        private bool _IsValidEmail(string Email)
        {
            return Regex.IsMatch(Email,
       @"^[a-zA-Z0-9._%+-]+@gmail\.com$",
       RegexOptions.IgnoreCase);
        }
        private void _TextValidation(object sender, CancelEventArgs e)
        {
            TextBox Texts = sender as TextBox;
            if (Texts != null) 
            {
                if (string.IsNullOrEmpty(Texts.Text))
                {
                    ebTexts.SetError(Texts, "This field is required");
                    e.Cancel = true;
                }
                else
                    ebTexts.SetError(Texts, "");    
            }
        }
        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNo.Text))
                return;

            if (clsPepole_DB.IsPersonExist(tbNationalNo.Text) && _Mode == clsPepole_DB._enMode.AddNew)
            {
                ebTexts.SetError(tbNationalNo, "National Number Is Used by Another Person");
                e.Cancel = true;
            }
            else if (_Mode == clsPepole_DB._enMode.Update && tbNationalNo.Text.ToLower() != _CurrentNationalNumber.ToLower()) 
            {
                if (clsPepole_DB.IsPersonExist(tbNationalNo.Text))
                {
                    ebTexts.SetError(tbNationalNo, "National Number Is Used by Another Person");
                    e.Cancel = true;
                }
                else
                    ebTexts.SetError(tbNationalNo, "");
            }
            else
                ebTexts.SetError(tbNationalNo, "");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsTextNotNull())
            {
                _FillDataIn_oPerson();
                if (_oPerson.Save())
                {
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_Mode == clsPepole_DB._enMode.AddNew)
                        _Mode = clsPepole_DB._enMode.Update;
                    laPersonID.Text = _oPerson.Persone_ID.ToString();
                    _Person_ID = _oPerson.Persone_ID;
                    _CheckMode();
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter the Data Correctly", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void lnSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdPIcture.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdPIcture.FilterIndex = 1;
            ofdPIcture.RestoreDirectory = true;

            if (ofdPIcture.ShowDialog() == DialogResult.OK && ofdPIcture.FileName != null)
            {
                _oPerson.ImagePath = ofdPIcture.FileName;
                lnRemove.Visible = true;
                pbGendor.Load(_oPerson.ImagePath);
            }
        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text)) 
            {
                if (!_IsValidEmail(tbEmail.Text))
                {
                    ebTexts.SetError(tbEmail, "Enter Correct Email");
                    e.Cancel = true;                  
                }
                else
                    ebTexts.SetError(tbEmail, "");
            }

        }
        private void lnRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbGendor.Image = null;
            lnRemove.Visible = false;
            _oPerson.ImagePath = ""; 
        }


  
    }
}
