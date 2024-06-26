using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Q3_Exception
    {
        static void Main()
        {
            int input_num;

            try
            {
                Console.WriteLine("Enter a number: ");
                input_num = Convert.ToInt32(Console.ReadLine());

                Input_Validity(input_num);                     //Calling the function

                Console.WriteLine("Valid Input");
            }
            catch (ArgumentException ae)                       //Exception for a negative integer as input
            {
                Console.WriteLine($"Exception : Input number cannot be negative.");
            }
            catch (Exception ex)                               //Exception for any other input other than integer (Eg : Float, double, long etc)
            { 
                Console.WriteLine($"Invalid Input Format");            
            }
            Console.Read();
        }

        static void Input_Validity(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException();        
            }
        }
    }
}