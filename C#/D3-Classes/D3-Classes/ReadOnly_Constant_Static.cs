using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Classes
{
    class ReadOnly_Constant_Static
    {
        //ReadOnly
        //Readonly variables declaration
        public readonly int myvar1 = 10; //assigning value to a readonly at the time of declaration
        public readonly string mydata;

        const float PI = 3.14f;   //constant member : 1 per class not modifiable
        int x;                    //non static member : available for each object and can be modified
        static int y = 200;       //static member : 1 per class and modifiable



        //constructor
        public ReadOnly_Constant_Static()
        {
            Console.WriteLine(myvar1);
            myvar1 = 20;
            mydata = "Readonly Variable";
            Console.WriteLine("Value of myvar is {0}, and mydata is : {1}", myvar1, mydata);
        }

        public static void Main()
        {
            ReadOnly_Constant_Static rcs = new ReadOnly_Constant_Static();
            Console.WriteLine(rcs.myvar1 + " " + rcs.mydata);
            
            //creating another object
            ReadOnly_Constant_Static rcs2 = new ReadOnly_Constant_Static();
            Console.WriteLine(rcs2.mydata + " " + rcs2.myvar1);

            //displaying constant
            Console.WriteLine(PI);

            Console.Read();           
        }
    }
}
