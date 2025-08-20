using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDrivers_DA
    {

        static public DataTable GetAllDriver()
        {
            DataTable Dt_Drivers = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllDrivers";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_Drivers.Load(reader);
                else
                    Dt_Drivers = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_Drivers = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_Drivers;
        }



    }
}
