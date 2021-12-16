using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter
{
    class Employee<T> : Person
    {
        public Employee()
        {
            Id = 007;
            
        }
        public int Id { get; set; }
        public List<T> things { get; set; }
    }
}
