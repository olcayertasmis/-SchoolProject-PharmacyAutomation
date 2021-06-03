using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    class Giris
    {
        Database db = new Database();
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut { get; set; }
        public Boolean yoneticimi_tut = false;
        public string girisDurumu { get; set; }
        public static string myid;

        public void girisYap(string kullanıcı_adi, string kullanıcı_sifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                db.baglanti.Open();
                SqlCommand loginName = new SqlCommand("select kullanici_adi from calisanlar where kullanici_adi=@kulAdi", db.baglanti);
                loginName.Parameters.AddWithValue("@kulAdi", kullanıcı_adi);
                SqlDataReader kulAdi_Oku = loginName.ExecuteReader();
                if (kulAdi_Oku.Read())
                {
                    kullaniciAdi_tut = kulAdi_Oku["kullanici_adi"].ToString();
                    
                    SqlCommand loginPw = new SqlCommand("select * from calisanlar where parola = @sifre", db.baglanti);
                    loginPw.Parameters.AddWithValue("@sifre", kullanıcı_sifre);
                    SqlDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if (loginPw_Oku.Read())
                    {
                        myid = loginPw_Oku["calisan_id"].ToString();
                        kullaniciSifre_tut = loginPw_Oku["parola"].ToString();

                        girisDurumu = kullaniciAdi_tut + "" + kullaniciSifre_tut;
                        SqlCommand yonetici = new SqlCommand("select yoneticimi from calisanlar where kullanici_adi=@kulAdi", db.baglanti);
                        yonetici.Parameters.AddWithValue("@kulAdi", kullanıcı_adi);
                        SqlDataReader yonetici_Oku = yonetici.ExecuteReader();
                        if (yonetici_Oku.Read())
                        {
                            if (yonetici_Oku["yoneticimi"].ToString() == "True")
                            {
                                yoneticimi_tut = true;
                            }
                            else
                            {
                                yoneticimi_tut = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("parolayı yanlış girdin..", "Hata | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loginPw.Dispose();
                    loginPw_Oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdin..", "Hata | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_Oku.Close();
                db.baglanti.Close();

            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}