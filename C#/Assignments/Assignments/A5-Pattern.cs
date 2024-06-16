using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class A5_Pattern
    {
        //Using Console.Write
        static void Main()
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num} {num} {num} {num}");

            Console.WriteLine($"{num}{num}{num}{num}");

            Console.WriteLine($"{num} {num} {num} {num}");

            Console.WriteLine($"{num}{num}{num}{num}");

            Console.WriteLine("----------- Using {0} ------------");

        //Using {0}

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.Read();
        }
       
    }
}
