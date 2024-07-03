using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    class Cricket
    {
        public void Points_Calculation(IEnumerable<int> Scores)
        {
            int No_Of_Matches = 0;
            double Sum = 0;

            // Calculate sum and count
            foreach (int score in Scores)
            {
                Sum += score;
                No_Of_Matches++;
            }

            // Calculate average
            double Average = No_Of_Matches > 0 ? Sum / No_Of_Matches : 0;

            // Display results
            Console.WriteLine($"\nSum of scores : {Sum}");
            Console.WriteLine($"\nAverage of scores : {Average}");
        }
    }

    class Q2
    {
        static void Main()
        {
            Console.Write("Enter number of matches played : ");
            int Total_Matches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            List<int> scores = new List<int>();

            // Input scores from user
            for (int i = 0; i < Total_Matches; i++)
            {
                Console.Write($"Enter score for match {i + 1} : ");
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
            }

            Console.WriteLine("-------------------------------");

            Cricket cricket = new Cricket();
            cricket.Points_Calculation(scores);

            Console.ReadLine(); 
        }
    }
}
