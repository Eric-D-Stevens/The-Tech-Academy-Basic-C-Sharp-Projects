using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // Abstract Play Method - must be implemented in inheriting classes
        public abstract void Play();


        // Print Players Virtual Method - can be overridden by inherited classes
        public virtual void ListPlayers()
        {
            foreach (string player in Players) { Console.WriteLine(player); }
        }
    }
}
