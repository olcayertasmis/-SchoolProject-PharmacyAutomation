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
                SqlDataReader read = cbKomut.ExecuteReader();
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
            VisibleFalseYap();
            BtnMusteriGüncelle.Visible = false;
            TbTc.Enabled = true;
        }

        private void Cb_ilac_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbAdet.Items.Clear();

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

                lblFiyat.Text = (birimFiyat).ToString();

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
            if (Cb_ilac.Text == "" || Cb_ilac.Text == null)
            {
                MessageBox.Show("İlaç Seçmeden Adet Seçemezsiniz ! ", "Hata | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

        }

        private void BtnSepetEkle_Click(object sender, EventArgs e)
        {
            if (Cb_ilac.Text == "" || Cb_ilac.Text == null || CbAdet.Text == "" || CbAdet.Text == null)
            {
                MessageBox.Show("İlaç veya ilac'ın adet bilgisi boş bırakılamaz ! ", "Hata | Eczane Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                // ## Adet Çekme ##============================
                LbAdet.Items.Add(CbAdet.SelectedItem);
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
                    LbUretim.Items.Add(tarihUretim.TrimEnd('0', ':', '.'));
                    //   ## Tüketim Tarihini Çekme ##
                    SqlCommand TarihAlTuketim = new SqlCommand("select tuketim_tarihi from ilaclar where ilac_ismi=@ilacadi ", db.baglanti);
                    TarihAlTuketim.Parameters.AddWithValue("@ilacadi", Cb_ilac.SelectedItem.ToString());
                    string tarihTuketim = TarihAlTuketim.ExecuteScalar().ToString();
                    LbTuketim.Items.Add(tarihTuketim.TrimEnd('0', ':', '.'));
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

        }

        private void TbTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TbTc_TextChanged(object sender, EventArgs e)
        {
            if (TbTc.TextLength == 11)
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
                    tcSorgu.Parameters.AddWithValue("@tc", TbTc.Text);
                    SqlDataReader tcOku = tcSorgu.ExecuteReader();
                    if (tcOku.Read())//Müşteri Bulunduysa =============================================
                    {
                        if (Cb_islem.Text == "Güncelle")
                        {
                            BtnMusteriGüncelle.Visible = false;
                        }
                        else
                        {
                            BtnMusteriGüncelle.Visible = true;
                        }
                        lblAd.Visible = true;
                        lblSoyad.Visible = true;
                        lblTel.Visible = true;
                        lblAdres.Visible = true;

                        TbAd.Visible = true;
                        TbSoyad.Visible = true;
                        TbTel.Visible = true;
                        TbAdres.Visible = true;

                        TbAd.Text = tcOku["musteri_ad"].ToString();
                        TbSoyad.Text = tcOku["musteri_soyad"].ToString();
                        TbTel.Text = tcOku["tel"].ToString();
                        TbAdres.Text = tcOku["adres"].ToString();
                    }
                    else //Müşteri bulunamazsa ===============================
                    {
                        DialogResult secenek = MessageBox.Show("Müşteri Bulunamadı, Yeni Müşteri Kayıdı Veya Güncelleme Yapmak İster Misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (secenek == DialogResult.Yes)
                        {

                            TbTc.Enabled = false;
                            lblAd.Visible = true;
                            lblSoyad.Visible = true;
                            lblTc.Visible = true;
                            lblTel.Visible = true;
                            lblAdres.Visible = true;
                            lbl_islem.Visible = true;

                            TbAd.Clear();
                            TbAd.Visible = true;
                            TbSoyad.Clear();
                            TbSoyad.Visible = true;
                            TbTcEkle.Text = TbTc.Text;
                            TbTcEkle.Visible = true;
                            TbTel.Clear();
                            TbTel.Visible = true;
                            TbAdres.Clear();
                            TbAdres.Visible = true;

                            BtnMusteriKaydet.Visible = true;
                            BtnIptal.Visible = true;
                            BtnMusteriGüncelle.Visible = false;

                            Cb_islem.SelectedItem = "Ekle";
                            Cb_islem.Visible = true;
                        }
                        else if (secenek == DialogResult.No)
                        {
                            TbTc.Enabled = true;
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            VisibleFalseYap();
            lblTc.Text = "TC:";
            TbTc.Enabled = true;
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (TbAd.Text == "" || TbAd.Text == " " || TbAdres.Text == "" || TbAdres.Text == " " || TbSoyad.Text == "" || TbSoyad.Text == " " || TbTc.Text == "" || TbTc.Text == null || TbTcEkle.Text == "" || TbTcEkle.Text == null || TbTel.Text == "" || TbTel.Text == " ")
            {
                MessageBox.Show("Lütfen Boş Kutucuk Bırakmayınız");
            }
            else
            {
                if ((Cb_islem.SelectedItem).ToString() == "Ekle")
                {
                    lblTc.Text = "TC:";
                    MusteriCrud mc = new MusteriCrud();
                    mc.ekle(TbTcEkle.Text, TbAd.Text, TbSoyad.Text, TbTel.Text, TbAdres.Text);
                }
                else if ((Cb_islem.SelectedItem).ToString() == "Güncelle")
                {
                    MessageBox.Show("Güncellicek inş");
                    Database db = new Database();
                    if (db.baglanti.State == ConnectionState.Open)
                    {
                        db.baglanti.Close();
                    }
                    try
                    {
                        db.baglanti.Open();
                        SqlCommand musteriBul = new SqlCommand("select musteri.musteri_id from musteri where musteri_tc=@musteri_tc", db.baglanti);
                        musteriBul.Parameters.AddWithValue("@musteri_tc", TbTc.Text);
                        MessageBox.Show("buraya kadar geldikkk");
                        SqlDataReader idOku = musteriBul.ExecuteReader();
                        if (idOku.Read())
                        {
                            string id = idOku["musteri_id"].ToString();
                            MessageBox.Show("buraya kadar geldik" + id);
                            MusteriCrud mc = new MusteriCrud();
                            mc.musteriGuncelle(TbTcEkle.Text, id, TbAd.Text, TbSoyad.Text, TbTel.Text, TbAdres.Text);
                        }

                        db.baglanti.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kişi Bilgileri bulunamadı !");
                    }
                    finally
                    {
                        lblTc.Text = "TC:";
                        db.baglanti.Close();
                    }
                }
            }
        }

        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            int kac_urun = LbAd.Items.Count;
            if (kac_urun != 0)
            {
                for (int i = 0; i < kac_urun; i++)
                {
                    string tc = TbTc.Text;
                    string ad = LbAd.Items[i].ToString();
                    string fiyat = LbFiyat.Items[i].ToString();
                    int adet = Convert.ToInt32(LbAdet.Items[i]);
                    float birimSatisFiyat = ((float.Parse(fiyat)) / adet);
                    DateTime satisTarihi = DateTime.Now;

                    satis_ekle(tc, ad, birimSatisFiyat, satisTarihi, adet);
                }
            }
            else
            {
                MessageBox.Show("Sepete İlaç Eklemeden Satış Yapamazsın");
            }
        }
        private void satis_ekle(string musteri_tc, string ilac_ad, float satis_fiyati, DateTime satis_tarihi, int adet)
        {
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                // =========== Musteri ID Alma
                SqlCommand musteriTcBul = new SqlCommand("select musteri_id from musteri where musteri_tc=@musteri_tc", db.baglanti);
                musteriTcBul.Parameters.AddWithValue("@musteri_tc", musteri_tc);
                int musteri_id = Convert.ToInt32(musteriTcBul.ExecuteScalar());
                // =============== İlaç ID Alma
                SqlCommand ilacIdBul = new SqlCommand("select ilac_id from ilaclar where ilac_ismi=@ilac_adi", db.baglanti);
                ilacIdBul.Parameters.AddWithValue("@ilac_adi", ilac_ad);
                int ilac_id = Convert.ToInt32(ilacIdBul.ExecuteScalar());

                //SqlCommand satisEkle = new SqlCommand("insert into ilac_satis values(@musteri_id,@ilac_id,@satis_fiyati,@satis_tarihi,@adet)", db.baglanti);
                //satisEkle.Parameters.AddWithValue("@musteri_id", musteri_id);
                //satisEkle.Parameters.AddWithValue("@ilac_id", ilac_id);
                //satisEkle.Parameters.AddWithValue("@satis_fiyati", satis_fiyati);
                //satisEkle.Parameters.AddWithValue("@satis_tarihi", satis_tarihi);
                //satisEkle.Parameters.AddWithValue("@adet", adet);

                // =================== İlaç Log
                SqlCommand login = new SqlCommand("insert into Log(personel_id,aciklama,tarih) values(@personel_id,@aciklama,@tarih)", db.baglanti);
                login.Parameters.AddWithValue("@personel_id", Giris.myid);
                login.Parameters.AddWithValue("@aciklama", musteri_tc + " kimlikli hastaya " + ilac_ad + " adlı ilaçtan " + adet + " adet verildi.");
                login.Parameters.AddWithValue("@tarih", DateTime.Now);
                login.ExecuteNonQuery();

                // =================== Satış Ekleme
                SqlCommand spSatisEkle = new SqlCommand("sp_Satis_Yap", db.baglanti);
                spSatisEkle.CommandType = CommandType.StoredProcedure; //STORED PROCEDURE İLE SATIŞ
                spSatisEkle.Parameters.AddWithValue("@musteri_id", musteri_id);
                spSatisEkle.Parameters.AddWithValue("@ilac_id", ilac_id);
                spSatisEkle.Parameters.AddWithValue("@satis_fiyati", satis_fiyati);
                spSatisEkle.Parameters.AddWithValue("@satis_tarihi", satis_tarihi);
                spSatisEkle.Parameters.AddWithValue("@adet", adet);
                spSatisEkle.ExecuteNonQuery();

                MessageBox.Show(" OLLEY PARA");

                db.baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Satış Kayıdı Oluşturulamadı !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void btnListeSil_Click(object sender, EventArgs e)
        {
            LbAd.Items.Clear();
            LbAdet.Items.Clear();
            LbFiyat.Items.Clear();
            LbTuketim.Items.Clear();
            LbUretim.Items.Clear();
        }

        private void VisibleFalseYap()
        {
            lblAd.Visible = false;
            lblSoyad.Visible = false;
            lblTc.Visible = false;
            lblTel.Visible = false;
            lblAdres.Visible = false;
            lbl_islem.Visible = false;

            TbAd.Visible = false;
            TbSoyad.Visible = false;
            TbAdres.Visible = false;
            TbTcEkle.Visible = false;
            TbTel.Visible = false;

            BtnMusteriKaydet.Visible = false;
            BtnIptal.Visible = false;

            Cb_islem.SelectedItem = "Ekle";
            Cb_islem.Visible = false;
            TbTc.Text = "";
        }

        private void Cb_islem_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((Cb_islem.SelectedItem).ToString() == "Ekle")
            {
                lblTc.Text = "TC:";
                TbTc.Enabled = false;
            }
            else if ((Cb_islem.SelectedItem).ToString() == "Güncelle")
            {
                TbTc.Enabled = true;
            }
        }

        private void BtnMusteriGüncelle_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand musteriBul = new SqlCommand("select musteri.musteri_id from musteri where musteri_tc=@musteri_tc", db.baglanti);
                musteriBul.Parameters.AddWithValue("@musteri_tc", TbTc.Text);
                MessageBox.Show("buraya kadar geldikkk");
                SqlDataReader idOku = musteriBul.ExecuteReader();
                if (idOku.Read())
                {
                    string id = idOku["musteri_id"].ToString();
                    MusteriCrud mc = new MusteriCrud();
                    mc.musteriGuncelle(TbTc.Text, id, TbAd.Text, TbSoyad.Text, TbTel.Text, TbAdres.Text);
                }
                db.baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Bilgileri bulunamadı !");
            }
            finally
            {
                lblTc.Text = "TC:";
                db.baglanti.Close();
            }
        }
    }
}