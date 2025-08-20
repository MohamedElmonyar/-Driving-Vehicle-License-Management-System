using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsClasses;

namespace DVLD_DataAccess
{
    public class clsInternationalLicense_DA
    {

        static public int AddNewInternationalLicense(clsClasses.clsInternationalLicense olicense)
        {
            olicense.InternationalLicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewInternationalLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", olicense.IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@ExpirationDate", olicense.ExpirationDate);
            Command.Parameters.AddWithValue("@CreatedByUserID", olicense.CreatedByUserID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    olicense.InternationalLicenseID = insertedID;
                else
                    olicense.InternationalLicenseID = -1;
            }
            catch (Exception ex)
            {
                olicense.InternationalLicenseID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return olicense.InternationalLicenseID;
        }

        static public bool IsInterntaionalLicenseExists(int LocalLicense_ID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsInternationalLicenseExist";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", LocalLicense_ID);
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

        static public DataTable GetAllInternationalLicense() 
        {
            DataTable Dt_InternationalLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllInternationalLicense";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_InternationalLicenses.Load(reader);
                else
                    Dt_InternationalLicenses = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_InternationalLicenses = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_InternationalLicenses;

        }
        static public bool GetInternationalLicenseInfo(int InternationalLicense_ID, ref clsClasses.clsInternationalLicense oLicense)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetInternationalInfo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@InterNational_ID", InternationalLicense_ID); 
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    oLicense.InternationalLicenseID = InternationalLicense_ID;
                    oLicense.PersonID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                    oLicense.Gendor = reader.GetString(reader.GetOrdinal("Gendor"));
                    oLicense.ImagePath = reader.GetString(reader.GetOrdinal("ImagePath"));
                    oLicense.FullName = reader.GetString(reader.GetOrdinal("FullName"));
                    oLicense.NationalNo = reader.GetString(reader.GetOrdinal("NationalNo"));
                    oLicense.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                    oLicense.IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                    oLicense.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                    oLicense.IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                    oLicense.DriverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                    oLicense.IssuedUsingLocalLicenseID = reader.GetInt32(reader.GetOrdinal("IssuedUsingLocalLicenseID"));
                }
                else
                {
                    IsFound = false;
                }

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
    }
}
