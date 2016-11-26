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


        //Kisegítő funkció ami a bejövő hibaüzenetet hozzáfúzi a hibákhoz újsorral elválasztva
        public static void AddError(ref string error, string szoveg)
        {
            if (error != "")
                error += Environment.NewLine;
            error += szoveg;
        }

        //SQL kapcsolódásér
        public static void ConnectSQL()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DisconnectSQL()
        {
            connection.Close();
        }

        //############
        //# Vendegek #
        //############
        public static Vendeg SelectVendeg(int id)
        {

            EasyLog.LogMessageToFile("Selected vendeg is ="+id);
            SqlDataReader reader = null;
            try
            {
               
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
                reader.Close();
            }
        }
        public static DataTable VendegDataTable()
        {
            {
                var vendegekDataTable = new DataTable();
                try
                {
                    var sqlDataAdapter = new SqlDataAdapter("SELECT *,concat(nev,' ', szuletesi_datum) adatok FROM vendeg", connection);
                    sqlDataAdapter.Fill(vendegekDataTable);
                }
                finally
                {
                                   }
                return vendegekDataTable;
            }
        }
        public static bool UpdateVendeg(int id, Vendeg vendeg)
        {
            try
            {
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
               
            }
            return true;
        }

        
        public static bool DeleteVendeg(int id)
        {
            try
            {
               
                var cmd = new SqlCommand("DELETE FROM vendeg WHERE id=@id", connection);

                cmd.Parameters.Add(new SqlParameter("id", id));
                EasyLog.LogMessageToFile(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            finally
            {
              
            }
            return true;
        }


        public static bool SaveVendeg(Vendeg vendeg)
        {
              
                var cmd = new SqlCommand("INSERT into vendeg (nev, nem, okmany_tipus, okmany_azonosito, szuletesi_datum) VALUES(@nev, @nem, @okmany_tipus, @okmany_azonosito, @szuletesi_datum)", connection);

                cmd.Parameters.Add(new SqlParameter("nev", vendeg.Nev));
                cmd.Parameters.Add(new SqlParameter("nem", (byte)vendeg.VendegNem));
                cmd.Parameters.Add(new SqlParameter("okmany_tipus", (byte)vendeg.VendegOkmanyTipus));
                cmd.Parameters.Add(new SqlParameter("okmany_azonosito", vendeg.OkmanyAzonosito));
                cmd.Parameters.Add(new SqlParameter("szuletesi_datum", vendeg.SzuletesiDatum));
                EasyLog.LogMessageToFile(cmd.CommandText);
                cmd.ExecuteNonQuery();
           
            return true;
        }

        //##########
        //# Szobak #
        //##########

        public static bool SaveSzoba(Szoba szoba)
        {
           
                var cmd = new SqlCommand("INSERT into szoba (nev, emelet, felnott_hely, gyermek_hely, kiadhato, megjegyzes) VALUES(@nev, @emelet, @felnott_hely, @gyermek_hely, @kiadhato, @megjegyzes)", connection);

                cmd.Parameters.Add(new SqlParameter("nev", szoba.Nev));
                cmd.Parameters.Add(new SqlParameter("emelet", (int)szoba.Emelet));
                cmd.Parameters.Add(new SqlParameter("felnott_hely", szoba.Felnott_hely));
                cmd.Parameters.Add(new SqlParameter("gyermek_hely", szoba.Gyermek_hely));
                cmd.Parameters.Add(new SqlParameter("kiadhato", (byte)(szoba.Kiadhato==true?1:0)));
                cmd.Parameters.Add(new SqlParameter("megjegyzes", szoba.Megjegyzes.Trim()));
                EasyLog.LogMessageToFile(cmd.CommandText);
                cmd.ExecuteNonQuery();
           
            return true;
        }

        public static DataTable SzobaDataTable()
        {
            {
                var szobaDataTable = new DataTable();
                
                    var sqlDataAdapter = new SqlDataAdapter("SELECT emelet,* FROM szoba", connection);
                    sqlDataAdapter.Fill(szobaDataTable);
               
      
                return szobaDataTable;
            }
        }
    }
}
