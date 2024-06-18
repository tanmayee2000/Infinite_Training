using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CSharp_Practice
{
    class Distance
    {
        public int dist1;
        public int myvariable;

        // Constructor
        public Distance(int d)
        {
            dist1 = d;
        }

        // Operator overload function '+'
        public static Distance operator +(Distance dis1, Distance dis2)
        {
            Distance temp = new Distance(0); // Initialize with 0 or any default value
            temp.dist1 = dis1.dist1 + dis2.dist1;
            temp.myvariable = 25; // Just an example value
            return temp;
        }

        // Unary operator overload '++'
        public static Distance operator ++(Distance d)
        {
            d.dist1++;
            return d;
        }
    }

    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance(50);
            Distance d2 = new Distance(80);

            d1++; // Increment d1 using the overloaded ++ operator

            Distance totaldistance = d1 + d2; // the operator overloaded function '+' is called

            Console.WriteLine("The overall Distance is {0} and Myvar is {1}", totaldistance.dist1, totaldistance.myvariable);

            Console.Read();
        }
    }
}