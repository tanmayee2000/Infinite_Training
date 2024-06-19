using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class String_Q2
    {
        static void Main()
        {
            Console.Write("Enter a String : ");
            string input_str = Console.ReadLine();

            string reverse_str = ReverseString(input_str);

            Console.WriteLine($"Reversed String : {reverse_str}");

            Console.ReadKey();
        }

        static string ReverseString(string str)
        {
            // Converting string to char array
            char[] char_array = str.ToCharArray();

            // Reverse the array
            Array.Reverse(char_array);

            // Converting char array back to string
            return new string(char_array);
        }
    }
}
