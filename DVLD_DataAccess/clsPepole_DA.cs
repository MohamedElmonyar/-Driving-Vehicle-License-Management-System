using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    static public class clsPepole_DA
    {
        static private bool _GetPersoneByID(int ID, ref clsClasses.clsPeopleInformation sPeople)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetPersonByID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    sPeople.ID = ID;
                    sPeople.NationalNo = (string)Reader["NationalNo"];
                    sPeople.FirstName = (string)Reader["FirstName"];
                    sPeople.SecondName = (string)Reader["SecondName"];
                    sPeople.ThirdName = (string)Reader["ThirdName"];
                    sPeople.LastName = (string)Reader["LastName"];
                    sPeople.DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    sPeople.Gendor = (bool)Reader["Gendor"];
                    sPeople.Address = (string)Reader["Address"];
                    sPeople.Phone = (string)Reader["Phone"];
                    if (Reader["Email"] != DBNull.Value)
                        sPeople.Email = (string)Reader["Email"];
                    else
                        sPeople.Email = "";
                    if (Reader["ImagePath"] != DBNull.Value)
                        sPeople.ImagePath = (string)Reader["ImagePath"];
                    else
                        sPeople.ImagePath = "";
                    sPeople.CountryName = (string)Reader["CountryName"];
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
        static private bool _GetPersoneByNationalNumber(string NationalNo, ref clsClasses.clsPeopleInformation sPeople)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetPersonByNationalNumber";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@NationalNumber", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    sPeople.ID = (int)Reader["PersonID"];
                    sPeople.NationalNo = (string)Reader["NationalNo"];
                    sPeople.FirstName = (string)Reader["FirstName"];
                    sPeople.SecondName = (string)Reader["SecondName"];
                    sPeople.ThirdName = (string)Reader["ThirdName"];
                    sPeople.LastName = (string)Reader["LastName"];
                    sPeople.DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    sPeople.Gendor = (bool)Reader["Gendor"];
                    sPeople.Address = (string)Reader["Address"];
                    sPeople.Phone = (string)Reader["Phone"];
                    if (Reader["Email"] != DBNull.Value)
                       sPeople.Email = (string)Reader["Email"];
                    else
                        sPeople.Email = "";
                    if (Reader["ImagePath"] != DBNull.Value)
                       sPeople.ImagePath = (string)Reader["ImagePath"];
                    else
                        sPeople.ImagePath = "";
                    sPeople.CountryName = (string)Reader["CountryName"];
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
        static public bool IsPersonExist(int ID)
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsPersonExist";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID", ID);
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
        static public bool IsPersonExist(string NationalNumber) 
        {
            bool IsFound = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsPersonExistByNationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
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
        static public bool GetPersonByID(int ID,ref clsClasses.clsPeopleInformation sPeople)
        {
            if (!IsPersonExist(ID))
                return false;
            if (!_GetPersoneByID(ID, ref sPeople))
                return false;
            else
                return true;
        }
        static public bool GetPersonByNationalNumber(string NationalNumber, ref clsClasses.clsPeopleInformation sPeople) 
        {
            if (!IsPersonExist(NationalNumber))
                return false;
            if (!_GetPersoneByNationalNumber(NationalNumber, ref sPeople))
                return false;
            else
                return true;

        }
        static public int AddNewPerson(clsClasses.clsPeopleInformation sPeople)
        {
            sPeople.ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "AddNewPerson";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@NationalNo",  sPeople.NationalNo);
            Command.Parameters.AddWithValue("@FirstName",   sPeople.FirstName);
            Command.Parameters.AddWithValue("@SecoundName", sPeople.SecondName);
            Command.Parameters.AddWithValue("@ThirdName",   sPeople.ThirdName);
            Command.Parameters.AddWithValue("@LastName",    sPeople.LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", sPeople.DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor",      sPeople.Gendor);
            Command.Parameters.AddWithValue("@Address",     sPeople.Address);
            Command.Parameters.AddWithValue("@Phone",       sPeople.Phone);
            Command.Parameters.AddWithValue("@CountryName", sPeople.CountryName);
            Command.Parameters.AddWithValue("@Email", sPeople.Email);
            if (sPeople.ImagePath == null)
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", sPeople.ImagePath);

            try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        sPeople.ID = insertedID;
                    else
                        sPeople.ID = -1;
                }
                catch (Exception ex)
                {
                    sPeople.ID = -1;
                }
                finally
                {
                    Connection.Close();
                }
            return sPeople.ID;
        }
        static public bool UpdatePerson(clsClasses.clsPeopleInformation sPeople) 
        {
            bool IsUpdated = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "UpdatePerson";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID",    sPeople.ID);
            Command.Parameters.AddWithValue("@NationalNo",  sPeople.NationalNo);
            Command.Parameters.AddWithValue("@FirstName",   sPeople.FirstName);
            Command.Parameters.AddWithValue("@SecondName", sPeople.SecondName);
            Command.Parameters.AddWithValue("@ThirdName",   sPeople.ThirdName);
            Command.Parameters.AddWithValue("@LastName",    sPeople.LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", sPeople.DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor",      sPeople.Gendor);
            Command.Parameters.AddWithValue("@Address",     sPeople.Address);
            Command.Parameters.AddWithValue("@Phone",       sPeople.Phone);
            Command.Parameters.AddWithValue("@CountryName", sPeople.CountryName);
            Command.Parameters.AddWithValue("@Email", sPeople.Email);
            if (sPeople.ImagePath == null)
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", sPeople.ImagePath);
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
        static private bool DeletePerson(int Person_ID) 
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "DeletePerson";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@PersonID",Person_ID);
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
        static private bool IsRelated(int Person_ID) 
        {
            bool Yes = true;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "IsRelated";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Person_ID", Person_ID);
            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                Yes = (bool)result;
            }
            catch (Exception ex)
            {
                Yes = false;
            }
            finally
            {
                Connection.Close();
            }
            return Yes;

        }
        static public bool DeletePersons(int Person_ID)
        {
            if (IsRelated(Person_ID))
                return false;
            else      
                return DeletePerson(Person_ID);            
        }
        static public DataTable GetAllPepole() 
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connection);
            string Query = "GetAllPepole";
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
        static public int GetPersonByLocalApp(int LocalApp_ID) 
        {
            int Person_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "FindPersonIDByLocalAppID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@LoaclApp_ID", LocalApp_ID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    Person_ID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                }
                else
                    Person_ID = -1;
                reader.Close();
            }
            catch (Exception ex)
            {
                Person_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return Person_ID;
        }
        static public int GetPersonByLicenseID(int License_ID)
        {
            int Person_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetPersonIDByLicense";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@License_ID", License_ID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    Person_ID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                }
                else
                    Person_ID = -1;
                reader.Close();
            }
            catch (Exception ex)
            {
                Person_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return Person_ID;
        }

        static public int GetPersonByInterLicenseID(int InterLicense_ID)
        {
            int Person_ID = -1;
            SqlConnection Connection = new SqlConnection(clsConnection.connection);
            string Query = "GetPersonIDByInternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@International_LicenseID", InterLicense_ID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    Person_ID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                }
                else
                    Person_ID = -1;
                reader.Close();
            }
            catch (Exception ex)
            {
                Person_ID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return Person_ID;
        }
    }


}
