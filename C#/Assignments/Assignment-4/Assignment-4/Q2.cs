using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Q2
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input_str = Console.ReadLine();

            Console.WriteLine("\nEnter the letter to count:");
            string letter_input = Console.ReadLine();

            if (letter_input.Length != 1)
            {
                Console.WriteLine("\nPlease enter exactly one letter.");
                return;
            }

            char letter = letter_input[0];

            // To Handle Case insensitivity
            letter = Char.ToUpper(letter);

            int count = Count_letter(input_str, letter);
            Console.WriteLine($"\nNumber of occurrences of '{letter}' in the string : {count}");
            Console.Read(); 
        }

        // Function 
        static int Count_letter(string input_string, char letter)
        {
            int count = 0;

            foreach (char c in input_string)
            {
                if (Char.ToUpper(c) == letter)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
