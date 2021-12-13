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
            Math math = new Math();
            Console.WriteLine("Choose a number to add to 5, subtract by 5 and multiply by 5.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            math.Addition1(userNum);
            math.Subtraction1(userNum);
            math.Multiply1(userNum);
           
            Console.ReadLine();
        }
        
        
    }
}
