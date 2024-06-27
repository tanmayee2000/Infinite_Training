using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Customer
    {
        int customerId;
        string name;
        int age;
        long phone;
        string city;

        public Customer()
        {
            Console.WriteLine("Default constructor called by using this keyword.");
            Console.WriteLine("-----------------------------------------------------");
        }

        public Customer(int customerId, string name, int age, long phone, string city) : this()
        {
            Console.WriteLine("Parameterized constructor called after default constructor.");
            Console.WriteLine("-----------------------------------------------------");
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }
        public void DisplayCustomer()
        {
            Console.WriteLine($"\n\nCustomer ID: {customerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");
            Console.Read();
        }
        ~Customer()
        {
            Console.WriteLine($"Destructor called for customer {customerId} - {name}");
            Console.Read();
        }
    }
        class Q4
        {
            public static void Main()
            {
                Customer customer1 = new Customer(111, "Tanmayee J Reddy", 23, 8793456729, "Bangalore");
                customer1.DisplayCustomer();
                Console.Read();
            }
        }

 }


