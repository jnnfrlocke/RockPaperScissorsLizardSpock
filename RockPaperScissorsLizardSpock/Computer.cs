﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        public Computer()
        {
            this.name = "Talus";
            playerWins = 0;
        }

        public override string MakeChoice()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 6);
            string computerChoice = Game.rules[choice];
            return computerChoice;
        }
    }
}
