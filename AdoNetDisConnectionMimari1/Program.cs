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

            //veri ekliyor
            string sorgu = "insert into Musterim values(15,'Burak','Çakır')";

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(sorgu, con);

            con.Open();

            adapter.InsertCommand.ExecuteNonQuery();
            con.Close();


           


        }
    }
}
