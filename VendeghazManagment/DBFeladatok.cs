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
            {

                var vendegekDataTable = new DataTable();

                try
                {
                    
                    connection = new SqlConnection(connectionString);
                    var sqlDataAdapter = new SqlDataAdapter("SELECT * FROM vendeg", connection);

                    sqlDataAdapter.Fill(vendegekDataTable);
                 
                }
                finally
                {
                    connection.Close();

                }

                return vendegekDataTable;


            }

            

        }

        public static bool SaveVendeg(Vendeg vendeg)
        {
            try
            {

                connection = new SqlConnection(connectionString);
                connection.Open();
                var cmd = new SqlCommand("INSERT into vendeg (nev, nem, okmany_tipus, okmany_azonosito, szuletesi_datum) VALUES(@nev, @nem, @okmany_tipus, @okmany_azonosito, @szuletesi_datum)", connection);

                cmd.Parameters.Add(new SqlParameter("nev", vendeg.Nev));
                cmd.Parameters.Add(new SqlParameter("nem", (int)vendeg.Nem == 1 ? true : false));
                cmd.Parameters.Add(new SqlParameter("okmany_tipus", (byte)vendeg.OkmanyTipus));
                cmd.Parameters.Add(new SqlParameter("okmany_azonosito", vendeg.OkmanyAzonosito));
                cmd.Parameters.Add(new SqlParameter("szuletesi_datum", vendeg.SzuletesiDatum));

                EasyLog.LogMessageToFile(cmd.CommandText);
             
                cmd.ExecuteNonQuery();


            }
            finally
            {
                connection.Close();

            }

            return true;

        }
    }
}
