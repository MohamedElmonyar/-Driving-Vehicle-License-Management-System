using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsLocalLicenses_DA
    {
        static public DataTable GetLicensesClass()
        {
            DataTable Dt_LicensesClasses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllLicensesClass";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_LicensesClasses.Load(reader);
                else
                    Dt_LicensesClasses = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_LicensesClasses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_LicensesClasses;
        }
        static public int AddNewLocalLicense(clsClasses.clsLocalLicenses oLocalLicense)
        {
            oLocalLicense.LocalLicenseApp_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddLocalDrivingLicenseApplication";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@ApplicantPersonID", oLocalLicense.Person_ID);
            Command.Parameters.AddWithValue("@ApplicationDate", oLocalLicense.Date);
            Command.Parameters.AddWithValue("@UserCreationID", oLocalLicense.UserCreate_ID);
            Command.Parameters.AddWithValue("@LicenseClassID", oLocalLicense.ClassName_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    oLocalLicense.LocalLicenseApp_ID = insertedID;
                else
                    oLocalLicense.LocalLicenseApp_ID = -1;
            }
            catch (Exception ex)
            {
                oLocalLicense.LocalLicenseApp_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return oLocalLicense.LocalLicenseApp_ID;
        }
        static public bool IsApplicationExist(int Person_ID, int LicenseClassID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsApplicationNew";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", Person_ID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        static public DataTable GetAllLocalLicensesApp()
        {
            DataTable Dt_Licenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLocallicensesApp";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_Licenses.Load(reader);
                else
                    Dt_Licenses = null;
                reader.Close();
            }
            catch (Exception ex)
            {
                Dt_Licenses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_Licenses;

        }
        static public bool UpdateLocalLicenseApp(clsClasses.clsLocalLicenses oLocalLicense)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdateLocalDrivingLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@CreationUserID", oLocalLicense.UserCreate_ID);
            Command.Parameters.AddWithValue("@LicenseClassID", oLocalLicense.ClassName_ID);
            Command.Parameters.AddWithValue("@LocalAppID", oLocalLicense.LocalLicenseApp_ID);
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
        static public bool DeleteLocalLicenseApp(int LocalLicenseApp_ID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "DeleteLocalApplication";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalAppID", LocalLicenseApp_ID);
            try
            {
                Connection.Open();
                int RowsEffected = Command.ExecuteNonQuery();
                if (RowsEffected > 0)
                    IsDeleted = true;
                else
                    IsDeleted = false;
            }
            catch (Exception ex)
            {
                IsDeleted = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsDeleted;
        }
        static public bool FindLocalLicenseApp(int LocalLicenseID, ref clsClasses.clsLocalLicenses oLocalLicense)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLocalLicenseApp";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalLicenseAppID", LocalLicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    oLocalLicense.LocalLicenseApp_ID = LocalLicenseID;
                    oLocalLicense.Person_ID = (int)Reader["ApplicantPersonID"];
                    oLocalLicense.ClassName_ID = (int)Reader["LicenseClassID"];
                    oLocalLicense.Date = (DateTime)Reader["ApplicationDate"];
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
        static public bool CaneLocalLicenseApp(int LocalLicenseApp_ID)
        {
            bool IsCanceled = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "CancelApplication";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalAppID", LocalLicenseApp_ID);
            try
            {
                Connection.Open();
                int RowsEffected = Command.ExecuteNonQuery();
                if (RowsEffected > 0)
                    IsCanceled = true;
                else
                    IsCanceled = false;
            }
            catch (Exception ex)
            {
                IsCanceled = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsCanceled;
        }
        static public int GetLocalAppByPersonID(int PersonID)
        {
            int LocalApp_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLocalAppByPerson";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", PersonID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    LocalApp_ID = insertedID;
                else
                    LocalApp_ID = -1;
            }
            catch (Exception ex)
            {
                LocalApp_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return LocalApp_ID;
        }
    }
}
