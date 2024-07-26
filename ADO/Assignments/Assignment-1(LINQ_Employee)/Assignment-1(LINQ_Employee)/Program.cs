using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_LINQ_Employee_
{

    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee {EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla" , Title = "Manager",     DOB = new DateTime(1984,11,16) , DOJ = new DateTime(2011,6,8), City = "Mumbai" },
                new Employee {EmployeeID = 1002, FirstName = "Asdin",   LastName = "Dhalla" ,    Title = "AsstManager", DOB = new DateTime(1984,11,20), DOJ = new DateTime(2012,7,7), City = "Mumbai"},
                new Employee {EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza",        Title = "Consultant",  DOB = new DateTime(1984,11,14), DOJ = new DateTime(2015,4,12), City = "Pune"},
                new Employee {EmployeeID = 1004, FirstName = "Saba",    LastName = "Shaikh",     Title = "SE",          DOB = new DateTime(1990,6,3),  DOJ = new DateTime(2016,2,2), City = "Pune"},
                new Employee {EmployeeID = 1005, FirstName = "Nazia",   LastName = "Shaikh",     Title = "SE",          DOB = new DateTime(1991,3,8),  DOJ = new DateTime(2016,2,2), City = "Mumbai"},
                new Employee {EmployeeID = 1006, FirstName = "Amit",    LastName = "Pathak",     Title = "Consultant",  DOB = new DateTime(1989,11,7), DOJ = new DateTime(2014,8,8), City = "Chennai"},
                new Employee {EmployeeID = 1007, FirstName = "Vijay",   LastName = "Natrajan",   Title = "Consultant",  DOB = new DateTime(1989,12,2), DOJ = new DateTime(2015,6,1), City = "Mumbai"},
                new Employee {EmployeeID = 1008, FirstName = "Rahul",   LastName = "Dubey",      Title = "Associate",   DOB = new DateTime(1993,11,11), DOJ = new DateTime(2014,11,6), City = "Chennai"},
                new Employee {EmployeeID = 1009, FirstName = "Suresh",  LastName = "Mistry",     Title = "Associate",   DOB = new DateTime(1992,8,12), DOJ = new DateTime(2014,12,3), City = "Chennai"},
                new Employee {EmployeeID = 1010, FirstName = "Sumit",   LastName = "Shah",       Title = "Manager",     DOB = new DateTime(1991,4,12), DOJ = new DateTime(2016,1,12), City = "Pune"}

            };

            /*foreach (var item in employees)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }*/

            // QUERIES
            // 1.Display a list of all the employee who have joined before 1 / 1 / 2015.

            Console.WriteLine("1.Display a list of all the employee who have joined before 1 / 1 / 2015.\n");
            var emp_2015 = employees.Where(e => e.DOJ < new DateTime(2015, 1, 1)).ToList();

            Console.WriteLine("Employees who joined before 1/1/2015 :- ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            foreach (var emp in emp_2015)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID} \n* Name: {emp.FirstName} {emp.LastName} \n* Title: {emp.Title} \n* DOB: {emp.DOB} \n* DOJ: {emp.DOJ} \n* City: {emp.City}");
                Console.WriteLine("---------------------------------");
            }
            Console.Read();

            // 2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990.

            Console.WriteLine("2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990.\n");
            var emp_1990 = employees.Where(e => e.DOB > new DateTime(1990, 1, 1)).ToList();

            Console.WriteLine("Employees whose DOB is after 1/1/1990 :- ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            foreach (var emp in emp_1990)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID} \n* Name: {emp.FirstName} {emp.LastName} \n* Title: {emp.Title} \n* DOB: {emp.DOB} \n* DOJ: {emp.DOJ} \n* City: {emp.City}");
                Console.WriteLine("---------------------------------");
            }
            Console.Read();

            // 3.Display a list of all the employee whose designation is Consultant and Associate.

            Console.WriteLine("3.Display a list of all the employee whose designation is Consultant and Associate.\n");
            var emp_title = employees.Where(e => e.Title == "Consultant" || e.Title == "Associate").ToList();

            Console.WriteLine("Employees who are either 'Consultant' or 'Associate' :- ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            foreach (var emp in emp_title)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID} \n* Name: {emp.FirstName} {emp.LastName} \n* Title: {emp.Title} \n* DOB: {emp.DOB} \n* DOJ: {emp.DOJ} \n* City: {emp.City}");
                Console.WriteLine("---------------------------------");
            }
            Console.Read();

            // 4. Display total number of employees.

            int Employees_count = employees.Count;
            Console.WriteLine($"Q4. Total Number of Employees : {Employees_count}");
            Console.WriteLine("--------------------------------------------------");

            // 5. Display total number of employees belonging to “Chennai”.

            int Chennai_employees = employees.Count(e => e.City == "Chennai");
            Console.WriteLine($"\nQ5. Number of Employees belonging to 'Chennai' are {Chennai_employees}.");
            Console.WriteLine("--------------------------------------------------");

            // 6. Display highest employee id from the list.

            int emp_ID = employees.Max(e => e.EmployeeID);
            Console.WriteLine($"\nQ6. Employee with Highest Employee ID is {emp_ID}.");
            Console.WriteLine("--------------------------------------------------");

            // 7. Display total number of employee who have joined after 1/1/2015.

            int emp_2015 = employees.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"\nQ7. Number of Employees who joined after '01-01-2015' : {emp_2015}");
            Console.WriteLine("---------------------------------------------------------------------");

            // 8. Display total number of employees whose designation is not “Associate”.

            int emps_notassociate = employees.Count(e => e.Title != "Associate");
            Console.WriteLine($"\nQ8. Number of Employees who are not 'Associates' : {emps_notassociate}");
            Console.WriteLine("----------------------------------------------------------------");

            // 9. Display total number of employee based on City.

            var empsByCity = employees.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() }).ToList();
            Console.WriteLine("\nQ9. Number of Employees(City-wise)\n");
            foreach (var emp in empsByCity)
            {
                Console.WriteLine($"City : {emp.City} \tCount : {emp.Count}");
            }
            Console.WriteLine("--------------------------------------------------");

            // 10. Display total number of employee based on City and Title.

            var city_title = employees.GroupBy(e => new { e.City, e.Title })
                                      .Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() })
                                      .ToList();
            Console.WriteLine("\nQ10. Number of Employees City and Title wise :\n");
            foreach (var ct in city_title)
            {
                Console.WriteLine($"City: {ct.City} \tTitle: {ct.Title} \tCount: {ct.Count}");
            }
            Console.WriteLine("--------------------------------------------------");

            // 11. Display total number of employee who is youngest in the list.

            var emp_youngest = employees.OrderByDescending(e => e.DOB).First();

            Console.WriteLine($"Q11. Youngest Employee among the list is {emp_youngest.FirstName} {emp_youngest.LastName}. ");
            Console.WriteLine("---------------------------------------------------------");
            Console.Read();

        }
    }
}
