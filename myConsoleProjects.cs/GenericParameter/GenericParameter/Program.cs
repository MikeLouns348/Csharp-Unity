using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() { "apron", "pen" };
            

            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>() { 1, 2, 3 };

            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            
            foreach(int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }
            
            
            Console.ReadLine();
        }
    }
}
