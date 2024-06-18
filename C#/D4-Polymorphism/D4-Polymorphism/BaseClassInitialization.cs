using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Polymorphism
{
    class Parent
    {
        int x;
        internal Parent()         //Empty Constructor
        {
            Console.WriteLine("This is the Parent..");
        }
        public Parent(int i)
        {
            x = i;
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("This is Child...");
        }

    }
    class BaseClassInitialization        //through a child class constructor
    {                                    
        public static void Main()
        {
            Child c = new Child();
            Console.Read();
        }
    }
}
