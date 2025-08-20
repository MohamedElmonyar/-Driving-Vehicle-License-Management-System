using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsCountries_DA
    {
        static public DataTable GetAllCountries() 
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllCountry";
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


    }
}
