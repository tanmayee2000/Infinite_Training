using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Access_Specifiers
{
    public class Program
    {
        private static int data1;   //private static
        private string str;         //private non-static
        public float fvar;          //public non-static
        public static string s;     //public and static
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(data1 + " " + p.str + " " + p.fvar + " " + s);
            Console.Read();
        }
    }

    class Driver
    {
        public static void accessprogram()
        {
            Program prg = new Program();  //prg.str; we cannot access the private members of other class, no visibility
            prg.fvar = 25.55f;            //public members of one class are accessible in others using the object
            Program.s = "Hello";          //public static members of one class are accessible in other classes using the classname
        }
    }
}














        class ProgramChild : Program  //child/derived/sub class of the program class
        {
            public void childAccess()
            {
                Program.d = 5.5;
                Program.s = "Child";
                Program p1 = new Program();
                p1.fvar = 34.5f;
                p1.i = 10;
                p1.ip = 8;     //internal protected being accesses either with the parent object or with the child object
                ProgramChild pc = new ProgramChild();
                pc.pt = 7;     //accessing the base classes protected member with the help of the derives class object
                pc.ip = 6;
            }
        }
    }
}
