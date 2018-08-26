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
            // Game init
            BlackJackGame game = new BlackJackGame();
            game.Players = new List<string> { "Jack", "Jill", "Joe" };
            game.ListPlayers();

            // Create Deck and shuffle
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //// Print Deck
            //foreach(Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("Cards In Deck: {0}", deck.Cards.Count);


            // Hold
            Console.Read();
        }



    }
}
