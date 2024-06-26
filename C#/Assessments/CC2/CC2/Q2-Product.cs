using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
    }
    class Q2_Product
    {
        static void Main()
        {
            Product[] items = new Product[10];      //Array for 10 Products

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}: ");

                Product product = new Product();

                Console.Write("Product Id: ");
                product.Product_Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                product.Product_Name = Console.ReadLine();

                Console.Write("Product Price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                items[i] = product;      //Adds the product into the array

            }

            //Comparing the Prices of the products

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i].Price > items[j].Price)
                    {
                        Product temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            // Display Sorted products
            Console.WriteLine("\nSorted Products (Based on Price) : ");
            foreach (Product product in items)
            {
                Console.WriteLine($"Product Id: {product.Product_Id} || Product Name: {product.Product_Name} || Price: {product.Price}");
            }

            Console.ReadLine();
        }
    }
}
