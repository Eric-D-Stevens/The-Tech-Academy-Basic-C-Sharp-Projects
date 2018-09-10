using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set{ _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        // Abstract Play Method - must be implemented in inheriting classes
        public abstract void Play();


        // Print Players Virtual Method - can be overridden by inherited classes
        public virtual void ListPlayers()
        {
            foreach (Player player in Players) { Console.WriteLine(player.Name); }
        }
    }
}
