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
                
        public virtual void MakeChoice()
        {
            Console.WriteLine("Make a choice!");
            choice = Console.ReadLine().ToLower();
        }  
    }

}
