using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            Console.WriteLine("Pick a number to divide each number in the list by.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                int result = number / input1;
                Console.WriteLine(result);
            }            
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You can't divide by 0.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("You've exited the try catch block");
            Console.ReadLine();
        }
    }
}
