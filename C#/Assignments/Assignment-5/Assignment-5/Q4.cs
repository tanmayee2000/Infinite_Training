using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public interface IStudent
    {
        int Student_Id { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    // Class Dayscholar 
    public class Dayscholar : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar details : ");
            Console.WriteLine($"Student ID : {Student_Id}");
            Console.WriteLine($"Name : {Name}");
        }
    }

    // Class Resident 
    public class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident details :");
            Console.WriteLine($"Student ID : {Student_Id}");
            Console.WriteLine($"Name : {Name}");
        }
    }

    class Q4
    {
        static void Main()
        {
            Console.WriteLine("Enter details for Dayscholar :");
            Dayscholar dayscholar = new Dayscholar();
            Console.Write("Enter Student ID : ");
            dayscholar.Student_Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            dayscholar.Name = Console.ReadLine();

            Console.WriteLine("\nEnter details for Resident:");
            Resident resident = new Resident();
            Console.Write("Enter Student ID : ");
            resident.Student_Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            resident.Name = Console.ReadLine();

            // Display
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nDetails entered ~");
            dayscholar.ShowDetails();
            Console.WriteLine();
            resident.ShowDetails();

            Console.Read();
        }
    }
}
