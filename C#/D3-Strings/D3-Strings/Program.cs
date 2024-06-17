using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s                    //right click -> Go to definition for deeper understanding and child classes under Class 'string'
            StringOps();
            Console.ReadKey();
        
        }

        public static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("S for the First Time is {0}", s.GetHashCode());


            //To show Strings are immutable
            s = "Hello World";
            Console.WriteLine("S after change of value is {0}", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("S1 new value from the pool {0}", s1.GetHashCode());

            string s2 = s1;   //reference of s1 is assigned to s2
            Console.WriteLine("S2 sharing the same reference as that of s1{0}", s2.GetHashCode());

            string s3 = "Hello";
            Console.WriteLine("S3 existing value from the pool {0}", s3.GetHashCode());

            //Mutable String - Stringbuilder
            Console.WriteLine("------- String Builder -------")
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("Sb's Hash Code : {0}", sb.GetHashCode());
            sb.Append(" World");
            Console.WriteLine("Sb's Hash Code : {0}", sb.GetHashCode());
            
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);       
        }

        public static void Struct_vs_Class()
        {
            Student s1 = new Student(); //or like below
                        //Student s1 = new Student();
                        //s1.GetHashCode()
                        //  ValueType
            s1.marks1 = 50;
            s1.marks2 = 60;
            Console.WriteLine(s1.marks1 + s1.marks2);

            Student s2 = new Student();
            s2 = s1;     //values get copied and not the addresses
            Console.WriteLine(s2.marks1 + s2.marks2);

            //let us change the value of any one student variable

            s1.marks1 = 80;
            s1.marks2 = 80;

            Console.WriteLine("After Changes.....");
            Console.WriteLine(s1.marks1 + s2.marks2);   //call the function in the main() - comment out StringOps() and call this function

            Console.WriteLine(s2.marks1 + s2.marks2);
        }
    }

   
    struct Student        //try changing struct -> class
    {                     //the above assignment will copy the reference 
                          //Struct -> Value types (s2 = s1)
                          //Class -> Reference types (s2 = ref of s1)
        //public fields
        public int marks1;
        public int marks2;
    }
}
