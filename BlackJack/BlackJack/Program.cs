using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> temp = new List<Card>();
            Random random = new Random();
            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                temp.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = temp;
            return deck;
        }
    }
}
