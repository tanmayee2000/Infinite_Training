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
        private string Class_name;
        private string Semester;
        private string Branch;
        private int[] Marks = new int[5];

        // Constructor to initialize student details
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // Method to input marks for 5 subjects
        public void GetMarks()
        {
            Console.WriteLine($"Enter marks for {name} (Roll No: {rollNo}):");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to calculate average marks and display result
        public void DisplayResult()
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }

            double average = (double)sum / marks.Length;

            Console.WriteLine($"Average marks for {name}: {average}");

            // Check conditions for passing or failing
            bool pass = true;
            foreach (int mark in marks)
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
                Console.WriteLine("Result: Passed");
            }
        }

        // Method to display all student data
        public void DisplayData()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
        }
    }

    class Q2
    {
        static void Main(string[] args)
        {
            // Create a student object
            Student student = new Student(1, "John Doe", "10th", "Semester 1", "Science");

            // Get marks for the student
            student.GetMarks();

            // Display student data
            student.DisplayData();

            // Display result based on marks
            student.DisplayResult();
        }
    }
