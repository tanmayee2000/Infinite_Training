using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Access_Specifiers2
{
    class CallingProgram : Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.fvar = 500.55f;     //public member of the other class, accessed using an object of the class
            Program.s = ""hh";          //static public member of the other class accessed using the classname
                                        
            CallingProgram cp = new CallingProgram();
            cp.pt = 18;
        }
    }
}
