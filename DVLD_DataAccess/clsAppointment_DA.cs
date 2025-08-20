using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsAppointment_DA
    {

        static public DataTable GetAppointmentInformation(int Person_ID,string ClassName,string TestTypeTitle)
        {
            DataTable Appointment_Dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAppointment";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID", Person_ID);
            Command.Parameters.AddWithValue("@LicenseClass", ClassName);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                    Appointment_Dt.Load(reader);
                else
                    Appointment_Dt = null;
                reader.Close();
            }

            catch (Exception ex)
            {
                Appointment_Dt = null;
            }
            finally
            {
                connection.Close();
            }
            return Appointment_Dt;
        }
        static public bool CheckTest(int Person_ID, string ClassName, string TestTypeTitle) 
        {
            bool IsPassed = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "CheckTest";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalAppID", Person_ID);
            Command.Parameters.AddWithValue("@LicenseClass", ClassName);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsPassed = (bool)result;
            }
            catch (Exception ex)
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsPassed;


        }
        static public bool IsAppointmentActive(int Person_ID, string ClassName, string TestTypeTitle) 
        {
            bool IsPassed = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsAppointmentActive";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID", Person_ID);
            Command.Parameters.AddWithValue("@LicenseClass", ClassName);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsPassed = (bool)result;
            }
            catch (Exception ex)
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsPassed;


        }
        static public bool IsAppointmentRetakeTest(int Person_ID, string ClassName, string TestTypeTitle,ref int TestAppointmentID)
        {
            bool IsPassed = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsAppointmentRetakeTest";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID", Person_ID);
            Command.Parameters.AddWithValue("@LicenseClass", ClassName);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            SqlParameter outputParam = new SqlParameter("@AppointmentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            Command.Parameters.Add(outputParam);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsPassed = (bool)result;
                TestAppointmentID = (int)outputParam.Value;
            }
            catch (Exception ex)
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsPassed;


        }
        static public int AddNewAppointment(clsClasses.clsAppointmentInfo oAppointment) 
        {
            oAppointment.Appointment_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewTestAppointment";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@TestTypeID", oAppointment.TestType_ID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",oAppointment.LocalDrivingLicense_ID);
            Command.Parameters.AddWithValue("@AppointmentDate",oAppointment.Appointment_Date);
            Command.Parameters.AddWithValue("@PaidFees", oAppointment.PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", oAppointment.User_ID);
            Command.Parameters.AddWithValue("@IsLocked",oAppointment.IsLocked);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    oAppointment.Appointment_ID = insertedID;
                else
                    oAppointment.Appointment_ID = -1;
            }
            catch (Exception ex)
            {
                oAppointment.Appointment_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return oAppointment.Appointment_ID;
        }
        static public bool GetAppointmentDetails(int LocalDrivingLicense_ID,int TestType_ID ,ref clsClasses.clsAppointmentInfo oAppointment)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetTestDetails";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalDrivingLicense_ID", LocalDrivingLicense_ID);
            Command.Parameters.AddWithValue("@TestType_ID", TestType_ID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    oAppointment.ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                    oAppointment.PersonName = reader.GetString(reader.GetOrdinal("FullName"));
                    oAppointment.Appointment_Date = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                    oAppointment.Trial = reader.GetInt32(reader.GetOrdinal("Trial"));
                    oAppointment.Appointment_Date = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                }
                else              
                    IsFound =  false;
                
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
        static public bool UpdateAppointment(int TestAppointment_ID,int User_ID,DateTime NewAppointment_Date)
        {
            bool IsUpdated = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdateAppointment";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Appointment_ID",TestAppointment_ID);
            Command.Parameters.AddWithValue("@User_ID", User_ID);
            Command.Parameters.AddWithValue("@Appointment_Date", NewAppointment_Date);
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
        static public bool FindAppointment(int Appointment_ID,int TestTypeID,ref clsClasses.clsAppointmentInfo oAppointment) 
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "FindTestAppointment";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);
            Command.Parameters.AddWithValue("@TestType_ID", TestTypeID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    oAppointment.LocalDrivingLicense_ID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID"));
                    oAppointment.PersonName = reader.GetString(reader.GetOrdinal("FullName"));
                    oAppointment.ClassName = reader.GetString(reader.GetOrdinal("ClassName"));
                    oAppointment.Trial = reader.GetInt32(reader.GetOrdinal("Trial"));
                    oAppointment.Appointment_Date = reader.GetDateTime(reader.GetOrdinal("AppointmentDate"));
                    oAppointment.PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
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

        static public bool IsPassed(int LocalApp_ID,string TestType) 
        {
            bool IsPassed = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsPassed";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LocalApp_ID", LocalApp_ID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestType); 
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();
                IsPassed = (bool)result;
            }
            catch (Exception ex)
            {
                IsPassed = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsPassed;
        }

    }
}
