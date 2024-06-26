using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student
    {
        private int Roll_no;
        private string Name;
        private string Class;
        private string Semester;
        private string Branch;
        private int[] Marks = new int[5];

        // Constructor
        public Student(int Roll_no, string Name, string Class, string Semester, string Branch)
        {
            this.Roll_no = Roll_no;
            this.Name = Name;
            this.Class = Class;
            this.Semester = Semester;
            this.Branch = Branch;
        }

        // Input marks for 5 subjects
        public void GetMarks()
        {
            Console.WriteLine($"Enter Marks for {Name} (Roll No: {Roll_no}):");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int sum = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
            }

            double average = (double)sum / Marks.Length;

            Console.WriteLine($"Average marks for {Name}: {average}");

            //Check whether Pass or Fail
            bool pass = true;
            foreach (int mark in Marks)
            {
                if (mark < 35)
                {
                    pass = false;
                    break;
                }
            }

            if (!pass || average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Pass");
            }
        }

        
        public void DisplayData()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"Roll No: {Roll_no}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
        }
    }

    class Q2
    {
        static void Main()
        {
            Student student = new Student(111, "Tanmayee", "12th", "Semester 1", "Science");

            student.GetMarks();

            student.DisplayData();

            student.DisplayResult();
        }
    }
}
