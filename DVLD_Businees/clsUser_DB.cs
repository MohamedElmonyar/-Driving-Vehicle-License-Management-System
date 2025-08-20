using DVLD_DataAccess;
using System.Collections;
using System.Data;

namespace DVLD_Businees
{
    public class clsUser_DB
    {
        public enum _enMode {Update,Add }
        public int User_ID { get; set; }
        public int Person_ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public bool IsActive { get; set; }

        public clsClasses.clsUserInformation clsUserInformation = new clsClasses.clsUserInformation();
        static public clsUser_DB CurrentUser { get; set; }

        public _enMode _Mode;

        public clsUser_DB() 
        {
            this.User_ID = -1;
            this.Person_ID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this._Mode = _enMode.Add;
        }
        private clsUser_DB(clsClasses.clsUserInformation clsUser) 
        {
            this.User_ID = clsUser.User_ID;
            this.Person_ID = clsUser.Person_ID;
            this.UserName = clsUser.UserName;   
            this.Password = clsUser.Password;
            this.IsActive = clsUser.IsActive;
            this._Mode = _enMode.Update;
        }
        private void _StoreInclsUserInfo() 
        {
            this.clsUserInformation.User_ID = this.User_ID;
            this.clsUserInformation.UserName = this.UserName;
            this.clsUserInformation.Password = this.Password;
            this.clsUserInformation.IsActive = this.IsActive;
            this.clsUserInformation.Person_ID = this.Person_ID;        
        }
        static public bool IsUserExist(string UserName,string Password)
        {
            return clsUsers_DA.IsUserExist(UserName,Password);
        }
        static public bool IsUserActive(string UserName, string Password) 
        {
            return clsUsers_DA.IsUserActive(UserName,Password); 
        }
        static public clsUser_DB FindUser(int User_ID) 
        {
            clsClasses.clsUserInformation clsUser = new clsClasses.clsUserInformation();
            if (clsUsers_DA.GetUser(User_ID, ref clsUser))
                return new clsUser_DB(clsUser);
            else
                return null;
        }
        static public clsUser_DB FindUser(string UserName,string Password)
        {
            clsClasses.clsUserInformation clsUser = new clsClasses.clsUserInformation();
            if (clsUsers_DA.GetUser(UserName,Password ,ref clsUser))
                return new clsUser_DB(clsUser);
            else
                return null;
        }
        static public bool ChangeUserPassword(int UserID,string NewPassword) 
        {
            return clsUsers_DA.ChangeUserPassword(UserID, NewPassword);
        }
        static public bool IsPersonUser(int Person_ID)
        {
            return clsUsers_DA.IsPersonUser(Person_ID);
        }
        private bool _AddNewUser() 
        {
            _StoreInclsUserInfo();
            this.User_ID = clsUsers_DA.AddNewUser(clsUserInformation);
            return (this.User_ID != -1);
        }
        static public DataTable GetAllUsers() 
        {
            return clsUsers_DA.GetAllUsers();
        }
        private bool _UpdateUser() 
        {
            _StoreInclsUserInfo();
            return clsUsers_DA.UpdateUser(clsUserInformation);
        }

        public static string FindUserPassword(int User_ID)
        {
            return clsUsers_DA.GetUserPassword(User_ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.Add:
                    if (_AddNewUser())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case _enMode.Update:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;

                default:
                    return false;
            }

            
        }

    }
}
