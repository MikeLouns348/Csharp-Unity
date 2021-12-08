using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] jediArray = { "Yoda", "Mace Windu", "Qui-Gon Jinn", "Obi-Wan Kenobi", "Ashoka Tano" };
        
        Console.WriteLine("Which Jedi would you be.");
        Console.WriteLine("Enter a value between 1 and 5");
        int input1 = Convert.ToInt32(Console.ReadLine());

        if (input1 > 5 || input1 < 0) 
        {
            Console.WriteLine("FAIL");
            Console.ReadLine();
        }
        else
        {
            int choice = input1 - 1;
            Console.WriteLine(jediArray[choice]);
            Console.ReadLine();
        }

        int[] numArray = { 0, 0, 0, 50000000, 0 };
        Console.WriteLine("Pick a number between 1 and 5 to find out how much you've won!");
        
        int input2 = Convert.ToInt32(Console.ReadLine());

        if (input2 > 5 || input2 < 0)
        {
            Console.WriteLine("FAIL");
            Console.ReadLine();
        }
        else
        {
            int choice = input2 - 1;
            Console.WriteLine(numArray[choice]);
            Console.ReadLine();
        }

        List<string> jediList = new List<string>();
        jediList.Add("Yoda");
        jediList.Add("Mace Windu");
        jediList.Add("Qui-Gon Jinn");
        jediList.Add("Obi-Wan Kenobi");
        jediList.Add("Ashoka Tano");

        Console.WriteLine("Which Jedi would you be.");
        Console.WriteLine("Enter a value between 1 and 5");
        int input3 = Convert.ToInt32(Console.ReadLine());

        if (input3 > 5 || input3 < 0)
        {
            Console.WriteLine("FAIL");
            Console.ReadLine();
        }
        else
        {
            int choice = input3 - 1;
            Console.WriteLine(jediList[choice]);
            Console.ReadLine();
        }
    }
}