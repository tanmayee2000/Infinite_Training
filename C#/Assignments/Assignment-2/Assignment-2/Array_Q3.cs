using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array_Q3
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Initialize both the arrays
            int[] Array1 = new int[size];
            int[] Array2 = new int[size];

            // Input elements for Array1
            Console.WriteLine($"\nEnter {size} elements for the Array 1:");
            for (int i = 0; i < size; i++)
            {
                Array1[i] = int.Parse(Console.ReadLine());
            }

            // Copy elements to Array2
            for (int i = 0; i < size; i++)
            {
                Array2[i] = Array1[i];
            }

            Console.WriteLine("\nArray 2 :");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Array2[i]);
            }
            Console.Read();
        }
    }
}
