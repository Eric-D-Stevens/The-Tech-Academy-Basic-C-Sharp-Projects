using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BlackJack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck  Deck { get; set; }
        public int Balance { get; set; }

        // Deals a single card from top of deck into 'Hand' parameter
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // adds top of deck to 'Hand'
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"..\..\logs\cards_dealt.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); // removes top of deck from 'Deck

        }
    }
}
