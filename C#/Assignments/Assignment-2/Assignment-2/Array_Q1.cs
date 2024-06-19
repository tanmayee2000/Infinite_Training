using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Array_Q1
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements in the Array:");
            int n = int.Parse(Console.ReadLine());

            // Initializing the array with size n
            int[] int_array = new int[n];

            Console.WriteLine("Enter the elements in the Array: ");
            // Entering values into the Array
            for (int i = 0; i < n; i++)
            {
                int_array[i] = int.Parse(Console.ReadLine());
            }


            double average = Average(int_array);
            Console.WriteLine($"Average value of the array elements: {average}");

            int min = Minimum(int_array);
            int max = Maximum(int_array);
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");

            Console.ReadLine(); 
        }

        //Functions

        // Calculating Average
        static double Average(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        // Minimum value in the Array
        static int Minimum(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        // Maximum value in the Array
        static int Maximum(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
