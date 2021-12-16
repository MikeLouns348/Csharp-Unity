using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            //Cards is a property of the class Deck
            Cards = new List<Card>();
        
            for (int j = 0; j<13; j++)
            {
                for (int n = 0; n < 4; n++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)n;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> Templist = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    Templist.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }


                Cards = Templist;

            }
        }
    }
}
