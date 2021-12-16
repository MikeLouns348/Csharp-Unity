using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Employee : Person
    {
        public Employee()
        {
            Id = 007;
        
        }


        public int Id { get; set; }

        //public void Quit()
        //{
        //    Console.WriteLine("I QUIT!");

        //}
        //public static bool operator ==(Employee employee, Employee employee2)
        //{

        //    if (employee.Id == employee2.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool operator !=(Employee employee, Employee employee2)
        //{

        //    if (employee.Id != employee2.Id)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}