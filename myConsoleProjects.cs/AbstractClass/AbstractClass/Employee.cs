using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        public Employee()
        {
            Id = 007;
        }
        public int Id { get; set; }
    }
}
