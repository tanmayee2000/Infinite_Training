using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_parameters_D2
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            Console.WriteLine("X before calling a function is {0}", x);
            CallByValue(x);    //Calling a function
            Console.WriteLine("X after calling the function is {0}", x);
            Console.WriteLine("***********");

            Program program = new Program();
            Console.WriteLine("X before calling a function is {0}", x);
            program.CallByRef(ref x);
            Console.WriteLine("X after calling a function is {0}", x);

            
            Console.WriteLine("--------Out Parameter-------");
            int total, prod, diff, div = 0;
            div = CalculatorFunc(15, 10, out total, out prod, out diff);
            Console.WriteLine($"Sum is {total}, Product is {prod}, Difference is {diff}, and Division is {div}");
            Console.Read();
        }
        //Call By Value
        public static void CallByValue(int j)  //Called function
        {
            j = 100;
            Console.WriteLine("J is {0}", j);
        }

        //Call By Reference
        public void CallByRef(ref int j) //value datatype requires 'ref' which takes the address (and not value) of the variable
        {                                //whereas when an obj(eg; Program) is passed, it is already defined
            Console.WriteLine("J is {0}", j);
            j = 100;
            Console.WriteLine("J is {0}", j);
        }

        //simple code for returning one operation
        public string ShowMessage(string msg)
        {
            return "Hello" + msg;
        }

        //Out Parameters (for returning multiple operations
        public static int CalculatorFunc(int a, int b, out int sum, out int product, out int difference)
        {
            sum = a + b;
            product = a * b;
            difference = a - b;

            return a / b;
        }
    }
}
