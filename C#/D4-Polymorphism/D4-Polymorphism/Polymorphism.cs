using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Polymorphism
{
    class Polymorphism
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public float Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void swap(int number1, int number2)
        {
            number1 = number1 + number2;     //5,6  (number1 = 11)
            number2 = number1 - number2;     //(11-6)   5
            number1 = number1 - number2;     //(11-5)   6
            Console.WriteLine("Swapping of integers number1 = " + number1 + " " + "number2 = " + number2);
        }

        public static void swap(char char1, char char2)
        {
            char temp = ' ';
            temp = char1;
            char1 = char2;
            char2 = temp;
            Console.WriteLine("Swapping of 2 characters char1 = " + char1 + " " + "char2 = " + char2);
        }

        public static void Main()
        {
            Polymorphism poly = new Polymorphism();
            Console.WriteLine(poly.Add(5, 5));        //goto line number 11
            Console.WriteLine(poly.Add(5, 5, 5));     //goto line number 16
            swap(5, 10);
            swap('a', 'b');
            Console.Read();
        }
    }
}
