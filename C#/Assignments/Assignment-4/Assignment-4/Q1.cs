using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Q1
    {
        private static string First_Name;
        private static string Last_Name;

        static void Main()
        {
            Console.Write("Enter First Name : ");
            First_Name = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            Last_Name = Console.ReadLine();

            Display();
        }

        static void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine(First_Name.ToUpper());
            Console.WriteLine(Last_Name.ToUpper());

            Console.Read();
        }
    }
}
