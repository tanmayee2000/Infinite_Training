using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{

    delegate Box AdditionDelegate(Box box1, Box box2);
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Constructor
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        // Method to add two Box objects
        public static Box Add_Boxes(Box box1, Box box2)
        {
            double Lengths_sum = box1.Length + box2.Length;
            double Breadths_sum = box1.Breadth + box2.Breadth;

            return new Box(Lengths_sum, Breadths_sum);
        }

        public void DisplayBox3()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Box 3 Dimensions :- \nLength : {Length}  \nBreadth : {Breadth}");
            Console.Read();
        }
    }

    // Test class
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter dimensions for Box 1 : ");
            Console.Write("Length : ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("Breadth : ");
            double breadth1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter dimensions for Box 2 : ");
            Console.Write("Length : ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Breadth : ");
            double breadth2 = double.Parse(Console.ReadLine());

            // Box 1 & 2 Objects
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            AdditionDelegate addDelegate = new AdditionDelegate(Box.Add_Boxes);
            Box box3 = addDelegate(box1, box2);

            box3.DisplayBox3();
        }
    }

}
