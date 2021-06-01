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
    public partial class YoneticiEkran : Form
    {
        public YoneticiEkran()
        {
            InitializeComponent();
        }
        PersonelEkran PersonelForm = new PersonelEkran();
        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            PersonelForm.Show();
            this.Hide();
        }

        HastaEkran HastaForm = new HastaEkran();
        private void BtnHasta_Click(object sender, EventArgs e)
        {
            HastaForm.Show();
            this.Hide();
        }
        IlacEkran IlacForm = new IlacEkran();
        private void BtnIlac_Click(object sender, EventArgs e)
        {
            IlacForm.Show();
            this.Hide();
        }
    }
}
