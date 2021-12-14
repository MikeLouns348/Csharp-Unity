using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        public Person()
        {
            FirstName = "Mike";
            LastName = "Lounsbury";

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + fullName);
        }
    
    }
}
