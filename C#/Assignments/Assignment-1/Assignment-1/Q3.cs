using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q3
    {
        static void Main()
        {
            int n1, n2;

            Console.WriteLine("Enter the first number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            n2 = int.Parse(Console.ReadLine());

            int addition = n1 + n2;
            Console.WriteLine($"\nAddition : {n1} + {n2} = {addition}");

            int subtraction = n1 - n2;
            Console.WriteLine($"Subtraction : {n1} - {n2} = {subtraction}");

            int multiplication = n1 * n2;
            Console.WriteLine($"Multiplication : {n1} * {n2} = {multiplication}");

            //In case of division, using conditional statement to check for division by 0

            if (n2 != 0)
            {
                int division = n1 / n2;
                Console.WriteLine($"Division : {n1} / {n2} = {division}");
            }
            else
            {
                Console.WriteLine("Division by Zero : Invalid Result.");
            }

            Console.ReadLine();
        }
    }
}
