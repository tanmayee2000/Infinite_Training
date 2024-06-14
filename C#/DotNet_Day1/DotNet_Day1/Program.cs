using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day1
{
    class Program
    {
        static void Main()
        {
            int a;
            string b, c, d;
            //Name
            Console.Write("Enter your name: ");
            b = Console.ReadLine();
            //Age
            Console.Write("Enter Age : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + b + ",age is " + a);
            Console.ReadKey();

        }
    }
}
