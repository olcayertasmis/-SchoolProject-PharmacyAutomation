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
    public partial class TarihiGecenIlaclarEkran : Form
    {
        public TarihiGecenIlaclarEkran()
        {
            InitializeComponent();
        }

        private void TarihiGecenIlaclarEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EczaneOtomasyonDBDataSet3.TarihiGecenlerView' table. You can move, or remove it, as needed.
            this.TarihiGecenlerViewTableAdapter.Fill(this.EczaneOtomasyonDBDataSet3.TarihiGecenlerView);

            this.reportViewer1.RefreshReport();
        }
    }
}
