using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q4
    {
        static void Main()
        {
            int n1, n2;

            Console.WriteLine("Enter the first number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping: n1 = {n1}, n2 = {n2}");

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine($"After swapping: n1 = {n1}, n2 = {n2}");
            Console.Read();
        }
    }
}
