using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Polymorphism
{
    class Shape
    {
        protected float r, l, b;

        //Function to calculate Area of shape
        public virtual float Area()    //marking a function virtual allows the derived class
        {
            return 3.14f * r * r;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length :");
            l = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth :");
            b = float.Parse(Console.ReadLine());
        }
        public override float Area()  //redefining the base 
        {
            return l * b;
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = Convert.ToSingle(Console.ReadLine());
        }
    }
    class Method_Overriding
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.GetLB();
            Console.Write(rect.Area());
            
        }
    }
}
