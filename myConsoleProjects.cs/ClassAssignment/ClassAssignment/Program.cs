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
            int result = 0;
            MathClass math = new MathClass();
            Console.WriteLine("Choose a number to divide by 2");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            math.Math(userNum1);
            MathClass.Math(out result);
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
