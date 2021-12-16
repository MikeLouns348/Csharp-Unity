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
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() {"Mike", "Hanna", "Ethan" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();



            //game.Dealer = "mike";
            //game.Name = "Twenty One";

            //example of polymorphism below 
            //Game game = new TwentyOneGame();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "mike", "hanna" , "ethan"};
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Mike";
            ////game = game + player;
            ////game = game - player;

            ////adds the palyer
            //game += player;
            ////removes the player
            //game -= player;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            
            
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card2.Face);
            //Console.ReadLine();

            //Deck deck = new Deck();

            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.ReadLine();


            Deck deck = new Deck();
            //lamda version of counting foreach loop
            //int counter = deck.Cards.Count(x => x.Face == Face.Ace);

            //lamda list filtering
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //lamda math function example .Sum() could be substituted with any of the itmes on the dropdown list
            List<int> numberList = new List<int> {1,2,3,535, 342,23 };
            //int sum = numberList.Sum(x => x + 5);
            int sum = numberList.Where(x => x > 20).Sum();
            Console.WriteLine(sum);
            Console.ReadLine();

            //deck.Shuffle(3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i > times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;

        //}
    }
}
