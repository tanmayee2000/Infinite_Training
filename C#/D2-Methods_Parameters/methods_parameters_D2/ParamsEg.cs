using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_parameters_D2
{
    class ParamsEg
    {
        public static void Main()
        {
            ParamsEg parameg = new ParamsEg();
            int result = parameg.AddElements();        //calling the function with 0 arguments
            Console.WriteLine("The total is : {0}", result);
            result = parameg.AddElements(5);           //calling the function with 1 argument
            Console.WriteLine("The total is : {0}", result);
            result = parameg.AddElements(2, 3, 4, 5, 6, 7);  //passing coma separated values
            Console.WriteLine("The total is : {0}", result);


            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            result = parameg.AddElements(numbers);  //passing an array variable
            Console.WriteLine("The total is : {0}", result);

            //calling the 2nd example with static function, so no need of any object or anything, can be called directly
            Add(5, 10.6f);
            Add(10, 125.55f, 12.45, 345.56, 123456.678); //3 args for params

            Console.Read();

            //object o; //just to know depth - right click -> Go to definition
            //string s;
        }

        public int AddElements(params int[]arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }

                          //1 and 2 compulsory arguments, 3rd is params
        public static void Add(int x, float f, params double[] d)     //'param' must be at the end and a function can only have 1 'param', and not multiple
        {
            Console.WriteLine("{0}, {1}", x, f);
            Console.WriteLine("There are {0} number of elements in the Array", d.Length);
            foreach(double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }
            
    }
}
