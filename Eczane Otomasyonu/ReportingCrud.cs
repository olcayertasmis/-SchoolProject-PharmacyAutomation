using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    class ReportingCrud
    {
        Database db = new Database();

        public DataTable stokBitenTablosu()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                int bitenstok = 0;
                SqlCommand veriAl = new SqlCommand("select * from ilacview where stok=@stok", db.baglanti);
                veriAl.Parameters.AddWithValue("@stok", bitenstok);
                SqlDataAdapter da = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                return tablo;
                db.baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        public DataTable BugünYapilanSatis()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                DateTime dateTime = DateTime.Today;
                string bugün = dateTime.ToString();
                SqlCommand veriAl = new SqlCommand("select * from GunSonuView", db.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                return tablo;
                db.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable TarihiGecenilaclar()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                DateTime dateTime = DateTime.Today;
                string bugün = dateTime.ToString();
                SqlCommand veriAl = new SqlCommand("select * from TarihiGecenlerView", db.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                return tablo;
                db.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }

    }
}
