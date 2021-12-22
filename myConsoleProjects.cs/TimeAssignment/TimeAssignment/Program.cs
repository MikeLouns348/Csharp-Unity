using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Choose a number.");
            int answer = Convert.ToInt32(Console.ReadLine());
            DateTime then = now.AddHours(answer);
            Console.WriteLine(then);
            Console.ReadLine();
        }
    }
}
