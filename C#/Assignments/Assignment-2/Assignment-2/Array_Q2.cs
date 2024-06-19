using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array_Q2
    {
        static void Main()
        {
            // Initializing an array to store the marks
            int[] marks = new int[10];

            Console.WriteLine("Enter Ten marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = marks.Sum();

            double average = marks.Average();

            int min_mark = marks.Min();
            int max_mark = marks.Max();

            // Sorting marks in ascending order
            Array.Sort(marks);
            int[] ascending_ord = marks.ToArray();

            // Sorting marks in descending order
            Array.Reverse(marks);
            int[] descending_ord = marks.ToArray();

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Average marks: {average}");
            Console.WriteLine($"Minimum marks: {min_mark}");
            Console.WriteLine($"Maximum marks: {max_mark}");


            Console.WriteLine("\nMarks in ascending order:");
            foreach (int mark in ascending_ord)
            {
                Console.Write($"{mark} ");
            }


            Console.WriteLine("\n\nMarks in descending order:");
            foreach (int mark in descending_ord)
            {
                Console.Write($"{mark} ");
            }

            Console.ReadKey();
        }
    }
}
