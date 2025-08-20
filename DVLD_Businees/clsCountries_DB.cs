using DVLD_DataAccess;
using System;
using System.Data;


namespace DVLD_Businees
{
    public class clsCountries_DB
    {

        static public DataTable GetAllCountries() 
        {
            DataTable CountriesTable = clsCountries_DA.GetAllCountries();

            if (CountriesTable != null)
                return CountriesTable;
            else
                return null;
        }





    }
}
