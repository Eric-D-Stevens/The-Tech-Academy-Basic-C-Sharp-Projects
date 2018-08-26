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
            // Declare Card Arrays
            List<string> suits = new List<string> { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> faces = new List<string>
                {
                    "Two", "Three", "Four", "Five", "Six", "Seven",
                    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
                };

            // Fill cards in deck
            foreach (string face in faces)
            {
                foreach (string suit in suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }

        // Declare Cards Property
        public List<Card> Cards { get; set; }

    }

}