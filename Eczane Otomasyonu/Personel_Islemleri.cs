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
                SqlCommand veriAl = new SqlCommand("select * from calisanlar", db.baglanti);
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
        public void personelGuncelle(string tc, string id, string adi, string soyadi, string kullaniciadi, string parola)
        {
            if (db.baglanti.State == ConnectionState.Open)
                db.baglanti.Close();
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update calisanlar set calisan_adi=@adi,calisan_soyadi=@soyadi,kullanici_adi=@kullaniciadi,parola=@parola,TC=@tc where calisan_id=@id ", db.baglanti);
                guncelle.Parameters.AddWithValue("@adi", adi);
                guncelle.Parameters.AddWithValue("@soyadi", soyadi);
                guncelle.Parameters.AddWithValue("@tc", tc);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                guncelle.Parameters.AddWithValue("@parola", parola);
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
        public void personelSil(string id)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete calisanlar where calisan_id=@id", db.baglanti);
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
        public void ekle(string tc, string adi, string soyadi, string kullaniciadi, string parola)
        {
            if (CalisanVarMi(tc) == false && kullaniciAdiVarMi(kullaniciadi) == false)
            {
                if (db.baglanti.State == System.Data.ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into calisanlar values(@calisan_adi, @calisan_soyadi, @kullaniciadi, @parola, @yoneticimi, @tc)", db.baglanti);
                    //SqlCommand ekle = new SqlCommand("insert into Personeller values(@tc,@adi,@soyadi,@girisID)", db.baglanti);
                    ekle.Parameters.AddWithValue("@tc", tc);
                    ekle.Parameters.AddWithValue("@calisan_adi", adi);
                    ekle.Parameters.AddWithValue("@calisan_soyadi", soyadi);
                    ekle.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    ekle.Parameters.AddWithValue("@parola", parola);
                    ekle.Parameters.AddWithValue("@yoneticimi", 0);
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

        public bool CalisanVarMi(string tc)
        {
            bool varMi = false;
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand tcKontrol = new SqlCommand("select calisan_id from calisanlar where TC=@tc", db.baglanti);
                tcKontrol.Parameters.AddWithValue("@tc", tc);
                SqlDataReader kontrolOku = tcKontrol.ExecuteReader();
                if (kontrolOku.Read())//Calışan Varsa ==================
                {
                    MessageBox.Show("Zaten bu Tc ile kayıtlı bir Çalışan var !");
                    varMi = true;
                    return varMi;
                }
                else
                {           // Müşteri Yoksa ================
                    varMi = false;
                    return varMi;
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Çalışan Sorgusunda Hata !" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
            return varMi;
        }

        public bool kullaniciAdiVarMi(string kullanici_adi)
        {
            bool varMi = false;
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kaKontrol = new SqlCommand("select calisan_id from calisanlar where kullanici_adi=@k_adi", db.baglanti);
                kaKontrol.Parameters.AddWithValue("@k_adi", kullanici_adi);
                SqlDataReader kontrolOku = kaKontrol.ExecuteReader();
                if (kontrolOku.Read())//Calışan Varsa ==================
                {
                    MessageBox.Show("Zaten bu Kullanıcı adı ile kayıtlı bir Çalışan var !");
                    varMi = true;
                    return varMi;
                }
                else
                {           // Müşteri Yoksa ================

                    varMi = false;
                    return varMi;
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Çalışan Sorgusunda Hata !" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
            return varMi;
        }
    }
}