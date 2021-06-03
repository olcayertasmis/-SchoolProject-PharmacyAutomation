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
    public partial class StokBitenRapor : Form
    {
        public StokBitenRapor()
        {
            InitializeComponent();
        }

        private void StokBitenRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EczaneOtomasyonDBDataSet1.Stok_biten_ilaclar' table. You can move, or remove it, as needed.
            this.Stok_biten_ilaclarTableAdapter.Fill(this.EczaneOtomasyonDBDataSet1.Stok_biten_ilaclar);

            this.reportViewer1.RefreshReport();
        }
    }
}
