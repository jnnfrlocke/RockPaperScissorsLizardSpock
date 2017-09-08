using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public void GamePlay()
        {
            //TODO: if (player1Wins < 2 && player2Wins < 2)
            //{
            //    runGamePlay();
            //}
        }

        List<string> rules = new List<string>() { "Scissors Cuts Paper", "Paper Covers Rock", "Rock Crushes Lizard", "Lizard Poisons Spock", "Spock Smashes Scissors", "Scissors Decapitates Lizard", "Lizard Eats Paper", "Paper Disproves Spock", "Spock Vaporizes Rock", "Rock Crushes Scissors" };

        public void InitializeGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock. We'll be playing for the best of 3 rounds. Here are the rules:\n");

            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }

            Console.WriteLine("\nTo begin please enter your name.");
            string enteredName = Console.ReadLine();

            Player1 currentPlayer = new Player1(enteredName, "human", 0);

            Console.WriteLine($"Alright {enteredName}, let's get started. Would you like to play against a virtual opponent or a friend? Type 'virtual' or 'friend'.");
            string opponentType = Console.ReadLine();
            
            if (opponentType == "friend")
            {
                Console.WriteLine("Player two, please enter your name.");
                string secondPlayer = Console.ReadLine();
                Player2 humanOpponent = new Player2(secondPlayer, "human", 0);
            }
            else
            {
                Player2 virtualOpponent = new Player2("Your faithful virtual opponent", "virtual", 0);
            }


        }
         
    }
}
