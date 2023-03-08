using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 99, 98, 85 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + testScores[i]);
            //    }
            //}
            //    Console.ReadLine();
            //

            //string[] names = { "Jesse", "Carly", "Grason" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);


            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Carly", "Grason" };
            //for (int j = 0; j < names.Length; j++)
            //{

            //        Console.WriteLine(names[j]);

            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(90);
            //testScores.Add(80);
            //testScores.Add(91);
            //testScores.Add(99);
            //testScores.Add(78);
            //testScores.Add(10);

            //foreach (int score in testScores)
            //{

            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam" };
            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 90, 99, 76, 43 };
            List<int> PassingScores = new List<int>();
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    PassingScores.Add(score);
                }
            }
            Console.WriteLine(PassingScores.Count);
            Console.ReadLine();
        }

    }
}

