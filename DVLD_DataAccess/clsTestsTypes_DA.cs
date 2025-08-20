using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestsTypes_DA
    {
        static public DataTable GetAllTests() 
        {
            DataTable Dt_TestsTypes = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllTests";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Dt_TestsTypes.Load(reader);
                else
                    Dt_TestsTypes = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Dt_TestsTypes = null;
            }
            finally
            {
                connection.Close();
            }
            return Dt_TestsTypes;
        }
        static public bool GetTest(int Test_ID, ref clsClasses.clsTestsTypes oTest)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetTest";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@TestID", Test_ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    oTest.Test_ID = Test_ID;
                    oTest.Title = (string)Reader["TestTypeTitle"];
                    oTest.Description = (string)Reader["TestTypeDescription"];  
                    oTest.Fees = (decimal)Reader["TestTypeFees"];
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
        static public bool UpdateTest(clsClasses.clsTestsTypes oTests)
        {
            bool IsUpdated = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdateTest";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@TestID", oTests.Test_ID);
            Command.Parameters.AddWithValue("@TestTypeTitle", oTests.Title);
            Command.Parameters.AddWithValue("@TestTypeDescription ", oTests.Description);
            Command.Parameters.AddWithValue("@Fees", oTests.Fees);
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
