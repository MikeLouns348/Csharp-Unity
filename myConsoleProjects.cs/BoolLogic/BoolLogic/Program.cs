using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            int input1Int = Convert.ToInt32(input1);

            Console.WriteLine("Have you ever had a DUI? True or False");
            string input2 = Console.ReadLine();
            bool input2Int = Convert.ToBoolean(input2);

            Console.WriteLine("How many speeding tickets have you had?");
            string input3 = Console.ReadLine();
            int input3Int = Convert.ToInt32(input3);

            Console.WriteLine("Qualified?");
            bool isQualified = (input1Int > 15 && input2Int == false && input3Int <= 3);
            Console.WriteLine(isQualified);
            
            Console.Read();
        }
    }
}

