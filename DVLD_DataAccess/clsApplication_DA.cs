using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApplication_DA
    {

        static public bool GetAllApplicationinformation(int App_ID, ref clsClasses.clsApplicationInfo oAppInfo)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllInfoFromLocalApp";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@AppID", App_ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    oAppInfo = new clsClasses.clsApplicationInfo();
                    oAppInfo.LocalLicenseApp_ID = App_ID;
                    oAppInfo.Person_ID = Reader.GetInt32(Reader.GetOrdinal("ApplicantPersonID"));
                    oAppInfo.App_ID = Reader.GetInt32(Reader.GetOrdinal("ApplicationID"));
                    oAppInfo.PersonName = Reader.GetString(Reader.GetOrdinal("FullName"));
                    oAppInfo.ClassName = Reader.GetString(Reader.GetOrdinal("ClassName"));
                    oAppInfo.UserName = Reader.GetString(Reader.GetOrdinal("UserName"));
                    oAppInfo.PassedTestCount = Reader.GetInt32(Reader.GetOrdinal("PassedTestCount"));
                    oAppInfo.Status = Reader.GetString(Reader.GetOrdinal("Status"));
                    oAppInfo.LastStatusDate = Reader.GetDateTime(Reader.GetOrdinal("LastStatusDate"));
                    oAppInfo.App_Date = Reader.GetDateTime(Reader.GetOrdinal("ApplicationDate"));
                    oAppInfo.ApplicationTypeTitle = Reader.GetString(Reader.GetOrdinal("ApplicationTypeTitle"));
                    oAppInfo.Fees = Reader.GetDecimal(Reader.GetOrdinal("ApplicationFees"));
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
        static public bool IsApplicationExist(int App_ID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsApplicationExist";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@AppID", App_ID);
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
        static public bool DidHaveLicense(int App_ID, string ClassName)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "DidHaveLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@AppID", App_ID);
            Command.Parameters.AddWithValue("@LicenseClass", ClassName);
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
        static public bool IsApplicationCompleted(int App_ID) 
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsApplicationCompleted";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@App_ID", App_ID);

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
        static public bool IsApplicationNew(int App_ID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsAppNew";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@App_ID", App_ID);

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


    }
}
