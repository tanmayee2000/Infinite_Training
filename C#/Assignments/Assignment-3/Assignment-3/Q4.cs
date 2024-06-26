using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        // Constructor with no arguments
        public Customer()
        {
            Console.WriteLine("Default constructor called (No Arguments).");
        }

        // Constructor with all information
        public Customer(int id, string name, int age, string phone, string city)
        {
            CustomerId = id;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
            Console.WriteLine("Parameterized constructor called with all the information.");
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
        }

        // Destructor
        ~Customer()
        {
            Console.WriteLine($"Destructor called for customer: {Name}");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating objects using both constructors
            Customer customer1 = new Customer();
            Customer customer2 = new Customer(111, "Tanmayee", 23, "9876543210", "Bangalore");

            // Displaying customer information using method
            Console.WriteLine("\nCustomer 1 Information:");
            customer1.DisplayCustomer();

            GC.Collect(); 

            Console.ReadKey();
        }
    }
}
