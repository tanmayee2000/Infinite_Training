using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Q3_Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_City { get; set; }
        public decimal Emp_Salary { get; set; }
        public static void Main()
        {
            List<Q3_Employee> employees = new List<Q3_Employee>
        {
            new Q3_Employee { Emp_Id = 1, Emp_Name = "Tanmayee", Emp_City = "Bangalore", Emp_Salary = 50000 },
            new Q3_Employee { Emp_Id = 2, Emp_Name = "Kajal Shukla", Emp_City = "Chennai", Emp_Salary = 48000 },
            new Q3_Employee { Emp_Id = 3, Emp_Name = "Ayesha Muskan", Emp_City = "Bangalore", Emp_Salary = 45000 },
            new Q3_Employee { Emp_Id = 4, Emp_Name = "Saishashank P", Emp_City = "Pune", Emp_Salary = 47000 },
        };

            Console.WriteLine("All Employees : ");
            Console.WriteLine("**************************************");
            DisplayEmployees(employees);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\nEmployees with Salary > 45000 : ");
            Console.WriteLine("***************************************");
            var highsalary = employees.Where(e => e.Emp_Salary > 45000);
            DisplayEmployees(highsalary);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\nEmployees from Bangalore Region : ");
            Console.WriteLine("***************************************");
            var empblr = employees.Where(e => e.Emp_City.Equals("Bangalore"));
            DisplayEmployees(empblr);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\nEmployees names sorted in Ascending order : ");
            Console.WriteLine("**************************************");
            var orderednames = employees.OrderBy(e => e.Emp_Name);
            DisplayEmployees(orderednames);

            Console.Read();
        }
        static void DisplayEmployees(IEnumerable<Q3_Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee Id : {emp.Emp_Id},  Employee Name : {emp.Emp_Name},  Employee City : {emp.Emp_City},  Employee Salary : {emp.Emp_Salary}");
            }
        }
    }
}
