using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Strings
{
    enum cities { Agra=3, Bangalore=1, Chennai=2, Delhi=5, Hyderabad=4, Kolkata=7, Mumbai=6}
    class Enumerations
    {
        enum Days { Mon, Tue, Wed, Thur, Fri, Sat, Sun};

        public static void EnumOps()
        {
           // Enum
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), x + " Is a Garden City"));
                else if(x == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x + " Is a Temple City"));
                else if(x == 6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x + " Is a Financial City"));
            }

            foreach(var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);     //call the function Enumerations.EnumOps() under main()
            }
        }
    }
}
