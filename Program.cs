using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Golden State Warriors");
            Player player1 = new Player("Stephen Curry", "Point Guard", 30, 30);
            Player player2 = new Player("Kevin Durant", "Small Forward", 35, 29);
            Player player3 = new Player("Klay Thompson", "Shooting Guard", 11, 28);
            Player player4 = new Player("Draymond Green", "Power Forward", 23, 28);

            team.AddPlayer(player1);
            team.AddPlayer(player2);
            team.AddPlayer(player3);
            team.AddPlayer(player4);

            team.PrintPlayers();
        }
    }
}