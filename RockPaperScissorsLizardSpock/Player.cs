using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public int playerWins;
        public string choice;
                
        public virtual string MakeChoice()
        {
            Console.WriteLine("Choose rock, paper, scissors, lizard, or spock. And make sure your opponent isn't watching!");
            string choice = Console.ReadLine().ToLower();
            return choice;
            
        }  
    }

}
