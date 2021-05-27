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

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ilacCrud ic = new ilacCrud();
            float deger = int.Parse(TbFiyat.Text);
            string tur = CbilacTur.SelectedItem.ToString();
            ic.ekle(TbAd.Text, deger, TbAdet.Text, tur, DtUretim.Value, DtSonKullanim.Value);
            dataGridView1.DataSource = ic.tablolar();
        }
        private void TbFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && TbFiyat.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
