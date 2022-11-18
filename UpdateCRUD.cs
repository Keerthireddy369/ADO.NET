using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class UpdateCRUD
    {
         static void Main(String[] args)
        {
            SqlConnection sqlConnection;
            string ConString = @"Data Source = KeerthiReddy; Initial Catalog = ADO.Net; Integrated Security = True; Pooling = False";
            sqlConnection = new SqlConnection(ConString);
            sqlConnection.Open();
            try
            {
                Console.WriteLine("Enter ID you wnat to Update :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name to be updated :");
                string EmpName = Console.ReadLine();
                string updatequery = "update Employee set EmpName = '" + EmpName + "'where ID =" + ID + "";
                SqlCommand updatecommand = new SqlCommand(updatequery,sqlConnection);
                updatecommand.ExecuteNonQuery();
                Console.WriteLine("Updated successfull");
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
