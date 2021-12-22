using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
//Class TwentyOneGame inherits properties from class Game
    public class TwentyOneGame : Game, IWalkAway 
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play ()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");
            
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool succeefullyBet = player.Bet(bet);
                if (!succeefullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0} :", player.Name);
                    Dealer.Deal(player.Hand);
                   //this checks if its the second turn 
                    if(i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckFoprBlackJack(player.Hand);
                        if (blackJack == true)
                        {
                            Console.WriteLine("Blackjack!!! {0} wins {1}", player,Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if(i == 1)
                {
                    bool blackJack =TwentyOneRules.CheckFoprBlackJack(Dealer.Hand); 
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack :(  Everyone is a Loser!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }

                }

            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are: ");
                    foreach (Card card in player.Hand) 
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool isBusted = TwentyOneRules.isBusted(player.Hand);
                    if (isBusted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted. You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes" || answer == "ya" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                           
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            while (!Dealer.stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }

            if (Dealer.stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted.");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} wins {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }

            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push!");
                    Console.WriteLine("The dealer had:");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    player.Balance += Bets[player];

                }
                else if(playerWon == true)
                {
                    Console.WriteLine("The dealer had:");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("The dealer had:");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("Dealer wins {0} :", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Would you like to play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "ya" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;

                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }  
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
