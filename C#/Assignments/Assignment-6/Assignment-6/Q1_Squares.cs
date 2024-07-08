using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Q1_Squares
    {
        static void Main()
        {
            // Input numbers from the user
            Console.WriteLine("Enter numbers separated by commas : ");
            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nNumbers with their squares greater than 20 are : ");
            Console.WriteLine("\n");


            List<string> results = GetNumbers(numbers);

            foreach (var res in results)
            {
                Console.WriteLine(res);
            }
            Console.Read();
        }

        static List<string> GetNumbers(int[] numbers)
        {
            List<string> results = (
                from num in numbers
                let square = num * num
                where square > 20
                select $"{num} -> {square}"
            ).ToList();

            return results;
        }
    }
}
