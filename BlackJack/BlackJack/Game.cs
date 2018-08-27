using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // Abstract Play Method - must be implemented in inheriting classes
        public abstract void Play();


        // Print Players Virtual Method - can be overridden by inherited classes
        public virtual void ListPlayers()
        {
            foreach (Player player in Players) { Console.WriteLine(player.Name); }
        }
    }
}
