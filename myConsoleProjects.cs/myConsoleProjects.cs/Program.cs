using System;


namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False.\"");
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(page);
            Console.WriteLine(help);
            Console.WriteLine(experience);
            Console.WriteLine(feedback);
            Console.WriteLine(hours);
            Console.Read();
        }
    }
}
