using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q1
    {
        static void Main()
        {
            Console.WriteLine("Enter the First Integer : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Integer : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;

            if(n1 == n2)
            {
                int sumx3 = 3 * sum;
                Console.WriteLine("Since the two given integers are same, Triple their sum is : " + sumx3);
                Console.Read();
            }
            else
            {
                Console.WriteLine("The given two integers are not the same.");
                Console.Read();
            }
        }
               
    }
}
