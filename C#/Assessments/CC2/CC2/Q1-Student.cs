using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    public abstract class Student
    {
        public string Student_Name { get; set; }
        public int Student_Id { get; set; }
        public double Grade { get; set; }

        // Abstract method to check Pass or Fail
        public abstract bool IsPassed(double grade);
    }

    // Undergraduate Subclass
    public class Undergraduate : Student
    { 
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    // Graduate Subclass
    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            //UnderGraduate
            Undergraduate undergrad = new Undergraduate();
            Console.WriteLine("Enter Undergraduate student's details:");

            Console.Write("Name: ");
            undergrad.Student_Name = Console.ReadLine();

            Console.Write("Student ID: ");
            undergrad.Student_Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade (Overall Marks) : ");
            undergrad.Grade = Convert.ToDouble(Console.ReadLine());

            // Checking IsPassed() for Undergrad
            Console.WriteLine($"{undergrad.Student_Name} with Student ID {undergrad.Student_Id} has {(undergrad.IsPassed(undergrad.Grade) ? "Passed" : "Not passed")}");

            Console.WriteLine();

            //Graduate
            Graduate grad = new Graduate();
            Console.WriteLine("Enter Graduate student's details:");

            Console.Write("Name: ");
            grad.Student_Name = Console.ReadLine();

            Console.Write("Student ID: ");
            grad.Student_Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade (Overall Marks) : ");
            grad.Grade = Convert.ToDouble(Console.ReadLine());

            //Checking IsPassed() for Graduate
            Console.WriteLine($"{grad.Student_Name} with Student ID {grad.Student_Id} has {(grad.IsPassed(grad.Grade) ? "Passed" : "Not passed")}");

            Console.ReadLine();
        }
    }
}
