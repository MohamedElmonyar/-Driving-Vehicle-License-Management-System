using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    static public class clsUsers_DA
    {
        static public bool IsUserExist(string UserName,string Password) 
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsUserExist";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsFound = (bool)result;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public bool IsUserExist(int User_ID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsUserExistByID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserID", User_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsFound = (bool)result;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public bool IsUserActive(string UserName, string Password) 
        {
            bool IsActive = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsUserActive";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsActive =(bool) result;
            }
            catch (Exception ex)
            {
                IsActive = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsActive;
        }
        static private bool _GetUserByID(int ID, ref clsClasses.clsUserInformation clsUser)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetUserByID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    clsUser.User_ID = ID;
                    clsUser.Person_ID = (int)Reader["PersonID"];
                    clsUser.UserName = (string)Reader["UserName"];
                    clsUser.Password = (string)Reader["Password"];
                    clsUser.IsActive = (bool)Reader["IsActive"];
                   
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static private bool _GetUserByUserNameAndPassowrd(string UserName,string Password,ref clsClasses.clsUserInformation clsUser)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetUserByUserNameAndPassword";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    clsUser.User_ID = (int)Reader["UserID"];
                    clsUser.Person_ID = (int)Reader["PersonID"];
                    clsUser.UserName = (string)Reader["UserName"];
                    clsUser.Password = (string)Reader["Password"];
                    clsUser.IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        static public bool GetUser(int ID,ref clsClasses.clsUserInformation clsUser)
        {
            if (!IsUserExist(ID))
                return false;
            if (!_GetUserByID(ID, ref clsUser))
                return false;
            else
                return true;
        }
        static public bool GetUser(string UserName, string Password,ref clsClasses.clsUserInformation clsUser)
        {
            if (!IsUserExist(UserName, Password))
                return false;
            if (!_GetUserByUserNameAndPassowrd(UserName, Password, ref clsUser))
                return false;
            else
                return true;
        }
        static public int AddNewUser(clsClasses.clsUserInformation clsUser) 
        {
            clsUser.User_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewUser";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonId", clsUser.Person_ID);
            Command.Parameters.AddWithValue("@Username",clsUser.UserName);
            Command.Parameters.AddWithValue("@Password", clsUser.Password);
            Command.Parameters.AddWithValue("@IsActive", clsUser.IsActive);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    clsUser.User_ID = insertedID;
                else
                    clsUser.User_ID = -1;
            }
            catch (Exception ex)
            {
                clsUser.User_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return clsUser.User_ID;
        }
        static public bool UpdateUser(clsClasses.clsUserInformation clsUser) 
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdateUser";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserID", clsUser.User_ID);
            Command.Parameters.AddWithValue("@Username", clsUser.UserName);
            Command.Parameters.AddWithValue("@Password", clsUser.Password);
            Command.Parameters.AddWithValue("@IsActive", clsUser.IsActive);
            try
            {
                Connection.Open();
                int RowsEffected = Command.ExecuteNonQuery();
                if (RowsEffected > 0)
                    IsUpdated = true;
                else
                    IsUpdated = false;
            }
            catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsUpdated;
        }
        static public bool ChangeUserPassword(int User_ID,string NewPassword) 
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UserChangePassword";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserID", User_ID);
            Command.Parameters.AddWithValue("@NewPassword", NewPassword);
            try
            {
                Connection.Open();
                int RowsEffected = Command.ExecuteNonQuery();
                if (RowsEffected > 0)
                    IsUpdated = true;
                else
                    IsUpdated = false;
            }
            catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsUpdated;
        }
        static public bool IsPersonUser(int Person_ID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsPersonUser";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", Person_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsFound = (bool)result;
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        } 
        static public DataTable GetAllUsers() 
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllUsers";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt.Load(reader);
                else
                    Dt = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt;
        }


        static public string GetUserPassword(int User_ID)
        {
            string User_Pass = string.Empty;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetUserPassword";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@User_ID", User_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null)
                    User_Pass = result.ToString();
                else
                    User_Pass = string.Empty;
            }
            catch (Exception ex)
            {
                User_Pass = string.Empty;
            }
            finally
            {
                Connection.Close();
            }
            return User_Pass;
        }



    }
}
