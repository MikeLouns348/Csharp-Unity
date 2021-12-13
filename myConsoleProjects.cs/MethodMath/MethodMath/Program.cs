using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number * 5?");
            Multiply multiply = new Multiply();
            Console.WriteLine(multiply);
            //Console.ReadLine();
            
            Console.WriteLine("Number - 5?");
            Subtraction subtraction = new Subtraction();
            Console.WriteLine(subtraction);
            //Console.ReadLine();

            Console.WriteLine("Number + 5?");
            Addition addition = new Addition();
            Console.WriteLine(addition);
            Console.ReadLine();
        }
        
        
    }
}
