using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    class Q3_Employee
    {
        class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public string DOB { get; set; }
            public string DOJ { get; set; }
            public string City { get; set; }

            public Employee(int id, string firstName, string lastName, string title, string dob, string doj, string city)
            {
                EmployeeID = id;
                FirstName = firstName;
                LastName = lastName;
                Title = title;
                DOB = dob;
                DOJ = doj;
                City = city;
            }

            public override string ToString()
            {
                return $"{EmployeeID,-6} {FirstName,-10} {LastName,-10} {Title,-15} {DOB,-12} {DOJ,-12} {City}"; 
                //numbers here are for proper spacing between the displaying objects in a single string
            }
        }

        static void Main()
        {
            // List
            List<Employee> empList = new List<Employee>
        {
            new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16-11-1984", "08-06-2011", "Mumbai"),
            new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "07-07-2012", "Mumbai"),
            new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12-04-2015", "Pune"),
            new Employee(1004, "Saba", "Shaikh", "SE", "03-06-1990", "02-02-2016", "Pune"),
            new Employee(1005, "Nazia", "Shaikh", "SE", "08-03-1991", "02-02-2016", "Mumbai"),
            new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "08-08-2014", "Chennai"),
            new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "01-06-2015", "Mumbai"),
            new Employee(1008, "Rahul", "Dubey", "Associate", "11-11-1993", "06-11-2014", "Chennai"),
            new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "03-12-2014", "Chennai"),
            new Employee(1010, "Sumit", "Shah", "Manager", "12-04-1991", "02-01-2016", "Pune")
        };

            bool exit = false;
            while (!exit)
            {
                // Menu 
                Console.WriteLine("\nMENU : ");
                Console.WriteLine("1. Display details of all employees");
                Console.WriteLine("2. Display details of employees not in Mumbai");
                Console.WriteLine("3. Display details of Assistant Managers");
                Console.WriteLine("4. Display details of employees with last name starting with 'S'");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------------------------------------------------------");

                Console.Write("\nEnter your choice : ");
               
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AllEmployees(empList);
                        break;
                    case "2":
                        EmployeesNotInMumbai(empList);
                        break;
                    case "3":
                        AssistantManagers(empList);
                        break;
                    case "4":
                        EmployeesWithLastNameStartingWithS(empList);
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                        break;
                }

                Console.WriteLine(); 
            }
        }

        // Method for Option 1
        static void AllEmployees(List<Employee> empList)
        {
            Console.WriteLine("\nDetails of all employees : ");
            Console.WriteLine();
            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }

        // Method for Option 2
        static void EmployeesNotInMumbai(List<Employee> empList)
        {
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("\nDetails of all the Employees whose location is not 'Mumbai' : ");
            Console.WriteLine();
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }

        // Method for Option 3
        static void AssistantManagers(List<Employee> empList)
        {
            var assistantManagers = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("\nDetails of all Employees whose title is 'Assistant Manager' : ");
            Console.WriteLine();
            foreach (var emp in assistantManagers)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }

        // Method For Option 4
        static void EmployeesWithLastNameStartingWithS(List<Employee> empList)
        {
            var employeesWithLastNameS = empList.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("\nDetails of all Employees whose last name starts with 'S':");
            Console.WriteLine();
            foreach (var emp in employeesWithLastNameS)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }

    }
}
