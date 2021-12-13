using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath2
{
    class Math2
    {
        public void Math(int num1)
        {
            Console.WriteLine(num1 * 5);
        }

        public void Math(double num2)
        {           
            Console.WriteLine(num2 * 5.0);
        }

        public void Math(string num2)
        {

            Console.WriteLine(Convert.ToInt32(num2) * 5.0);
        }


    }
}
