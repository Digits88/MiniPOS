using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniPOS
{
    public class Connection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=YONEY\SQLEXPRESS;Initial Catalog=MiniPOS;Integrated Security=True");
        public SqlConnection ActiveConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
