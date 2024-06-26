using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Saledetails
    {
        
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateofSale;
        private int Qty;
        private double TotalAmount;

        // Constructor 
        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateofSale = dateofSale;
           
            Sales();
        }

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

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
            Saledetails sale1 = new Saledetails(1, 111, 1100, 3, DateTime.Now);

            sale1.ShowData();
        }
    }
}
