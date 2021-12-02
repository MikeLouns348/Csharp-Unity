using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string input1 = Console.ReadLine();
            int input1Int = Convert.ToInt32(input1);
            
            Console.WriteLine("How many hours do you work per week?");
            string input2 = Console.ReadLine();
            int input2Int = Convert.ToInt32(input2);

            double salaryPerWeek1 = input1Int * input2Int;
            double salaryPerMonth1 = salaryPerWeek1 * 4;
            double salaryPerYear1 = salaryPerMonth1 * 12;

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string input3 = Console.ReadLine();
            int input3Int = Convert.ToInt32(input3);

            Console.WriteLine("How many hours do you work per week?");
            string input4 = Console.ReadLine();
            int input4Int = Convert.ToInt32(input4);

            double salaryPerWeek2 = input3Int * input4Int;
            double salaryPerMonth2 = salaryPerWeek2 * 4;
            double salaryPerYear2 = salaryPerMonth2 * 12;

            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salaryPerYear1);

            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salaryPerYear2);

            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool salaryComp = salaryPerYear1 > salaryPerYear2;
            Console.WriteLine(salaryComp);

            Console.Read();
        }
    }
}
