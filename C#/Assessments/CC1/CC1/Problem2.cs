using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Problem2
    {
        static void Main()
        {
            Console.Write("Enter a String : ");
            string input_str = Console.ReadLine();

            string result = Exchange_chars(input_str);

            Console.WriteLine("Modified String after Exchanging Characters : {0}", result);
            Console.Read();

        }

        static string Exchange_chars(string input_str)
        {
            char[] charArray = input_str.ToCharArray();

            char first_char = charArray[0];
            char last_char = charArray[input_str.Length - 1];

            charArray[0] = last_char;
            charArray[input_str.Length - 1] = first_char;

            return new string(charArray);
        }
    }
}
