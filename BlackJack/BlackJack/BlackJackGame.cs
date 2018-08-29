using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BlackJackGame : Game, IWalkAway
    {
        public BlackJackDealer Dealer { get; set; }

        // ----------------- MAIN GAME LOOP ---------------- //
        public override void Play()
        {

            // Initalize BlackJackDealer Object
            Dealer = new BlackJackDealer();
            foreach (Player player in this.Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3);

            // Get Bets From Players
            Console.WriteLine("Place your bet: ");
            foreach(Player player in this.Players)
            {
                int bet = int.Parse(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);     // can player bet this ammount
                if (!successfullyBet) { return; }           // if not, break to next hand in 'Program.cs'
                this.Bets[player] = bet;
            }

            // Deal 2 Cards to all Players and Dealer
            for(int i = 0; i < 2; i++) // two cards
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in this.Players) // each player in 
                {
                    Console.Write("{0}: ", player.Name);
                    this.Dealer.Deal(player.Hand); // add single card to 'player.Hand' from deck top

                    if(i == 1)
                    {
                        // Check if a blackjack was delt and end game if it was
                        bool blackJack = BlackJackRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Black Jack!! {0} Wins {1}", player.Name, this.Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]);
                            return;
                        }
                    }
                }

                // Deal cards to Dealer
                Console.WriteLine("Dealing to Dealer:");
                this.Dealer.Deal(Dealer.Hand);
                //Check if dealer has blackjack
                if (i == 1){
                    bool blackJack = BlackJackRules.CheckForBlackJack(this.Dealer.Hand);
                    if (blackJack)
                    {   
                        // dealer has black jack - all bets to dealer
                        Console.WriteLine("Dealer Wins!!!");
                        foreach(KeyValuePair<Player,int> entry in Bets){this.Dealer.Balance += entry.Value;}
                        return;
                    }
                }
            } // Card Dealing Complete

            // Enter into hitting phase
            foreach(Player player in this.Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("{0}, Your Cards are:", player.Name);
                    foreach(Card card in player.Hand) { Console.Write(card.ToString() + ", ");}
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine();
                    if(answer == "stay" || answer == "Stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if(answer == "hit" || answer == "Hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackJackRules.IsBusted(player.Hand);
                    if(busted)
                    {
                        this.Dealer.Balance += this.Bets[player];
                        Console.WriteLine("{0} BUSTED! You loose your bet of {1}. Your new balance is now ", player.Name, this.Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes" || answer == "y") { player.isActivelyPlaying = true; }
                        else { player.isActivelyPlaying = false; }
                    }
                }
            }

            this.Dealer.isBusted = BlackJackRules.IsBusted(this.Dealer.Hand);
            Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackJackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);

            }

            if (Dealer.Stay) { Console.WriteLine("Dealer is staying"); }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer has busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                    // His way seems very convoluted \/
                    //Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    entry.Key.Balance += entry.Value * 2; // my way seems better ??
                    Dealer.Balance -= entry.Value;
                }
                return;
            }

            foreach(Player player in Players)
            {
                bool? playerWon = BlackJackRules.CompareHands(player.Hand, Dealer.Hand);
                if(playerWon == null)
                {
                    Console.WriteLine("PUSH! Nobody Wins");
                    player.Balance += Bets[player];
                }
                else if(playerWon == true)
                {
                    Console.WriteLine("{0} Won {1}", player.Name, Bets[player]);
                    player.Balance += Bets[player] * 2;
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("The Dealer has won");
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
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
        













        // override virtual Game class method
        // Write list of players to console
        public override void ListPlayers()
        {
            Console.WriteLine("Black Jack Players:");
            base.ListPlayers();
        }

        // override abstract Game class method
        // Enable players to leave the game
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
