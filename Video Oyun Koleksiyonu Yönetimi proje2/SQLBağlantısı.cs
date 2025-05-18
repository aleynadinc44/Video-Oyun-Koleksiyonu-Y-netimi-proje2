using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Oyun_Koleksiyonu_Yönetimi_proje2
{
    public class SQLBağlantısı
    {
        public SqlConnection baglanti()
        {
            return new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=videooyun;Integrated Security=True");
        }
    }

}
