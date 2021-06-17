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
    public partial class LogEkran : Form
    {
        public LogEkran()
        {
            InitializeComponent();
            Database db = new Database();
            SqlCommand cmd = new SqlCommand();
            db.baglanti.Open();
            cmd.Connection = db.baglanti;
            cmd.CommandText = "SELECT * FROM Log";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["personel_id"].ToString());
                item.SubItems.Add(dr["aciklama"].ToString());
                item.SubItems.Add(dr["tarih"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void LogEkran_Load(object sender, EventArgs e)
        {

        }
    }
}