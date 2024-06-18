using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Polymorphism
{
    class Distance
    {
        public int res;
        public int myvariable;

        //creating a constructor
        public Distance(int d)
        {
            res = d;
        }                          //try without a constructor (recording)

        //operator overload function '+'
        public static Distance operator +(Distance dis1, Distance dis2)
        {
            Distance temp = new Distance(1);
            temp.res = dis1.res + dis2.res;
            temp.myvariable = 25;
            return temp;
        }

        public static Distance operator ++(Distance dis)
        {
            dis.res++;
            return dis;
        }
    }
    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance(50);
            Distance d2 = new Distance(80);
            Distance totaldistance = d1 + d2;   //the operator overload function is called
            Console.WriteLine("The Overall distance is {0} and Myvar is {1}", totaldistance.res, totaldistance.myvariable);

            //using unary ++ operator
            Distance incrementedDistance = d1++;
            Console.WriteLine("After increment: The overall Distance of d1 is {0}", incrementedDistance.res);
            Console.Read();
        }
    }
}
