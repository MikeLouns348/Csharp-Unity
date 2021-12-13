using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math3 math = new Math3();
            Console.WriteLine("Type a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a second number.");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            math.Math(userNum1, userNum2);
            Console.ReadLine();
        }
        
    }
}
