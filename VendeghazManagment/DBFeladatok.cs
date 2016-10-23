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
                "VendeghazManagment.Properties.Settings.ConnectionString"].ConnectionString;

        static SqlConnection connection = null;



        public static Vendeg SelectVendeg(int id)
        {

            EasyLog.LogMessageToFile("Selected vendeg is ="+id);
            SqlDataReader reader = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                var cmd = new SqlCommand("SELECT nev, nem, okmany_tipus, okmany_azonosito, szuletesi_datum FROM vendeg WHERE id=@id", connection);
                cmd.Parameters.Add(new SqlParameter("id", id));
                EasyLog.LogMessageToFile(cmd.CommandText);

                reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
      
                    //#todo: what if Vendeg id invalid?
                    throw new NotImplementedException();
                }
                
                return new Vendeg(
                    reader["nev"].ToString(),
                    (VendegNem)int.Parse(reader["nem"].ToString()),
                    (VendegOkmanyTipus)int.Parse(reader["okmany_tipus"].ToString()),
                    reader["okmany_azonosito"].ToString(),
                    reader.GetDateTime(reader.GetOrdinal("szuletesi_datum"))
               );
                

            }
            finally
            {
                connection.Close();
                reader.Close();
            }
        }
        public static DataTable VendegDataTable()
        {
            {
                var vendegekDataTable = new DataTable();
                try
                {
                    connection = new SqlConnection(connectionString);
                    var sqlDataAdapter = new SqlDataAdapter("SELECT *,concat(nev,' ', szuletesi_datum) adatok FROM vendeg", connection);
                    sqlDataAdapter.Fill(vendegekDataTable);
                }
                finally
                {
                    connection.Close();
                }
                return vendegekDataTable;
            }
        }
        public static bool UpdateVendeg(int id, Vendeg vendeg)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                EasyLog.LogMessageToFile("Update id="+id);
                EasyLog.LogMessageToFile("Update vendeg=" + vendeg);
                var cmd = new SqlCommand("UPDATE vendeg SET nev=@nev, nem=@nem, okmany_tipus=@okmany_tipus, okmany_azonosito=@okmany_azonosito, szuletesi_datum=@szuletesi_datum WHERE id =@id", connection);
                cmd.Parameters.Add(new SqlParameter("id", id));
                cmd.Parameters.Add(new SqlParameter("nev", vendeg.Nev));
                cmd.Parameters.Add(new SqlParameter("nem", (byte)vendeg.VendegNem));
                cmd.Parameters.Add(new SqlParameter("okmany_tipus", (byte)vendeg.VendegOkmanyTipus));
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

        
        public static bool DeleteVendeg(int id)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                var cmd = new SqlCommand("DELETE FROM vendeg WHERE id=@id", connection);

                cmd.Parameters.Add(new SqlParameter("id", id));
                EasyLog.LogMessageToFile(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return true;
        }


        public static bool SaveVendeg(Vendeg vendeg)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                var cmd = new SqlCommand("INSERT into vendeg (nev, nem, okmany_tipus, okmany_azonosito, szuletesi_datum) VALUES(@nev, @nem, @okmany_tipus, @okmany_azonosito, @szuletesi_datum)", connection);

                cmd.Parameters.Add(new SqlParameter("nev", vendeg.Nev));
                cmd.Parameters.Add(new SqlParameter("nem", (byte)vendeg.VendegNem));
                cmd.Parameters.Add(new SqlParameter("okmany_tipus", (byte)vendeg.VendegOkmanyTipus));
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
