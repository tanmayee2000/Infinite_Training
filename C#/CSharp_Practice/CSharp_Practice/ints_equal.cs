using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class ints_equal
    {
        static void Main()
        {
            int num1, num2;

            Console.WriteLine("Enter the first integer:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The two integers are equal.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
                Console.Read();
            }
        }


    }
}
