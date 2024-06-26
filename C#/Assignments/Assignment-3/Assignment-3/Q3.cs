using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Saledetails
    {
        // Data members
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateofSale;
        private int Qty;
        private double TotalAmount;

        // Constructor to initialize the object
        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateofSale = dateofSale;
            // Initialize TotalAmount using the Sales method
            Sales();
        }

        // Method to calculate TotalAmount
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        // Method to display the data
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Date of Sale: " + DateofSale.ToShortDateString());
            Console.WriteLine("Qty: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }

    class Q3
    {
        static void Main()
        {
            // Create an instance of Saledetails
            Saledetails sale1 = new Saledetails(1, 101, 10.5, 3, DateTime.Now);

            // Display the data
            sale1.ShowData();
        }
    }
