using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Q2_StartingEndingLetters
    {
        static void Main()
        {
            // Taking input from the user
            Console.WriteLine("Enter a list of words separated by spaces : ");
            string input = Console.ReadLine();

            // Splitting the input into an array of words
            string[] words = input.Split(' ');

            //LINQ query 
            var result = from word in words
                         where word.ToLower().StartsWith("a") && word.ToLower().EndsWith("m")
                         select word;

            // Display
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            foreach (var word in result)
            {
                Console.WriteLine("-> " + word);
            }
            Console.Read();
        }
    }
}