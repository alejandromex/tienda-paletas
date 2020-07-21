using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TiendaPaletas.Helpers
{
    public class dbConection
    {
        public DataTable queryCmd(SqlCommand cmd)
        {
            string conString = "Data Source=DESKTOP-HQSUO3T\\SQLEXPRESS;Initial Catalog=tiendaPaletas;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                cmd.Connection = conn;
                var da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
