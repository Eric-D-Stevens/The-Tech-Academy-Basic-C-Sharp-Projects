using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Write new file
            //string text = "here is some other text";
            //File.(@"..\..\logs\log.txt", text);

            // Read Log
            //string readLog = File.ReadAllText(@"..\..\logs\log.txt");
            //Console.WriteLine(readLog);

            // Welcome and get player name and bank
            Console.WriteLine("Welcome to the Black Jack Game. Please enter your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?: ");
            int bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0}, whould you like to play Black Jack", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                // Initalize Player and Game, enter game loop.  
                Player player = new Player(playerName, bank);
                Game game = new BlackJackGame();
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
