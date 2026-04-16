using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__3
{
    class CricketTeam
    {
        public static void PointsCalculation(int matches)
        {
            double sum = 0;
            for (int i = 1; i <= matches; i++)
            {
                Console.Write($"Enter score for match  {i} : ");
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;
            }
            double avg = sum / matches;

            Console.WriteLine("\nNo Of Matches: " + matches);
            Console.WriteLine("Total Score  : " + sum);
            Console.WriteLine("Average Score: " + avg);
        }
    }

    class Cricket
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of matches: ");
            int matches = Convert.ToInt32(Console.ReadLine());
            CricketTeam.PointsCalculation(matches);
        }
    }


}
