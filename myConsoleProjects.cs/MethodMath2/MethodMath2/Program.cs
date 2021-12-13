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
            Math2 math2 = new Math2();
            Console.WriteLine("Choose a number to muliply by 5.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            math2.Math(userNum);

            Console.WriteLine("Choose a deicmal to muliply by 5.");
            double userNum1 = Convert.ToDouble(Console.ReadLine());
            math2.Math(userNum1);

            Console.WriteLine("Type a number to multiply by 5.");
            string userNum2 = Console.ReadLine();
            math2.Math(userNum2);


            Console.ReadLine();
        }


    }
}

