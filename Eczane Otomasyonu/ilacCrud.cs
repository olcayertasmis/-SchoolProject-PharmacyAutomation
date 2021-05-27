using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Eczane_Otomasyonu
{
    class ilacCrud
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
                //select * from ilaclar inner join ilac_turleri on ilaclar.tur_id= ilac_turleri.tur_ismi
                //("select ilaclar.ilac_id,ilaclar.ilac_ismi,ilac_turleri.tur_ismi,ilaclar.uretim_tarihi,ilaclar.tuketim_tarihi,ilaclar.fiyat,ilaclar.stok from ilaclar inner join ilac_turleri on ilaclar.tur_id=ilac_turleri.tur_id")
                SqlCommand veriAl = new SqlCommand("select ilaclar.ilac_id,ilaclar.ilac_ismi,ilac_turleri.tur_ismi,ilaclar.uretim_tarihi,ilaclar.tuketim_tarihi,ilaclar.fiyat,ilaclar.stok,ilac_turleri.tur_id from ilaclar inner join ilac_turleri on ilaclar.tur_id=ilac_turleri.tur_id", db.baglanti);
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
        public void ilacGuncelle(string id, string ilac_adi, string soyadi, string kullaniciadi, string parola)
        {
            if (db.baglanti.State == ConnectionState.Open)
                db.baglanti.Close();
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update calisanlar set calisan_adi=@adi,calisan_soyadi=@soyadi,kullanici_adi=@kullaniciadi,parola=@parola,TC=@tc where calisan_id=@id ", db.baglanti);
                guncelle.Parameters.AddWithValue("@adi", ilac_adi);
                guncelle.Parameters.AddWithValue("@soyadi", soyadi);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                guncelle.Parameters.AddWithValue("@parola", parola);
                guncelle.ExecuteNonQuery();
                //durum = adi + "  " + soyadi + " İSİMLİ KİŞİNİN VERİLERİ GÜNCELLENDİ ";
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
        public void ilacSil(string id)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete ilaclar where ilac_id=@id", db.baglanti);
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
        public DataTable personelAra(string tc)
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
        public void ekle(string ilac_adi, float fiyat, string stok, string tur, DateTime uretimTarihi, DateTime tuketimTarihi)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand turVarmi = new SqlCommand("select tur_id from ilac_turleri where tur_ismi=@");
                SqlCommand ekle = new SqlCommand("insert into calisanlar values(@calisan_adi, @calisan_soyadi, @kullaniciadi, @parola, @yoneticimi, @tc)", db.baglanti);
                //SqlCommand ekle = new SqlCommand("insert into Personeller values(@tc,@adi,@soyadi,@girisID)", db.baglanti);
                ekle.Parameters.AddWithValue("@tc", ilac_adi);
                ekle.Parameters.AddWithValue("@calisan_adi", fiyat);
                ekle.Parameters.AddWithValue("@calisan_soyadi", stok);
                ekle.Parameters.AddWithValue("@kullaniciadi", uretimTarihi);
                ekle.Parameters.AddWithValue("@parola", tuketimTarihi);
                ekle.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Çalışan kayıdı, başarılı bir şekilde oluşmuştur...", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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