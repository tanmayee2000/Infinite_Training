using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class String_Q3
    {
        static void Main()
        {
            Console.WriteLine("Enter the First Word :");
            string str1 = Console.ReadLine();

            Console.WriteLine("\nEnter the Second Word :");
            string str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine("\nThe two words are same.");
            }
            else
            {
                Console.WriteLine("\nThe two words are different.");
            }

            Console.ReadLine();
        }
    }
}
