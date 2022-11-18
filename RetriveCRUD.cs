using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class RetriveCRUD
    {
        static void Main(String[] args)
        {
            SqlConnection sqlConnection;
            string ConString = @"Data Source = KeerthiReddy; Initial Catalog = ADO.Net; Integrated Security = True; Pooling = False";
            sqlConnection = new SqlConnection(ConString);
            sqlConnection.Open();
            try
            {
                Console.WriteLine("Enter ID of an Employee:");
                int ID = int.Parse(Console.ReadLine());
                string retrievequery = "select * from Employee where ID =" + ID;
                SqlCommand retrieveCommand = new SqlCommand(retrievequery, sqlConnection);
                retrieveCommand.ExecuteNonQuery();
                SqlDataReader reader = retrieveCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

                }

                Console.WriteLine("Retrieve Successfull");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
