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
        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            PersonelEkran PersonelForm = new PersonelEkran();
            PersonelForm.Show();
            this.Hide();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            HastaEkran HastaForm = new HastaEkran();
            HastaForm.Show();
            this.Hide();
        }
        private void BtnIlac_Click(object sender, EventArgs e)
        {
            IlacEkran IlacForm = new IlacEkran();
            IlacForm.Show();
            this.Hide();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            LogEkran LogForm = new LogEkran();
            LogForm.Show();
        }

        private void BtnRaporla_Click(object sender, EventArgs e)
        {
            ReportingSystem RaporForm = new ReportingSystem();
            RaporForm.Show();
        }
    }
}
