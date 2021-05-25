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
    public partial class PersonelEkran : Form
    {
        public PersonelEkran()
        {
            InitializeComponent();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Personel_Islemleri pe = new Personel_Islemleri();
            int satir = dataGridView1.CurrentRow.Index;
            string id = dataGridView1.Rows[satir].Cells["personelID"].Value.ToString();
            string idGiris = dataGridView1.Rows[satir].Cells["girispanelID"].Value.ToString();
            string tc = Convert.ToString(TbTc.Text);
            pe.personelGuncelle(tc, id, TbAd.Text, TbSoyad.Text, TbKullanici.Text, TbParola.Text, idGiris);
            dataGridView1.DataSource = pe.tablolar();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel_Islemleri pe = new Personel_Islemleri();
            pe.ekle(TbTc.Text, TbAd.Text, TbSoyad.Text, TbKullanici.Text, TbParola.Text);
            dataGridView1.DataSource = pe.tablolar();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string tc = Convert.ToString(TbTc.Text);
            Personel_Islemleri pe = new Personel_Islemleri();
            pe.personelSil(tc);
            dataGridView1.DataSource = pe.tablolar();
        }

        private void PersonelEkran_Load(object sender, EventArgs e)
        {
            Personel_Islemleri me = new Personel_Islemleri();
            dataGridView1.DataSource = me.tablolar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TbTc.Text = dataGridView1.Rows[e.RowIndex].Cells["tc"].Value.ToString();
                TbAd.Text = dataGridView1.Rows[e.RowIndex].Cells["ad"].Value.ToString();
                TbSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["soyad"].Value.ToString();
            }
            catch
            {

            }

        }
    }
}
