using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CC4
{
    class Q1_FileAppend
    {
        static void Main()
        {
            string textfilePath = @"D:\Training_June\C#\Assessments\CC4\CC4\cmd commands.txt";

            Console.WriteLine("Enter the text to append into the file : ");
            string textToAppend = Console.ReadLine();


            if (File.Exists(textfilePath))
            {
                using (StreamWriter writer = new StreamWriter(textfilePath, true))
                {
                    writer.WriteLine(textToAppend);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(textfilePath))
                {

                    writer.WriteLine(textToAppend);
                }
            }

            Console.WriteLine("\nText appended successfully.");
            Console.Read();
        }
    }
}
