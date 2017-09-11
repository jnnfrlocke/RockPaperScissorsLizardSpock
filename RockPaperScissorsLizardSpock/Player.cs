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
            Console.WriteLine("Choose from one of the options. And make sure your opponent isn't watching!");
            string choice = Console.ReadLine().ToLower();
            
        }  
    }

}
