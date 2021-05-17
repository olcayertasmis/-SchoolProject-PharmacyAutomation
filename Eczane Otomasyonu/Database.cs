using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Eczane_Otomasyonu
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S6ARGM7;Initial Catalog=EczaneOtomasyonDB;Integrated Security=True;MultipleActiveResultSets=True");
        public static SqlConnection staticBaglanti = new SqlConnection(@"Data Source=DESKTOP-S6ARGM7;Initial Catalog=EczaneOtomasyonDB;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
