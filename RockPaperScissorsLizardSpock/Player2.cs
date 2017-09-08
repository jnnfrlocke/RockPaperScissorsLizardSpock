using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player2 : Player
    {
        public Player2(string name, string playerType, int playerWins)
        {
            this.name = name;
            this.playerType = playerType;
            this.playerWins = playerWins;
        }
    }
}
