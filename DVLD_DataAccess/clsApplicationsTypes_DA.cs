using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApplicationsTypes_DA
    {
        static public DataTable GetAllApplicationsTypes()
        {
            DataTable Dt_MaAppType = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetApplicationsTypes";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_MaAppType.Load(reader);
                else
                    Dt_MaAppType = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_MaAppType = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_MaAppType;

        }
        static public bool GetApplication(int App_ID,ref clsClasses.clsApplicationsTypes oAppType) 
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetApplication";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@AppID", App_ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    oAppType.App_ID = App_ID;
                    oAppType.Title = (string)Reader["ApplicationTypeTitle"];
                    oAppType.Fees = (decimal)Reader["ApplicationFees"];
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
        static public bool UpdateAppFees(int AppID,decimal Fees)
        {
            bool IsUpdated = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdateApplication";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@AppID", AppID);
            Command.Parameters.AddWithValue("@Fees", Fees);
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
        
    }
}
