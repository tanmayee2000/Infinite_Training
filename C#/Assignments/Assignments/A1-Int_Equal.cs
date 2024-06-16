using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A1_Int_Equal
    {
        static void Main()
        {
            int n1, n2;

            Console.WriteLine("Enter the first integer:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("The two integers are equal.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
                Console.Read();
            }
        }
    }
}
