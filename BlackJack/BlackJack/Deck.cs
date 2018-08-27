using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            // loop through faces
            for(int i = 0; i < 13; i++)
            {
                // loop through suits
                for(int j = 0; j<4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);

                }
            }
        }

        // Declare Cards Property
        public List<Card> Cards { get; set; }

        // Shuffle Method
        public  void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> temp = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    temp.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = temp;
            }
        }
    }

}