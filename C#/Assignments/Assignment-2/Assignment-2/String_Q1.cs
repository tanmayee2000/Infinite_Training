using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class String_Q1
    {
        static void Main()
        {
            Console.WriteLine("Enter a String :");
            string input_str = Console.ReadLine();

            int length = input_str.Length;

            Console.WriteLine($"The length of the input string '{input_str}' is: {length}");
            Console.Read();
        }
    }
}
