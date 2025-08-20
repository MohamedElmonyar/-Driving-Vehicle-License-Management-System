using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTests_DA
    {

        static public int AddNewTest(clsClasses.clsTestsInfo oTest) 
        {
            oTest.Test_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewTest";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@TestAppointmentID",oTest.TestAppointment_ID);
            Command.Parameters.AddWithValue("@TestResult",oTest.Result);
            if (oTest.Notes != string.Empty)
            Command.Parameters.AddWithValue("@Notes", oTest.Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", oTest.User_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    oTest.Test_ID = insertedID;
                else
                    oTest.Test_ID = -1;
            }
            catch (Exception ex)
            {
                oTest.Test_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return oTest.Test_ID;

        }





    }
}
