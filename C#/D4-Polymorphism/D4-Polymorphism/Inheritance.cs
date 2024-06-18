using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Polymorphism
{
    class Student     //Multilevel Inheritance with The Parent Class "Student"
    {
        private string RollNo;
        string Name;
        string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No: ");
            RollNo = Console.ReadLine();
            Name = Console.ReadLine();
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student is: " + Name);
            Console.WriteLine("Roll No of the Student is: " + RollNo);
            Console.WriteLine("The Class of the Student is: " + Class);
        }
    }

    //Single Inheritance (each class here on)
    class Marks : Student      
    {
        protected int[] marks = new int[5];
        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(" Marks in subject {0} is {1} : ", i + 1, marks[i]);
            }
        }
    }

    class Result : Marks
    {
        int Totalmarks;

        public void GetResult()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Totalmarks = Totalmarks + marks[i];               
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("===========Results===========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks = " + Totalmarks);
        }
    }

    class Inheritance
    {
        //Student student;    //without inheriting, bringing in the Class as a whole object rather than inheritance
        public static void Main()
        {
            Result result = new Result();
            result.GetData();
            result.GetMarks();
            result.GetResult();
        }
    }
}
