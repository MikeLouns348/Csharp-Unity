using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath4
{
    class MathClass
    {
        public void Math(int num1)
        {

            
                int result = num1 / 2;
                Console.WriteLine(result);
            

        }

        public static void Math(out int result)
        {

            result = 25;
        }
    }
}
