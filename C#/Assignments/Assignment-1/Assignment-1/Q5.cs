using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q5
    {
        //Using Console.Write
        static void Main()
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("----------- Using Console.Write ------------");

            Console.WriteLine($"\n{num} {num} {num} {num}");

            Console.WriteLine($"{num}{num}{num}{num}");

            Console.WriteLine($"{num} {num} {num} {num}");

            Console.WriteLine($"{num}{num}{num}{num}");

            //Using {0}
            Console.WriteLine("----------- Using {0} ------------");

            Console.WriteLine("\n{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.Read();
        }
    }
}
