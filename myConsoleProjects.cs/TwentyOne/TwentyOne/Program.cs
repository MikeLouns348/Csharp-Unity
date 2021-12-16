using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino. Whats your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much would you like to buy in for?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower;
            if (answer == "yes" || answer == "y" || answer == "ya")                
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                //this adds the player to the game
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance >0)
                {
                    game.Play();
                }

            }
            else
            {
                Console.WriteLine("Too bad, lets play anyway.");
            }
        }   
    }
}
