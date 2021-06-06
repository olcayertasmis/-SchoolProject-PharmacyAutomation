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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S6ARGM7;Initial Catalog=EczaneOtomasyonDB;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
