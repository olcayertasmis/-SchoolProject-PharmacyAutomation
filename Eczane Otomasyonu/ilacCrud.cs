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
                //SqlCommand veriAl = new SqlCommand("select ilaclar.ilac_id,ilaclar.ilac_ismi,ilac_turleri.tur_ismi,ilaclar.uretim_tarihi,ilaclar.tuketim_tarihi,ilaclar.fiyat,ilaclar.stok,ilac_turleri.tur_id from ilaclar inner join ilac_turleri on ilaclar.tur_id=ilac_turleri.tur_id", db.baglanti);
                SqlCommand veriAl = new SqlCommand("select * from ilacview", db.baglanti); //View Kullanıldı
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
        public void ilacGuncelle(string id, string ilac_adi, string tur, float fiyat, string stok, DateTime uretimTarihi, DateTime tuketimTarihi)
        {
            if (db.baglanti.State == ConnectionState.Open)
                db.baglanti.Close();
            try
            {
                db.baglanti.Open();
                SqlCommand turIdAl = new SqlCommand("select ilac_turleri.tur_id from ilac_turleri where tur_ismi=@turIsmi", db.baglanti);
                turIdAl.Parameters.AddWithValue("@turIsmi", tur);
                int tur_id = Convert.ToInt32(turIdAl.ExecuteScalar());
                SqlCommand guncelle = new SqlCommand("update ilaclar set ilac_ismi= @ilac_adi,tur_id= @tur_id,uretim_tarihi= @uretimTarihi,tuketim_tarihi= @tuketimTarihi,fiyat= @fiyat,stok=@stok where ilac_id= @id ", db.baglanti);
                guncelle.Parameters.AddWithValue("@ilac_adi", ilac_adi);
                guncelle.Parameters.AddWithValue("@tur_id", tur_id);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.Parameters.AddWithValue("@fiyat", fiyat);
                guncelle.Parameters.AddWithValue("@stok", stok);
                guncelle.Parameters.AddWithValue("@uretimTarihi", uretimTarihi);
                guncelle.Parameters.AddWithValue("@tuketimTarihi", tuketimTarihi);
                guncelle.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(ilac_adi + " Adlı İlaç Güncellendi", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
            if (IlacVarMi(ilac_adi) == false)
            {
                if (db.baglanti.State == ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand turIdAl = new SqlCommand("select ilac_turleri.tur_id from ilac_turleri where tur_ismi=@turIsmi", db.baglanti);
                    turIdAl.Parameters.AddWithValue("@turIsmi", tur);
                    int tur_id = Convert.ToInt32(turIdAl.ExecuteScalar());
                    SqlCommand ekle = new SqlCommand("insert into ilaclar values( @ilac_adi, @tur_id, @uretimTarihi, @tuketimTarihi, @fiyat, @stok)", db.baglanti);
                    ekle.Parameters.AddWithValue("@ilac_adi", ilac_adi);
                    ekle.Parameters.AddWithValue("@fiyat", fiyat);
                    ekle.Parameters.AddWithValue("@stok", stok);
                    ekle.Parameters.AddWithValue("@uretimTarihi", uretimTarihi);
                    ekle.Parameters.AddWithValue("@tuketimTarihi", tuketimTarihi);
                    ekle.Parameters.AddWithValue("@tur_id", tur_id);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("İlaç kayıdı, başarılı bir şekilde oluşmuştur...", "İlaç Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ekle.Dispose();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("" + hata);
                }
                finally
                {
                    db.baglanti.Close();
                }
            }

        }
        public void turEkle(string tur_adi)
        {
            if (IlacTuruVarMi(tur_adi) == false)
            {
                if (db.baglanti.State == ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand tur_ekle = new SqlCommand("insert into ilac_turleri values(@ilac_türü)", db.baglanti);
                    tur_ekle.Parameters.AddWithValue("@ilac_türü", tur_adi);
                    tur_ekle.ExecuteNonQuery();

                    MessageBox.Show("İlaç Türü Eklendi !", "İşlem Başarılı | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tur_ekle.Dispose();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İlaç Türü Eklenemedi ! " + hata, "İşlem Başarısız | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.baglanti.Close();
                }
            }

        }
        public bool IlacVarMi(string ilacAd) //İlaç AD'I Var mı yok mu
        {
            bool varMi = false;
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand adKontrol = new SqlCommand("select ilac_id from ilaclar where ilac_ismi=@ad", db.baglanti);
                adKontrol.Parameters.AddWithValue("@ad", ilacAd);
                SqlDataReader kontrolOku = adKontrol.ExecuteReader();
                if (kontrolOku.Read())//Müşteri Varsa ==================
                {
                    MessageBox.Show("Zaten bu isim ile kayıtlı bir ilaç var !");
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
                MessageBox.Show("İlaç Sorgusunda Hata !" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
            return varMi;
        }

        public bool IlacTuruVarMi(string turAd) //İlaç Türü Var mı yok mu kontrolü
        {
            bool varMi = false;
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand turKontrol = new SqlCommand("select tur_id from ilac_turleri where tur_ismi=@ad", db.baglanti);
                turKontrol.Parameters.AddWithValue("@ad", turAd);
                SqlDataReader kontrolOku = turKontrol.ExecuteReader();
                if (kontrolOku.Read())//İlaç Türü varsa ==================
                {
                    MessageBox.Show("Zaten bu isim ile kayıtlı bir İlaç Türü var !");
                    varMi = true;
                    return varMi;
                }
                else
                {           // İlaç Türü Yoksa ================
                    MessageBox.Show("yok yav olur mu");
                    varMi = false;
                    return varMi;
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Tür Sorgusunda Hata !" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
            return varMi;
        }
    }
}