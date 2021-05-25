using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Eczane_Otomasyonu
{
    class Personel_Islemleri
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
                SqlCommand veriAl = new SqlCommand("select * from Personeller INNER JOIN GirisPaneli ON Personeller.girisID = GirisPaneli.girispanelID", db.baglanti);
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
        public void personelGuncelle(string tc, string id, string adi, string soyadi, string kullaniciadi, string parola, string idGiris)
        {
            if (db.baglanti.State == ConnectionState.Open)
                db.baglanti.Close();
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Personeller set tc=@tc,ad=@adi,soyad=@soyadi where PersonelID=@id ", db.baglanti);
                SqlCommand guncelleGiris = new SqlCommand("update GirisPaneli set kullaniciadi=@kullaniciadi, parola=@parola where GirispanelID=@idGiris ", db.baglanti);
                guncelle.Parameters.AddWithValue("@adi", adi);
                guncelle.Parameters.AddWithValue("@soyadi", soyadi);
                guncelle.Parameters.AddWithValue("@tc", tc);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.ExecuteNonQuery();
                guncelleGiris.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                guncelleGiris.Parameters.AddWithValue("@parola", parola);
                guncelleGiris.Parameters.AddWithValue("@idGiris", idGiris);
                guncelleGiris.ExecuteNonQuery();
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
        public void personelSil(string tc)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete Personeller where tc=@tc", db.baglanti);
                sil.Parameters.AddWithValue("@tc", tc);
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
        public DataTable personelAra(string tc)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ara = new SqlCommand("select * from Personeller where where tc=@tc ", db.baglanti);
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
        public void ekle(string tc, string adi, string soyadi, string kullaniciadi, string parola)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Personeller(tc, ad, soyad) values(@tc, @adi, @soyadi)", db.baglanti);
                //SqlCommand ekle = new SqlCommand("insert into Personeller values(@tc,@adi,@soyadi,@girisID)", db.baglanti);
                SqlCommand ekleGiris = new SqlCommand("insert into GirisPaneli (kullaniciadi,parola,kontrol) values (@kullaniciadi,@parola,@kontrol) ", db.baglanti);
                ekle.Parameters.AddWithValue("@tc", tc);
                ekle.Parameters.AddWithValue("@adi", adi);
                ekle.Parameters.AddWithValue("@soyadi", soyadi);
                ekle.ExecuteNonQuery();
                ekleGiris.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                ekleGiris.Parameters.AddWithValue("@parola", parola);
                ekleGiris.Parameters.AddWithValue("@kontrol", 0);
                ekleGiris.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Personel kayıdı, başarılı bir şekilde oluşmuştur...", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
}
