using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eczane_Otomasyonu
{
    public partial class EczaneOtomasyon : Form
    {
        public EczaneOtomasyon()
        {
            InitializeComponent();
        }
        private void Cb_ilac_cek()
        {
            Cb_ilac.Items.Clear();
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand cbKomut = new SqlCommand("select ilac_ismi,stok from ilaclar", db.baglanti);
                //SqlCommand ilacAdet = new SqlCommand("select stok from ilaclar",db.baglanti);
                SqlDataReader read = cbKomut.ExecuteReader();
                //SqlDataReader stokRead = ilacAdet.ExecuteReader();
                while (read.Read())
                {
                    string ilacAdi = read["ilac_ismi"].ToString();

                    int adet = Convert.ToInt32(read["stok"]);

                    if (ilacAdi != "" || ilacAdi != " ")
                    {
                        if (adet != 0)
                        {
                            Cb_ilac.Items.Add(read["ilac_ismi"]);
                        }

                    }

                }

                db.baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("İlaçlar Yüklenemedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void EczaneOtomasyon_Load(object sender, EventArgs e)
        {
            Cb_ilac_cek();
        }

        private void Cb_ilac_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbAdet.Items.Clear();
            //CbAdet.SelectedIndex = 0;
            //CbAdet.Text = "1";
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();

                SqlCommand ilac_Stok = new SqlCommand("select stok from ilaclar where ilac_ismi=@ilac_adi", db.baglanti);
                ilac_Stok.Parameters.AddWithValue("@ilac_adi", Cb_ilac.SelectedItem);
                int maxAdet = Convert.ToInt32(ilac_Stok.ExecuteScalar());

                SqlCommand birim_Fiyat = new SqlCommand("select fiyat from ilaclar where ilac_ismi=@ilac_adi", db.baglanti);
                birim_Fiyat.Parameters.AddWithValue("@ilac_adi", Cb_ilac.SelectedItem);
                string fiyat = birim_Fiyat.ExecuteScalar().ToString();
                float birimFiyat = float.Parse(fiyat);

                //lblFiyat.Text = (birimFiyat + "TL").ToString();

                for (int i = 1; i <= maxAdet; i++)
                {
                    CbAdet.Items.Add(i);
                }

                db.baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("İlacın Adet Bilgisi Yüklenemedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void CbAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(CbAdet.SelectedItem);

            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand fiyatAl = new SqlCommand("select fiyat from ilaclar where ilac_ismi=@ilac_adi", db.baglanti);
                fiyatAl.Parameters.AddWithValue("@ilac_adi", Cb_ilac.SelectedItem.ToString());
                string fiyat = fiyatAl.ExecuteScalar().ToString();
                float ilac_fiyat = float.Parse(fiyat);

                lblFiyat.Text = (ilac_fiyat * adet).ToString();

                db.baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("İlacın Fiyat Bilgisi Yüklenemedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void BtnSepetEkle_Click(object sender, EventArgs e)
        {
            // ## Toplam Fiyat Hesaplama ##
            float hesap = float.Parse(lblFiyat.Text);
            float toplamHesap = float.Parse(lblToplamFiyat.Text);
            toplamHesap += hesap;
            lblToplamFiyat.Text = toplamHesap.ToString();
            // ## Fiyat Çekme ##
            LbFiyat.Items.Add(lblFiyat.Text);
            // ## İsim Çekme ##
            LbAd.Items.Add(Cb_ilac.SelectedItem);
            // ## Tarih Çekme ##
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                //   ## Üretim Tarihini Çekme ##
                SqlCommand TarihAl = new SqlCommand("select uretim_tarihi from ilaclar where ilac_ismi=@ilacadi ", db.baglanti);
                TarihAl.Parameters.AddWithValue("@ilacadi", Cb_ilac.SelectedItem.ToString());
                string tarihUretim = TarihAl.ExecuteScalar().ToString();
                LbUretim.Items.Add(tarihUretim.Substring(0, 10));
                //   ## Tüketim Tarihini Çekme ##
                SqlCommand TarihAlTuketim = new SqlCommand("select tuketim_tarihi from ilaclar where ilac_ismi=@ilacadi ", db.baglanti);
                TarihAlTuketim.Parameters.AddWithValue("@ilacadi", Cb_ilac.SelectedItem.ToString());
                string tarihTuketim = TarihAlTuketim.ExecuteScalar().ToString();
                LbTuketim.Items.Add(tarihTuketim.Substring(0, 10));
                db.baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sepete Eklenmedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.TextLength == 11)
            {
                MessageBox.Show("11 oldu");
                Database db = new Database();
                if (db.baglanti.State == ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand tcSorgu = new SqlCommand("select musteri_id,musteri_ad,musteri_soyad,tel,adres from musteri where musteri_tc=@tc", db.baglanti);
                    tcSorgu.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
                    SqlDataReader tcOku = tcSorgu.ExecuteReader();
                    if (tcOku.Read() && maskedTextBox1.TextLength == 11)
                    {
                        TbAd.Text = tcOku["musteri_ad"].ToString();
                        TbSoyad.Text = tcOku["musteri_soyad"].ToString();
                        TbTel.Text = tcOku["tel"].ToString();
                        TbAdres.Text = tcOku["adres"].ToString();
                    }
                    else if (maskedTextBox1.TextLength == 11)
                    {
                        DialogResult secenek = MessageBox.Show("Kaydı veritabanına kaydetmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (secenek == DialogResult.Yes)
                        {
                            //Veritabanına kayıt ekleyen kodlar
                        }
                        else if (secenek == DialogResult.No)
                        {
                            //Hayır seçeneğine tıklandığında çalıştırılacak kodlar
                        }

                    }
                    db.baglanti.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı bulmada HATA yaşandı !");
                }
                finally
                {
                    db.baglanti.Close();
                }
            }
        }
    }
}