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
            GetNumberOfPlayers();
            SetUpPlayers(numberOfPlayers);
            CompareChoices();
        }

        public Player playerOne;
        public Player playerTwo;
        List<string> rules = new List<string>() { "Scissors Cuts Paper", "Paper Covers Rock", "Rock Crushes Lizard", "Lizard Poisons Spock", "Spock Smashes Scissors", "Scissors Decapitates Lizard", "Lizard Eats Paper", "Paper Disproves Spock", "Spock Vaporizes Rock", "Rock Crushes Scissors" };

        public static string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
        int numberOfPlayers = 0;


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
            
            try
            {
                //while (numberOfPlayers != 1 || numberOfPlayers != 2)
                //{
                numberOfPlayers = int.Parse(Console.ReadLine());
                if (numberOfPlayers == 1 || numberOfPlayers == 2)
                {
                    return numberOfPlayers;
                }
                else
                {
                    Console.WriteLine("You typed " + numberOfPlayers + ". Please select 1 or 2");
                    GetNumberOfPlayers();
                    return numberOfPlayers;
                }
            }

            //    else if (numberOfPlayers == 1 || numberOfPlayers == 2)
            //    {
            //        //}

            //    }
            //    return numberOfPlayers;
            //}
            catch
            {
                Console.WriteLine("You typed an invalid option. Please select 1 or 2.");
                numberOfPlayers = 0;
                GetNumberOfPlayers();
                return numberOfPlayers;
            }
                
            
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
                Console.WriteLine("Please enter a name for player two.");
                playerOne = new Human(enteredName);
                playerTwo = new Human(Console.ReadLine());
            }
        }   
        
        public void CompareChoices()
        {
            string playerOneChoice = playerOne.MakeChoice();
            string playerTwoChoice = playerTwo.MakeChoice();
            bool playerOneWin;
            bool playerTwoWin;

            if (((playerOneChoice != "rock") && (playerOneChoice != "paper") && (playerOneChoice != "scissors") && (playerOneChoice != "lizard") && (playerOneChoice != "spock")) || ((playerTwoChoice != "rock") && (playerTwoChoice != "paper") && (playerTwoChoice != "scissors") && (playerTwoChoice != "lizard") && (playerTwoChoice != "spock")))
            {
                Console.WriteLine("You entered an invalid answer.");
                CompareChoices();
                playerOneWin = false;
                playerTwoWin = false;
            }

            else if ((playerOneChoice == "rock" && (playerTwoChoice == "lizard" || playerTwoChoice == "scissors")) || (playerOneChoice == "paper" && (playerTwoChoice == "rock" || playerTwoChoice == "spock")) || (playerOneChoice == "scissors" && (playerTwoChoice == "paper" || playerTwoChoice == "lizard")) || (playerOneChoice == "lizard" && (playerTwoChoice == "spock" || playerTwoChoice == "paper")) || (playerOneChoice == "spock" && (playerTwoChoice == "scissors" || playerTwoChoice == "rock")))
            {
                playerOneWin = true;
                playerTwoWin = false;
            }
            
            else if ((playerTwoChoice == "rock" && (playerOneChoice == "lizard" || playerOneChoice == "scissors")) || (playerTwoChoice == "paper" && (playerOneChoice == "rock" || playerOneChoice == "spock")) || (playerTwoChoice == "scissors" && (playerOneChoice == "paper" || playerOneChoice == "lizard")) || (playerTwoChoice == "lizard" && (playerOneChoice == "spock" || playerOneChoice == "paper")) || (playerTwoChoice == "spock" && (playerOneChoice == "scissors" || playerOneChoice == "rock")))
            {
                playerOneWin = false;
                playerTwoWin = true;
            }
            else
            {
                playerOneWin = false;
                playerTwoWin = false;
                Console.WriteLine("It's a draw. Hit enter to play again.");
                CompareChoices();
            }

            if (playerOneWin == true)
            {
                Console.WriteLine($"{playerOne.name} has won this round!");
                playerOne.playerWins ++;
            }
            else if (playerTwoWin == true)
            {
                Console.WriteLine($"{playerTwo.name} has won this round!");
                playerTwo.playerWins++;
            }

            if (playerOne.playerWins < 2 && playerTwo.playerWins < 2)
            {
                Console.WriteLine("On to the next round.");
                CompareChoices();
            }
            else if (playerOne.playerWins == 2)
            {
                Console.WriteLine($"Congratulations {playerOne.name}, you won the match!");
                Console.ReadLine();
            }
            else if (playerTwo.playerWins == 2)
            {
                Console.WriteLine($"Congratulations {playerTwo.name}, you won the match!");
                Console.ReadLine();
            }
        }
                 
        }


    }

    

