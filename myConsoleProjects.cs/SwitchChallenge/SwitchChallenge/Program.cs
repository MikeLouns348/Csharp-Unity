using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 8;

            
            
            while (!isGuessed)
            {

                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. That is Correct!  Congratulations!!!");
                        isGuessed = true;
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

            do
            {

                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. That is Correct!  Congratulations!!!");
                        isGuessed = true;
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed 10. That is incorrect.  Please try again");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number between 1 and 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);

            Console.ReadLine();
        }
    }
}