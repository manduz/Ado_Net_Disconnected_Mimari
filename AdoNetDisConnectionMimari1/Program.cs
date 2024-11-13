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

            //******************************************
            ////var olan veri güncelleniyor
            //SqlCommand cmd = new SqlCommand("update Musterim set Isim='Gizem' where MusteriID=15",con);

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.UpdateCommand = cmd;
            //con.Open();
            //adapter.UpdateCommand.ExecuteNonQuery();
            //con.Close();

            //******************************************

            //Delete islemi
            //SqlCommand cmd = new SqlCommand("delete Musterim where MusteriID = 15",con);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.DeleteCommand = cmd;
            //con.Open();
            //adapter.DeleteCommand.ExecuteNonQuery();//command'i göndermiş oluyoruz execute ile
            //con.Close();


            //******************************************

            //SqlCommandBuilder işlemi
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Musterim",con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds);







        }
    }
}
