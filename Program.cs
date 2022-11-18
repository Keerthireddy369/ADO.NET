using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source = KeerthiReddy; Initial Catalog = ADO.Net; Integrated Security = True; Pooling = False";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Employee";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                
            }
        }
    }
}
