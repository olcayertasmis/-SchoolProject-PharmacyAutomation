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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Giris grs = new Giris();
        EczaneOtomasyon frm = new EczaneOtomasyon();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (TbKullaniciadi.Text == string.Empty || TbSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adı veya şifreyi boş bırakmayınız.", "Hata | Eczane Otomasyonu ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.girisYap(TbKullaniciadi.Text, TbSifre.Text);
                string bilgiTut = TbKullaniciadi.Text + "" + TbSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
