using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Classes
{
    class Employee
    {
        int Empid;
        string EmpName;
        DateTime DOJ;
        float Salary;

        //1. Constructor
        public Employee()
        {
            Empid = 10;
            EmpName = "Infinite Ltd.";
            DOJ = Convert.ToDateTime("5/30/24");  //format of date-time can be dd/mm/yy or mm/dd/yy
            Salary = 50000;
        }

        //2nd Constructor with arguments/parameters (Parameterized constructor)

        public Employee(int eid, string name, float sal)
        {
            Empid = eid;
            EmpName = name;
            Salary = sal;
        }

        //3rd Constructor  with 'this' keyword for clash of same var name
        public Employee(int Empid, string EmpName)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
        }
        //Methods & Functions

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter ID, Name, DOJ and Salary :");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToSingle(Console.ReadLine());  //to convert into float
        }

        public void ShowEmpDetails()
        {
            Console.WriteLine($"Employee Id{Empid}, Employee Name {EmpName}, DOJ {DOJ} and Salary {Salary}");
        }

        //destructor

        ~Employee()
        {
            Console.WriteLine("Bye from Employee... ");
            Console.Read();
        }
    }

    class EmployeeTest
    {
        public static void Main()
        {
            Employee employee = new Employee();  //calling the 1st constructor
            //employee.GetEmployeeDetails();
            employee.ShowEmpDetails();
            Console.WriteLine("-------------");

            Employee employee2 = new Employee(20,"Tan",30000);  //calling the 2nd constructor
            //employee.GetEmployeeDetails();
            employee2.ShowEmpDetails();

            Employee employee3 = new Employee(30, "Janahvi");
            //Console.Read();
        }
    }
}
