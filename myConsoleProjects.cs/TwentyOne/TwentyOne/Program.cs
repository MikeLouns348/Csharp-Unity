﻿using System;
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

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "mike", "hanna" , "ethan"};
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
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
