using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.SomePatterns.Builder.Models
{
    class Team
    {
        public Team()
        {
            players = new List<Player>();
        }

        public string Name { get; set; }
        private List<Player> players;
        public IReadOnlyCollection<Player> Players { get { return players.AsReadOnly(); } }

        internal Team AddPlayer(Player player)
        {
            if (player.Team != null)
            {
                player.Team.RemovePlayer(player);
            }
            player.Team = this;
            player.History.AddHistory(this);
            players.Add(player);

            return this;
        }

        internal void RemovePlayer(Player player)
        {
            players.Remove(player);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
