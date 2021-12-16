using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
         public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        static void Main(string[] args)
        {
            
            

            try 
            {
                Console.WriteLine("Please enter the day of the week.");
                //DayOfWeek today = DayOfWeek.Wednesday;
                DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
                Console.WriteLine("You Picked " + today);
                Console.ReadLine();



            }
            catch (Exception)
            {
                Console.WriteLine("Please type an actual day of the week.");
                
            }

            finally
            {
                Console.ReadLine();
            }
        
        
        
        
        }
       
    }
}
