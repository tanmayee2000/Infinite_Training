using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Scholarship
    {
        public float Merit(int marks, float fees)
        {
            float SAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                SAmount = 0.2f * fees;       // 20% of the fees
            }
            else if (marks > 80 && marks <= 90)
            {
                SAmount = 0.3f * fees;      // 30% of the fees
            }
            else if (marks > 90)
            {
                SAmount = 0.5f * fees;      // 50% of the fees
            }

            return SAmount;
        }
    }

    class Q4
    {
        static void Main()
        {
            Scholarship scholarship = new Scholarship();

            int student_marks;
            float total_fees;
            Console.WriteLine("Enter Student marks : ");
            student_marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Total Fees :");
            total_fees = Convert.ToSingle(Console.ReadLine());

            // Calculate scholarship amount
            float amount = scholarship.Merit(student_marks, total_fees);

            // Display 
            Console.WriteLine($"\nScholarship amount for student with marks {student_marks} is: {amount}");
            Console.Read();
        }
    }
}
