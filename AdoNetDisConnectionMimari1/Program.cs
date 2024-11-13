using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDisConnectionMimari1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CU1M14V\\SQLKODLAB;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy1;Password=1;Encrypt=True;TrustServerCertificate=True");
           
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Musterim; select * from MusteriGirisBilgileri", con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


           


        }
    }
}
