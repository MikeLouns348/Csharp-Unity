using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 1111;
            employee.SayName();
            Console.WriteLine("Employee ID: " + employee.Id); ;

            Employee employee2 = new Employee();
            employee.FirstName = "Student";
            employee.LastName = "Sample";
            employee.Id = 2222;
            employee.SayName();
            Console.WriteLine("Employee ID: " + employee.Id); ;

            Console.WriteLine(employee.Id == employee2.Id);
            Console.WriteLine(employee.Id != employee2.Id);

            //employee.Quit();
            Console.ReadLine();
        }
    }
}
