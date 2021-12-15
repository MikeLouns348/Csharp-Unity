using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuittable
    {
        public Employee()
        {
            Id = 007;
        }
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("I QUIT!");

        }
    }
}
