using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Problem4
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, result);
            }
            Console.Read();
        }
    }
}


  