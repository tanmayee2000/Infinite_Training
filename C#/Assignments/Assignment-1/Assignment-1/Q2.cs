﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q2
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is Positive.");
                Console.Read();
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is Negative.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("The number is Zero.");
                Console.Read();
            }
        }
    }
}
