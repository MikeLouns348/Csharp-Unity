using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            int var1 = 50;
            int var2 = 25;
            double var3 = 12.5;
            int var4 = 7;

            Console.WriteLine("Choose a number to multiply by 50.");
            string input1 = Console.ReadLine();
            int input1Int = Convert.ToInt32(input1);
            int solution1 = input1Int * var1;
            Console.WriteLine(solution1);
            

            Console.WriteLine("Choose a number to add 25 to.");
            string input2 = Console.ReadLine();
            int input2Int = Convert.ToInt32(input2);
            int solution2 = input2Int + var2;
            Console.WriteLine(solution2);

            Console.WriteLine("Choose a number to divide by 12.5.");
            string input3 = Console.ReadLine();
            int input3Int = Convert.ToInt32(input3);
            double solution3 = input3Int / var3;
            Console.WriteLine(solution3);

            Console.WriteLine("Choose a number to check if its greater than 50.");
            string input4 = Console.ReadLine();
            int input4Int = Convert.ToInt32(input4);
            bool solution4 = input4Int > var1;
            Console.WriteLine(solution4);

            Console.WriteLine("Choose a number to divide by 7 and see the remainder.");
            string input5 = Console.ReadLine();
            int input5Int = Convert.ToInt32(input5);
            double solution5 = input5Int % var4;
            Console.WriteLine(solution5);

            Console.Read();
        }
    }
}
