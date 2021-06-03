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
    public partial class GunRaporu : Form
    {
        public GunRaporu()
        {
            InitializeComponent();
        }

        private void GunRaporu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EczaneOtomasyonDBDataSet2.GunSonuView' table. You can move, or remove it, as needed.
            this.GunSonuViewTableAdapter.Fill(this.EczaneOtomasyonDBDataSet2.GunSonuView);
            this.reportViewer1.RefreshReport();
        }
    }
}
