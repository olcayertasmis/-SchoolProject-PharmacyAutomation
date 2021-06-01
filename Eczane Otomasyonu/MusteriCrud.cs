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
    class MusteriCrud
    {
        Database db = new Database();
        public string durum { get; set; }
        public string sil_durum { get; set; }
        public DataTable tablolar()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("select * from musteri", db.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                return tablo;
                db.baglanti.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString()); return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void musteriGuncelle(string tc, string id, string adi, string soyadi, string telefon, string adres)
        {
            if (db.baglanti.State == ConnectionState.Open)
                db.baglanti.Close();
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update musteri set musteri_ad=@adi, musteri_soyad=@soyadi, tel=@telefon, adres=@adres,musteri_tc=@tc where musteri_id=@id ", db.baglanti);
                guncelle.Parameters.AddWithValue("@adi", adi);
                guncelle.Parameters.AddWithValue("@soyadi", soyadi);
                guncelle.Parameters.AddWithValue("@tc", tc);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.Parameters.AddWithValue("@telefon", telefon);
                guncelle.Parameters.AddWithValue("@adres", adres);
                guncelle.ExecuteNonQuery();
                durum = adi + "  " + soyadi + " İSİMLİ KİŞİNİN VERİLERİ GÜNCELLENDİ ";
                System.Windows.Forms.MessageBox.Show(durum, "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                db.baglanti.Close();
            }
            catch
            {
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void musteriSil(string id)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete musteri where musteri_id=@id", db.baglanti);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
                sil_durum = "Silme işlemi gerçekleştirildi.";
            }
            catch
            {
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable musteriAra(string tc)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from calisanlar where TC=@tc ", db.baglanti);
                ara.Parameters.AddWithValue("@tc", tc);
                SqlDataAdapter da = new SqlDataAdapter(ara);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                return tablo;
            }
            catch
            {
                return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void ekle(string tc, string adi, string soyadi, string telefon, string adres)
        {
            if (MusteriVarMi(tc) == false)
            {
                if (db.baglanti.State == System.Data.ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into musteri values(@musteri_tc, @musteri_adi, @musteri_soyadi, @tel, @adres)", db.baglanti);
                    ekle.Parameters.AddWithValue("@musteri_tc", tc);
                    ekle.Parameters.AddWithValue("@musteri_adi", adi);
                    ekle.Parameters.AddWithValue("@musteri_soyadi", soyadi);
                    ekle.Parameters.AddWithValue("@tel", telefon);
                    ekle.Parameters.AddWithValue("@adres", adres);
                    ekle.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Müşteri kayıdı, başarılı bir şekilde oluşmuştur...", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    ekle.Dispose();
                }
                catch (Exception hata)
                {
                    System.Windows.Forms.MessageBox.Show("" + hata);
                }
                finally
                {
                    db.baglanti.Close();
                }
            }

        }
        public bool MusteriVarMi(string tc)
        {
            bool varMi = false;
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand tcKontrol = new SqlCommand("select musteri_id from musteri where musteri_tc=@tc", db.baglanti);
                tcKontrol.Parameters.AddWithValue("@tc", tc);
                SqlDataReader kontrolOku = tcKontrol.ExecuteReader();
                if (kontrolOku.Read())//Müşteri Varsa ==================
                {
                    MessageBox.Show("Zaten bu Tc ile kayıtlı bir müşteri var !");
                    varMi = true;
                    return varMi;
                }
                else
                {           // Müşteri Yoksa ================
                    MessageBox.Show("yok yav olur mu");
                    varMi = false;
                    return varMi;
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Müşteri Sorgusunda Hata !" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
            return varMi;
        }
    }
}