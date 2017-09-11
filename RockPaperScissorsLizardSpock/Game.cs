using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public void RunGame()
        {
            IntroduceGame();
            SetUpPlayers(GetNumberOfPlayers());
        }

        Player playerOne;
        Player playerTwo;
        List<string> rules = new List<string>() {"Scissors Cuts Paper", "Paper Covers Rock", "Rock Crushes Lizard", "Lizard Poisons Spock", "Spock Smashes Scissors", "Scissors Decapitates Lizard", "Lizard Eats Paper", "Paper Disproves Spock", "Spock Vaporizes Rock", "Rock Crushes Scissors" };

        public void IntroduceGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock. We'll be playing for the best of 3 rounds. Here are the rules. Press enter to continue.\n");

            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }
            Console.ReadLine();
            //getPlayer2(getPlayer1());
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("Choose 1 or 2 players");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void SetUpPlayers(int numberOfPlayers)
        {
            Console.WriteLine("Please enter your name.");
            string enteredName = Console.ReadLine();
            if (numberOfPlayers == 1)
            {
                playerOne = new Human(enteredName);
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                Console.WriteLine("Please enter a name for Player two.");
                playerOne = new Human(enteredName);
                playerTwo = new Human(Console.ReadLine());
            }
        }
            
        }


        //public void RunGame()
        //{
        //    IntroduceGame();
            
        //}


        //public void GamePlay(Human currentPlayer, Computer opponent)
        //{
        //    Console.WriteLine($"{currentPlayer.name}, type one of the gestures (rock, paper, scissors, lizard, or Spock) to take your first turn. And make sure {opponent.name} isn't looking!");
        //}
    }




    //TODO: if (player1Wins < 2 && player2Wins < 2)
    //{
    //    runGamePlay();
    //}

//GamePlay(Player1.name, Player2.name);

    

