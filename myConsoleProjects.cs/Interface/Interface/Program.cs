using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.SayName();

            employee.Quit();
            Console.ReadLine();
        }
    }
}