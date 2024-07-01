using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Employee
    {
        public int Employee_id { get; set; }
        public string Employee_name { get; set; }
        public float Salary { get; set; }

        // Constructor
        public Employee(int empid, string empname, float salary)
        {
            Employee_id = empid;
            Employee_name = empname;
            Salary = salary;
        }

        public static void Main()
        {
            Console.Write("Enter Employee ID : ");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Employee Name : ");
            string empname = Console.ReadLine();

            Console.Write("\nEnter Employee Salary : ");
            float salary = float.Parse(Console.ReadLine());

            Employee emp = new Employee(empid, empname, salary);

            // Display
            Console.WriteLine("-------------------");
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Employee ID : " + emp.Employee_id);
            Console.WriteLine("Name : " + emp.Employee_name);
            Console.WriteLine("Salary : " + emp.Salary);

            Console.ReadLine(); 
        }
    }
}
