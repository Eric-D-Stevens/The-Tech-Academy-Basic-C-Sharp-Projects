using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.BlackJack;


namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Erics Casino";

            Guid identifier = Guid.NewGuid();

            // Write new file
            //string text = "here is some other text";
            //File.(@"..\..\logs\log.txt", text);

            // Read Log
            //string readLog = File.ReadAllText(@"..\..\logs\log.txt");
            //Console.WriteLine(readLog);

            // Constructor Chaining Demo
            Player newPlayer = new Player("Eric");

            // Welcome and get player name and bank
            Console.WriteLine("Welcome to the {0}! Please enter your name", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?: ");
            int bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0}, whould you like to play Black Jack", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                // Initalize Player and Game, enter game loop.  
                Player player = new Player(playerName, bank);
                // Log A GUID for player
                player.Id = Guid.NewGuid();
                Game game = new BlackJackGame();
                using (StreamWriter file = new StreamWriter(@"..\..\logs\cards_dealt.txt", true))
                {
                    file.WriteLine(player.Id);
                }


                game += player; // operator overload, add player to "Game.Players" list
                player.isActivelyPlaying = true; 
                while(player.isActivelyPlaying && player.Balance > 0) // wants to play and has money
                {
                    game.Play(); // Main Game Loop, represents one hand
                }
                game -= player; // operator overload, remove player from game object
                Console.WriteLine("Thank you for playing!"); 
            }

            Console.WriteLine("Feel free to look around the casino, have a nice day");

            // Hold
            Console.Read();
        }



    }
}
