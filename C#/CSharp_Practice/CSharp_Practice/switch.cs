using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class @switch
    {
        public void CheckGradeWithSwitch()
        {
            int mathscore = 85;
            Console.WriteLine("Enter your grade: ");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (mathscore)
            {

                    switch (grade)
                    {
                        case 'O':
                        case 'o':
                            Console.WriteLine("Outstanding");
                            break;
                    }
          
            }
        }
        
           


    }
}
