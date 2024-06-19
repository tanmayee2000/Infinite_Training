using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Problem3
    {
        static void Main()
        {
            Console.WriteLine("Enter the Numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The Largest number is {0}", Largest_Num(a,b,c));
            Console.Read();
        }

        static int Largest_Num(int num1, int num2, int num3)
        {
            int max = Math.Max(num1, Math.Max(num2, num3));
            return max;
        }

    }
}
