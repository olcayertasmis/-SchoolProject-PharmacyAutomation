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
    public partial class ReportingSystem : Form
    {
        public ReportingSystem()
        {
            InitializeComponent();
        }

        private void ReportingSystem_Load(object sender, EventArgs e)
        {

        }

        private void BtnStokRapor_Click(object sender, EventArgs e)
        {
            StokBitenRapor stokForm = new StokBitenRapor();
            stokForm.Show();
        }

        private void BtnStokGoster_Click(object sender, EventArgs e)
        {
            ReportingCrud Rc = new ReportingCrud();
            dataGridView1.DataSource = Rc.stokBitenTablosu();
        }

        private void BtnGunuGoster_Click(object sender, EventArgs e)
        {
            ReportingCrud Rc = new ReportingCrud();
            dataGridView1.DataSource = Rc.BugünYapilanSatis();
        }

        private void BtnGunuRaporla_Click(object sender, EventArgs e)
        {
            GunRaporu Gr = new GunRaporu();
            Gr.Show();
        }

        private void BtnTarihGecenlerGoster_Click(object sender, EventArgs e)
        {
            ReportingCrud Rc = new ReportingCrud();
            dataGridView1.DataSource = Rc.TarihiGecenilaclar();
        }

        private void BtnTarihGecenlerRaporla_Click(object sender, EventArgs e)
        {
            TarihiGecenIlaclarEkran TgiForm = new TarihiGecenIlaclarEkran();
            TgiForm.Show();
        }
    }
}
