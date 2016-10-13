using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace VendeghazManagment
{
    static class DBFeladatok
    {

        static string connectionString =
            ConfigurationManager.ConnectionStrings[
                "VendeghazManagment.Properties.Settings.VendeghazManagmentDatabaseConnectionString"].ConnectionString;

        static SqlConnection connection = null;



        public static DataTable SelectVendeg()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM vendeg", connection))
            {
                try
                {
               
                    DataTable vendegekDataTable = new DataTable();
                    sqlDataAdapter.Fill(vendegekDataTable);

                    return vendegekDataTable;

                }
                catch (Exception)
                {
                    
                    throw;
                }
                

            }

            //DBVendeg dbVendeg = new DBVendeg();
            //dbVendeg.nem = (int)vendeg.Nem==1?true:false;
            //dbVendeg.nev = vendeg.Nev;
            //dbVendeg.okmany_azonosito = vendeg.OkmanyAzonosito;
            //dbVendeg.okmany_tipus = (byte) vendeg.OkmanyTipus;
            //dbVendeg.szuletesi_datum = vendeg.SzuletesiDatum;

            //DataClassesVendeghazManagmentDataContext dataClassesVendeghazManagmentDataContext = new DataClassesVendeghazManagmentDataContext();
            //dataClassesVendeghazManagmentDataContext.DBVendegs.InsertOnSubmit(dbVendeg);


        }
    }
}
