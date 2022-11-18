using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class CRUDinsert
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string ConString = @"Data Source = KeerthiReddy; Initial Catalog = ADO.Net; Integrated Security = True; Pooling = False";
            sqlConnection = new SqlConnection(ConString);
            sqlConnection.Open();
            Console.WriteLine("Enter EmployeeID :");
            int ID =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter EmployeeName :");
            string EmpName= Console.ReadLine();
            Console.WriteLine("Enter Employee Salary :");
            int EmpSal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age :");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee City :");
            string City = Console.ReadLine();
            string insertQuery = "insert into Employee(ID,EmpName,EmpSal,Age,City)Values('" + ID + "','" + EmpName + "','" + EmpSal + "','" + Age + "','"+City+"')";
            SqlCommand insertCommand = new SqlCommand(insertQuery,sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Insertion Sucessfull");
            sqlConnection.Close();
            Console.ReadKey();

        }
    }
}
