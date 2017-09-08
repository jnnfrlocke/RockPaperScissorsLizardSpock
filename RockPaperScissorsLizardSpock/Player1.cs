using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player1 : Player
    {
        public Player1(string name, string playerType, int playerWins)
        {
            this.name = name;
            this.playerType = playerType;
            this.playerWins = playerWins;
        }
    }
}
