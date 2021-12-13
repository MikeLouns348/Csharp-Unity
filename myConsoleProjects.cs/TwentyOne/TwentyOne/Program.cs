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
            //Deck deck = new Deck();
            ////instantiated the data type List<Card>
            //deck.Cards = new List<Card>();
            ////now we can add cards to the property of the deck called cards

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);
            ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.ReadLine();

            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                //you need to specify what proerties you want shown
                Console.WriteLine(card.Face + " of " + card.Suit);
               
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
        
        public static Deck Shuffle(Deck deck)
        {
            List<Card> Templist = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                Templist.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }


            deck.Cards = Templist;
            return deck;
        }
    }
}
