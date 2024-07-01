using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Box
    {
        public float Length { get; set; }
        public float Breadth { get; set; }

        // Constructor 
        public Box(float length, float breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        // Function 
        public static Box AddBoxes(Box box1, Box box2)
        {
            float Lengths_sum = box1.Length + box2.Length;
            float Breadths_sum = box1.Breadth + box2.Breadth;
            return new Box(Lengths_sum, Breadths_sum);
        }
    }
    class Q2
    {
        static void Main()
        {
            Console.WriteLine("Enter dimensions for Box 1 : ");
            Console.Write("Length : ");
            float length1 = float.Parse(Console.ReadLine());
            Console.Write("Breadth : ");
            float breadth1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter dimensions for Box 2 : ");
            Console.Write("Length : ");
            float length2 = float.Parse(Console.ReadLine());
            Console.Write("Breadth : ");
            float breadth2 = float.Parse(Console.ReadLine());

            //Box objects
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            //3rd Box Object
            Box box3 = Box.AddBoxes(box1, box2);

            // Display 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nDimensions of the Box after addition : ");
            Console.WriteLine($"\nLength: {box3.Length}");
            Console.WriteLine($"Breadth: {box3.Breadth}");

            Console.ReadLine();
        }
    }
}
