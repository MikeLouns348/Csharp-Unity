using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> Employees = new List<Employee>();
            Employee employee = new Employee();
            {
                employee.FirstName = "Mike";
                employee.LastName = "Lounsbury";
                employee.Id = 1;

            }
            Employees.Add(employee);

            Employee employee1 = new Employee();
            {
                employee1.FirstName = "Joe";
                employee1.LastName = "Walsh";
                employee1.Id = 2;

            }
            Employees.Add(employee1);

            Employee employee2 = new Employee();
            {
                employee2.FirstName = "Joe";
                employee2.LastName = "Feinberg";
                employee2.Id = 3;

            }
            Employees.Add(employee2);

            Employee employee3 = new Employee();
            {
                employee3.FirstName = "Amanda";
                employee3.LastName = "Hugandkiss";
                employee3.Id = 4;

            }
            Employees.Add(employee3);

            Employee employee4 = new Employee();
            {
                employee4.FirstName = "Hugh";
                employee4.LastName = "Jazz";
                employee4.Id = 5;

            }
            Employees.Add(employee4);

            Employee employee5 = new Employee();
            {
                employee5.FirstName = "Ivana";
                employee5.LastName = "Tinkle";
                employee5.Id = 6;

            }
            Employees.Add(employee5);

            Employee employee6 = new Employee();
            {
                employee6.FirstName = "Anita";
                employee6.LastName = "Bath";
                employee6.Id = 7;

            }
            Employees.Add(employee6);

            Employee employee7 = new Employee();
            {
                employee7.FirstName = "Al";
                employee7.LastName = "Coholic";
                employee7.Id = 8;

            }
            Employees.Add(employee7);

            Employee employee8 = new Employee();
            {
                employee8.FirstName = "Oliver";
                employee8.LastName = "Klozoff";
                employee8.Id = 9;

            }
            Employees.Add(employee8);

            Employee employee9 = new Employee();
            {
                employee9.FirstName = "Seymour";
                employee9.LastName = "Butts";
                employee9.Id = 10;

            }
            Employees.Add(employee9);

            //foreach (Employee person in Employees)
            //{
            //    if(person.FirstName == "Joe")
            //    {
            //        Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Id);
            //    }
            //}

            List<Employee> newList = Employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in newList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Id);
            }

            //List<Employee> newList = Employees.Where(x => x.Id > 5).ToList();
            //foreach (Employee person in newList)
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Id);
            //}

            Console.ReadLine();
        }
        
    }
}
