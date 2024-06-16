using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_parameters_D2
{
    class Decision_making
    {
        public void CheckGrade()
        {
            char grade;
            int mathscore = 85;
            Console.WriteLine("Enter your Grade: ");
            grade = Convert.ToChar(Console.ReadLine());
            if ((grade == 'O' || grade == 'o') && (mathscore > 75))
                Console.WriteLine("Outstanding");
            else if ((grade == 'A' || grade == 'a'))
                Console.WriteLine("Excellent");
            else if ((grade == 'B' || grade == 'b'))
                Console.WriteLine("Very Good");
            else if ((grade == 'C' || grade == 'c'))
                Console.WriteLine("Can Improve");
            else
                Console.WriteLine("Not Valid");
        }
        //we need to call the function from the main() already created in Program.cs
        //all the functions here within in this file
        public void CheckGradeWithSwitch()
        {

            Console.WriteLine("Enter your grade: ");
            char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;

            }

        }
    }

    class Loops
    {
        public void WhileLoop()
        {
            int i = 1;                    //Initialising
            while (i < 5)                  //Conditional
            {
                Console.WriteLine(i);
                i++;                      //Change in Initial Value
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ForLoopJumpsts()
        {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    //break;
                    continue;
                total += i;
            }
            Console.WriteLine("Sum of all numbers {0}", total);
        }

        //Implicit and Dynamic
        public void ImplicitTypeExample()
        {
            char c;                //just Declarations of variable type
            int x;
            float f;
            Program p;
                                   
            var mydata = 5;        // implicitly typed variable
                                   //'var' converts the given variable's datatype automatically
            //var mydata = "abc";  //scroll over the mydata to check the datatype
            //var mydata = 5.5;    //it can automatically convert JUST ONCE

            dynamic d;             //a reference type
            d = 7;
            d = 'b';
            d = "Hello world";
            Console.WriteLine(d);  //No matter how many values you give, the last assigned value is taken and assigned
        }                          // As a good programmer, minimal use of dynamic types are used/adviced.
    }
}
