using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicense_DA
    {

        static public int AddNewLicense(clsClasses.clsLicense oLicense)
        {
            oLicense.License_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewLocalDrivingLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalApplication_ID", oLicense.LocalDrivingLicense_ID);
            if (string.IsNullOrEmpty(oLicense.Notes))
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", oLicense.Notes);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    oLicense.License_ID = insertedID;
                else
                    oLicense.License_ID = -1;
            }
            catch (Exception ex)
            {
                oLicense.License_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return oLicense.License_ID;
        }
        static public bool GetLicenseInformation(int LocalLicense_ID, ref clsClasses.clsLicense oLicense)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalApplication_ID", LocalLicense_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.License_ID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    oLicense.LocalDrivingLicense_ID = LocalLicense_ID;
                    oLicense.PersonName = reader.GetString(reader.GetOrdinal("FullName"));
                    oLicense.ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                    oLicense.Person_ID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                    oLicense.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                    oLicense.IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                    oLicense.ExpireDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                    oLicense.Gendor = reader.GetString(reader.GetOrdinal("Gendor"));
                    oLicense.ImagePath = reader.GetString(reader.GetOrdinal("ImagePath"));
                    oLicense.NationalNo = reader.GetString(reader.GetOrdinal("NationalNo"));
                    oLicense.Driver_ID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                    oLicense.IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                    oLicense.IsDetained = reader.GetString(reader.GetOrdinal("IsDetained"));
                    int notesIndex = reader.GetOrdinal("Notes");
                    oLicense.Notes = reader.IsDBNull(notesIndex) ? null : reader.GetString(notesIndex);
                    oLicense.IssueReason = reader.GetString(reader.GetOrdinal("IssueReason"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public DataTable GetAllInternationalLicenseToPerson(int Person_ID)
        {
            DataTable Dt_LocalLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetInternationalLicenses";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", Person_ID);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_LocalLicenses.Load(reader);
                else
                    Dt_LocalLicenses = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_LocalLicenses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_LocalLicenses;

        }
        static public DataTable GetAllLocalLicenseToPerson(int Person_ID)
        {
            DataTable Dt_LocalLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLocalLicenses";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", Person_ID);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_LocalLicenses.Load(reader);
                else
                    Dt_LocalLicenses = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_LocalLicenses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_LocalLicenses;

        }
        static public bool IsLicenseExist(int License_ID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsLicenseExist";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsExist = (bool)result;
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }
        static public bool IsLicenseClass3(int License_ID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsLicenseClass3";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsExist = (bool)result;
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }
        static public int GetLocalAppByLicenseID(int License_ID)
        {
            int LocalApp_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLocalAppByLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);
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
        static public bool FindLicenseInformation(int License_ID, ref clsClasses.clsLicense oLicense)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "FindLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.License_ID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    oLicense.PersonName = reader.GetString(reader.GetOrdinal("FullName"));
                    oLicense.ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                    oLicense.Person_ID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                    oLicense.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                    oLicense.IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                    oLicense.ExpireDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                    oLicense.Gendor = reader.GetString(reader.GetOrdinal("Gendor"));
                    oLicense.ImagePath = reader.GetString(reader.GetOrdinal("ImagePath"));
                    oLicense.NationalNo = reader.GetString(reader.GetOrdinal("NationalNo"));
                    oLicense.Driver_ID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                    oLicense.IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                    oLicense.IsDetained = reader.GetString(reader.GetOrdinal("IsDetained"));
                    int notesIndex = reader.GetOrdinal("Notes");
                    oLicense.Notes = reader.IsDBNull(notesIndex) ? null : reader.GetString(notesIndex);
                    oLicense.IssueReason = reader.GetString(reader.GetOrdinal("IssueReason"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public bool RenewLicense(ref clsClasses.clsLicense oLicense)
        {
            
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "RenewLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalApplication_ID", oLicense.LocalDrivingLicense_ID);
            Command.Parameters.AddWithValue("@UserCreationID", oLicense.User_ID);
            Command.Parameters.AddWithValue("@License_ID", oLicense.License_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.ReLicense_ID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    oLicense.Application_ID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public bool ReplaceLicenseForDamage(ref clsClasses.clsLicense oLicense)
        {

            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "ReplaceLicenseForDamage";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserCreationID", oLicense.User_ID);
            Command.Parameters.AddWithValue("@License_ID", oLicense.License_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.ReLicense_ID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    oLicense.Application_ID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public bool ReplaceLicenseForLost(ref clsClasses.clsLicense oLicense)
        {

            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "ReplaceLicenseForLost";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@UserCreationID", oLicense.User_ID);
            Command.Parameters.AddWithValue("@License_ID", oLicense.License_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.ReLicense_ID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    oLicense.Application_ID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public bool IsLicenseActive(int License_ID) 
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsLicenseActive";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LicenseID", License_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsExist = (bool)result;
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }
        static public bool IsLicenseEnded(int License_ID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsLicenseEnded";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LicenseID", License_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsExist = (bool)result;
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }
        static public bool IsLicenseDetained(int License_ID)
        {
            bool IsDetain = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsLicenseDetained";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsDetain = (bool)result;
            }
            catch (Exception ex)
            {
                IsDetain = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsDetain;
        }
        static public int DetainedLicense(ref clsClasses.clsLicense oLicense)
        {
            oLicense.DeLicense_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "DetainedLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", oLicense.License_ID);
            Command.Parameters.AddWithValue("@CreatedByUserID", oLicense.User_ID);
            Command.Parameters.AddWithValue("@FineFees", oLicense.FineFees);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    oLicense.DeLicense_ID = insertedID;
                else
                    oLicense.DeLicense_ID = -1;
            }
            catch (Exception ex)
            {
                oLicense.DeLicense_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return oLicense.DeLicense_ID;

        }
        static public bool GetLicenseDetainedInformation(int License_ID, ref clsClasses.clsLicense oLicense)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetLicenseDetain";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.DeLicense_ID = reader.GetInt32(reader.GetOrdinal("DetainID"));
                    oLicense.FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                    oLicense.IssueDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                }
                else
                    IsFound = false;


                reader.Close();
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
        static public bool ReleaseLicense(ref clsClasses.clsLicense oLicense)
        {
            oLicense.Application_ID = -1;
            bool IsReleased = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "ReleaseLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure; 
            Command.Parameters.AddWithValue("@License_ID", oLicense.License_ID);
            Command.Parameters.AddWithValue("@UserCreationID", oLicense.User_ID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.Application_ID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                }
                else
                    IsReleased = false;

            }
            catch (Exception ex)
            {
                IsReleased = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsReleased;
        }
        static public DataTable GetDetainedLicenses() 
        {
            DataTable Dt_DetainedLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllDetainedLicenses";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_DetainedLicenses.Load(reader);
                else
                    Dt_DetainedLicenses = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_DetainedLicenses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_DetainedLicenses;
        }



    }
}
