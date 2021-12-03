using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Welcome to Package Express");

            Console.WriteLine("Package weight?");
            string input1 = Console.ReadLine();
            int input1Int = Convert.ToInt32(input1);

            if (input1Int > 50)
            {
                //exit application
                Console.WriteLine("Package is too heavy to ship.");
                Console.Read();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package width?");
            }

            string input2 = Console.ReadLine();
            int input2Int = Convert.ToInt32(input2);

            Console.WriteLine("Package height?");
            string input3 = Console.ReadLine();
            int input3Int = Convert.ToInt32(input3);

            Console.WriteLine("Package length?");
            string input4 = Console.ReadLine();
            int input4Int = Convert.ToInt32(input4);

            int dimensions = input2Int + input3Int + input4Int;


            if (dimensions > 50)
            {
                //exit application
                Console.WriteLine("Package is too big to ship.");
                Console.Read();
                System.Environment.Exit(1);
            }
            else
            {
                double total = ((input2Int * input3Int * input4Int) * input1Int) / 100;
                Console.WriteLine("Your quote is: " + total);
            }

            Console.Read();
        }
    }
}
