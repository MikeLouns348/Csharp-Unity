using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        //string[] days = { "Sunday, Monday ", "Tuesday, Wednesday " , "Thursday, Friday " };
        //Console.WriteLine("What television show was Fonzi from?");
        //string answer = Console.ReadLine();

        //for (int i = 0; i < days.Length; i++)
        //{

        //    days[i] = days[i] + answer;
        //    Console.WriteLine(days[i]);

        //}

        //int j = 1;
        //while (j > 0)
        //{
        //    Console.WriteLine(j);
        //    j++;
        //}

        //int j = 0;
        //while (j < 5)
        //{
        //    Console.WriteLine(j);
        //    j++;
        //}

        //int j = 0;
        //while (j <= 5)
        //{
        //    Console.WriteLine(j);
        //    j++;
        //}

        //List<string> names = new List<string>() { "mike", "hanna", "ethan", "bleu", "lucy" };

        //foreach (string name in names)
        //{
        //    if (name == "mike")
        //    {
        //        Console.WriteLine(name);

        //    }
        //    // Console.WriteLine(name);
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Mike", "Hanna", "Ethan", "Bleu", "Lucy" };

        //Console.WriteLine("Do you have a special name?");
        //Console.WriteLine("Type it below to find out?");
        //string input1 = Console.ReadLine();

        //foreach (string name in names)
        //{
        //    if (names.Contains(input1))
        //    {
        //        Console.WriteLine("Congratulations! " + input1 + " is an AWESOME name!");


        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry, " + input1 + " is a good name, but its not AWESOME!!!");
        //        Console.ReadLine();
        //        Environment.Exit(0);
        //    }
        //    break;
        //}

        //List<string> names = new List<string>() { "Mike", "Hanna", "Ethan", "Bleu", "Mike" };

        //Console.WriteLine("Search for a name.");
        //Console.WriteLine("Type it below.");
        //string input1 = Console.ReadLine();

        //for (int i = 0; i < names.Count; i++)
        //{

        //    if (names[i] == input1)
        //    {
        //        Console.WriteLine("This name was found at index " + i);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry, " + input1 + " was not found.");               
        //    }
        //}
        //Console.ReadLine();

        List<string> names = new List<string>() { "mike", "hanna", "ethan", "bleu", "mike" };
        Dictionary<string,int> duplicateNames = new Dictionary<string,int>();
        

        foreach (string name in names)
        {
            if (name !="")
            {
                if (duplicateNames.ContainsKey(name) ==false)
                {
                    duplicateNames.Add(name, 1);
                }
                else
                {
                    duplicateNames[name]++;
                }

            }
        }
        foreach (var name in duplicateNames)
        {
            Console.WriteLine(name);
        }

        
        
        Console.ReadLine();
    }
}
    

       








