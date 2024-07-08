using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q4_ConcessionClassLibrary;

namespace ConcessionClient
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("\nEnter your age : ");
            int age = int.Parse(Console.ReadLine());

            Q4_ConcessionClassLibrary.ConcessionLibrary concessionLibrary = new Q4_ConcessionClassLibrary.ConcessionLibrary();
            concessionLibrary.CalculateConcession(age);

            Console.ReadLine(); 
        }
    }
}
