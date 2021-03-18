using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 89, 99, 88, 86, 45, 66, 96, 60, 47 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test Score: " + testScores[i]);
            //    }
            //}

            //    string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //    for (int j = 0; j <names.Length; j++)
            //    {
            //        if (names[j] == "Jesse")
            //        {
            //            Console.WriteLine(names[j]);
            //        }
            //    }
            //    Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(71);
            //testScores.Add(34);
            //testScores.Add(67);
            //testScores.Add(78);
            //testScores.Add(100);

            //foreach (int score in testScores)
            //{
            //    if (score> 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Damon", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 34, 86, 23, 92 };
            List<int> passingScore = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScore.Add(score);
                    Console.WriteLine(passingScore.Count());
                }
            }
            Console.ReadLine();

        }
    }
}
