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
    public partial class IlacEkran : Form
    {
        public IlacEkran()
        {
            InitializeComponent();
        }

        private void IlacEkran_Load(object sender, EventArgs e)
        {
            ilacCrud ic = new ilacCrud();
            dataGridView1.DataSource = ic.tablolar();
            CbilacTur.Items.Clear();
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand cbKomut = new SqlCommand("select tur_ismi from ilac_turleri", db.baglanti);
                SqlDataReader read = cbKomut.ExecuteReader();
                while (read.Read())
                {
                    CbilacTur.Items.Add(read["tur_ismi"]);
                }

                db.baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("İlaç Türleri Yüklenemedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[satir].Cells["ilac_id"].Value.ToString();
            ilacCrud ic = new ilacCrud();
            ic.ilacSil(id);
            dataGridView1.DataSource = ic.tablolar();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            ilacCrud ic = new ilacCrud();
            int satir = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[satir].Cells["ilac_id"].Value.ToString();
            float deger = float.Parse(TbFiyat.Text);
            string tur = CbilacTur.SelectedItem.ToString();
            ic.ilacGuncelle(id, TbAd.Text, tur, deger, TbAdet.Text, DtUretim.Value, DtSonKullanim.Value);
            dataGridView1.DataSource = ic.tablolar();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ilacCrud ic = new ilacCrud();
            if (CbilacTur.SelectedItem == null || TbAd.Text == null || TbAd.Text == "" || TbAd.Text == " " || TbAdet.Text == "" || TbFiyat.Text == "")
            {
                MessageBox.Show("Boş Kutucuk Bırakmayınız");
            }
            else
            {
                float deger = float.Parse(TbFiyat.Text);
                string tur = CbilacTur.SelectedItem.ToString();
                ic.ekle(TbAd.Text, deger, TbAdet.Text, tur, DtUretim.Value, DtSonKullanim.Value);
                dataGridView1.DataSource = ic.tablolar();
            }
        }
        private void TbFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && TbFiyat.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }


        private void BtnTurEkle_Click(object sender, EventArgs e)
        {
            ilacCrud ic = new ilacCrud();
            ic.turEkle(TbYenilac.Text);
            CbilacTur.Items.Clear();
            Database db = new Database();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand cbKomut = new SqlCommand("select tur_ismi from ilac_turleri", db.baglanti);
                SqlDataReader read = cbKomut.ExecuteReader();
                while (read.Read())
                {
                    CbilacTur.Items.Add(read["tur_ismi"]);
                }

                db.baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("İlaç Türleri Yüklenemedi !");
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbAd.Text = dataGridView1.Rows[e.RowIndex].Cells["ilac_ismi"].Value.ToString();
            TbAdet.Text = dataGridView1.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            TbFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["fiyat"].Value.ToString();
            CbilacTur.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["tur_ismi"].Value.ToString();
            DtUretim.Text = dataGridView1.Rows[e.RowIndex].Cells["uretim_tarihi"].Value.ToString();
            DtSonKullanim.Text = dataGridView1.Rows[e.RowIndex].Cells["tuketim_tarihi"].Value.ToString();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            YoneticiEkran AdminForm = new YoneticiEkran();
            AdminForm.Show();
            this.Hide();
        }

        private void TbAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}