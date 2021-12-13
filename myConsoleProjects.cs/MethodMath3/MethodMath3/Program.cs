using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math2 math = new Math2();
            Console.WriteLine("Type a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("If you like, you may type a second number, or not.");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                math.Math(userNum1, userNum2);

            }
            catch
            {
                math.Math(userNum1);
            }
            

            Console.ReadLine();
        }


    }
}