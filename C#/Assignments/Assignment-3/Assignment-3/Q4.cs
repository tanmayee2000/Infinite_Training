﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Customer
    {
        public int Customer_Id { get; set; }
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
            Customer_Id = id;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
            Console.WriteLine("Parameterized constructor called with all the information.");
            Console.WriteLine("Customer ID : " + id + "\nCustomer Name : " + name + "\nAge : " + age + "\nPhone : " + phone + "\nCity : " + city);
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {Customer_Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"City: {City}");
        }

        // Destructor
        //~Customer()
        //{
        //    Console.WriteLine($"Destructor called for customer: {Name}");
        //    Console.ReadKey();
        //}
    }

    class Q4
    {
        static void Main()
        {
            // Creating objects using both constructors
            Customer customer1 = new Customer();
            Customer customer2 = new Customer(111, "Tanmayee", 23, "9876543210", "Bangalore");

            // Displaying customer information using method
            Console.WriteLine("\nCustomer 1 Information:");
            customer1.DisplayCustomer();

            //GC.Collect(); //For calling the Destructor

            Console.ReadKey();
        }
    }
}