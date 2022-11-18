using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class DeleteCRUD
    {
        static void Main(String[] args)
        {
            SqlConnection sqlConnection;
            string ConString = @"Data Source = KeerthiReddy; Initial Catalog = ADO.Net; Integrated Security = True; Pooling = False";
            sqlConnection = new SqlConnection(ConString);
            sqlConnection.Open();
            try
            {
                Console.WriteLine("Enter the ID value that you want to delete:");
                int ID = int.Parse(Console.ReadLine());
                string deletequery = "delete from Employee where ID = " + ID;
                SqlCommand deleteCommand = new SqlCommand(deletequery,sqlConnection);
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Deleted Successfull");
                sqlConnection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
