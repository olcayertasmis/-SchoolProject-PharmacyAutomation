using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class HastaEkran : Form
    {
        public HastaEkran()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            MusteriCrud mc = new MusteriCrud();
            mc.ekle(TbTc.Text, TbAd.Text, TbSoyad.Text, TbTel.Text, TbAdres.Text);
            dataGridView1.DataSource = mc.tablolar();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            MusteriCrud mc = new MusteriCrud();
            int satir = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[satir].Cells["musteri_id"].Value.ToString();
            string tc = Convert.ToString(TbTc.Text);
            mc.musteriGuncelle(tc, id, TbAd.Text, TbSoyad.Text, TbTel.Text, TbAdres.Text);
            dataGridView1.DataSource = mc.tablolar();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            MusteriCrud mc = new MusteriCrud();
            int satir = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[satir].Cells["musteri_id"].Value.ToString();
            mc.musteriSil(id);
            dataGridView1.DataSource = mc.tablolar();
        }

        private void HastaEkran_Load(object sender, EventArgs e)
        {
            MusteriCrud mc = new MusteriCrud();
            dataGridView1.DataSource = mc.tablolar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TbTc.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_tc"].Value.ToString();
                TbAd.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_ad"].Value.ToString();
                TbSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["musteri_soyad"].Value.ToString();
                TbTel.Text = dataGridView1.Rows[e.RowIndex].Cells["tel"].Value.ToString();
                TbAdres.Text = dataGridView1.Rows[e.RowIndex].Cells["adres"].Value.ToString();
            }
            catch
            {

            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            YoneticiEkran AdminForm = new YoneticiEkran();
            AdminForm.Show();
            this.Hide();
        }
    }
}
