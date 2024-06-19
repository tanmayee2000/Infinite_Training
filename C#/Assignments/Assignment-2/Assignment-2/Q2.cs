using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q2
    {
        static void Main()
        {
            Console.Write("Enter the day number (1 to 7) : ");
            int day_num = Convert.ToInt32(Console.ReadLine());
            string day_name;

            switch(day_num)
            {
                case 1:
                    day_name = "Monday";
                    break;

                case 2 :
                    day_name = "Tuesday";
                    break;

                case 3 :
                    day_name = "Wednesday";
                    break;

                case 4 :
                    day_name = "Thursday";
                    break;

                case 5 :
                    day_name = "Friday";
                    break;

                case 6 :
                    day_name = "Saturday";
                    break;

                case 7 :
                    day_name = "Sunday";
                    break;

                default :
                    day_name = "Invalid Input";
                    break;                   
            }
            Console.WriteLine("The Day name for the given number " + day_num + " in a week is " + day_name);
            Console.Read();

        }        
    }
}
