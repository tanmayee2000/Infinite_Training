using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_parameters_D2
{
    class Arrays
    {
        public static void JustArrays()
        {
            int[] data = new int[] { 76, 4, 12, 0, 3 };
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);
            Console.WriteLine("----------Before Sort------");
            //Console.WriteLine(data[0]); too tedious for every element Hence a loop is used;

            foreach(int x in data)
            {
                Console.WriteLine(x);     //call the function in main() to execute

            }
            Console.WriteLine("------After Sort------");
            Array.Sort(data);
            foreach (int x in data)   //'var' can be used here instead of 'int'
            {
                Console.WriteLine(x);     //call the function in main() to execute
            }
            Console.WriteLine("---------Reversed Array--------");

            Array.Reverse(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);   
            }

            string[] str = new string[2] { "Hello", "World" };

            foreach(string s in str)
            {
                Console.WriteLine(s);
            }

        }

        public static void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //1st loop to iterate the rows
            for(int i=0; i<2; i++)
            {
                //2nd loop to iterate columns
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }

            //making use of GetLength() for unspecified and huge data
            
            for(int i=0; i<myarray.GetLength(0);i++)
            {
                for(int j = 0; j<myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //JAGGED ARRAY
        public static JaggedArray()
        {
            //1. Declare jagged array of 2 rows
            int[][] myjagg = new int[2][];  //only no. of rows is specified, but col in each row is left empty

            //2. Let us set the size for each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //3. Let us initialize the jagged array
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //another way to initialize jagged array
            int[][] jag2 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            //To display the elements of the above jagged array, we need 2 loops
            for(int i=0; i<jag2.Length; i++)
            {
                Console.WriteLine("Number of elements at Row : " + i + "are" + " " + jag2[i].Length);


            //Inner Loop
                for(int j=0; j<jag2[i].Length; j++)
                {
                    Console.Write(jag2[i][j] + " ");
                }
                Console.WriteLine();           //call the function in the main() to execute
            }

        }
    }
}
