using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i ++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing Score " + testScores[i]);
        //    }

        //}
        //Console.ReadLine();

        //string[] name = { "mike", "hanna", "ethan", "bleu", "lucy" };

        //for (int j = 0; j < name.Length; j++)
        //{
        //    //if (name[j] == "mike")
        //    //{
        //    //    Console.WriteLine("your name is " + name[j]);
        //    //}

        //    Console.WriteLine(name[j]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("passing score " + score);
        //    }

        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "mike", "hanna", "ethan", "bleu", "lucy" };

        //foreach (string name in names)
        //{
        //    //if (name == "mike")
        //    //{
        //    //    Console.WriteLine(name);

        //    //}
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }            
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}

