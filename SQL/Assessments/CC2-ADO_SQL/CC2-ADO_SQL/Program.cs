using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CC2_ADO_SQL
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static void Main()
        { 
            //Establishing Connection to the DataBase
            con = new SqlConnection("data source = ICS-LT-JP2RQ73\\SQLEXPRESS; initial catalog = Employee_Management;" +
                "user id = sa; password = Cappy#527;");
            con.Open();

            cmd = new SqlCommand("sp_Add_Emp_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;


            //Inputs From User to add details
            Console.WriteLine("Enter Details to be inserted :");
            Console.WriteLine("\nEmployee Name : ");
            string empname = Console.ReadLine();

            Console.WriteLine("\nEmployee Salary : ");
            float empsalary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nEmployee Type :");
            char emptype = Convert.ToChar(Console.ReadLine());


            //Insert into the Procedure
            cmd.Parameters.AddWithValue("@emp_name", empname);
            cmd.Parameters.AddWithValue("@emp_sal", empsalary);
            cmd.Parameters.AddWithValue("@emp_type", emptype);

            int rows_affected = cmd.ExecuteNonQuery();

            Console.WriteLine($"Inserted {rows_affected} rows into the Employee_Details Table successfully.");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
