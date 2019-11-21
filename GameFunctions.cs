using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    public class GameFuntions
    {
        string opponent;
        Player player1;
        Player player2;
        public List<string> winningPlays = new List<string>();
        public List<string> ties = new List<string>();
        public void WinsTies()
        {
            for (int i = 0; i < player1.options.Count; i++)
            {
                for (int j = 0; j < player1.options.Count; j++)
                {
                    if (winningPlays.Contains((player1.options[j] + player1.options[i]).ToLower()))
                    {
                        continue;
                    }
                    else if (player1.options[j] == player1.options[i])
                    {
                        ties.Add((player1.options[j] + player1.options[i]).ToLower());
                    }
                    else if (player1.options[i] == "Rock")
                    {
                        if (player1.options[j] == "Scissors" || player1.options[j] == "Lizard")
                        {
                            winningPlays.Add((player1.options[i] + player1.options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (player1.options[i] == "Scissors")
                    {
                        if (player1.options[j] == "Paper" || player1.options[j] == "Lizard")
                        {
                            winningPlays.Add((player1.options[i] + player1.options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (player1.options[i] == "Paper")
                    {
                        if (player1.options[j] == "Rock" || player1.options[j] == "Spock")
                        {
                            winningPlays.Add((player1.options[i] + player1.options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (player1.options[i] == "Spock")
                    {
                        if (player1.options[j] == "Rock" || player1.options[j] == "Scissors")
                        {
                            winningPlays.Add(player1.options[i] + player1.options[j]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (player1.options[i] == "Lizard")
                    {
                        if (player1.options[j] == "Spock" || player1.options[j] == "Paper")
                        {
                            winningPlays.Add((player1.options[i] + player1.options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public GameFuntions()
        {

        }
        public void GameStart()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, AND Spock.");
            Console.WriteLine("The game is played just like a traditional game of rock, paper, scissors but with the obvious added two options.");
            Console.WriteLine("In this version everything can beat two other things.");
            Console.WriteLine("In short, paper beats rock and Spock; rock beats scissors and lizard; scissors beat paper and lizard; Spock beats rock  and scizzors; lizard beats paper and Spock");
            Console.WriteLine("This game is also best 2 out of 3.");
            Console.WriteLine("With that being said, would you like to start the game?");
            string answer = Console.ReadLine().ToLower();
            while (answer != "yes" && answer != "no" && answer != "y" && answer != "n")
            {
                Console.Clear();
                Console.WriteLine("If you want to exit this prompt, you better answer 'yes' or 'no' to the initial question!");
                answer = Console.ReadLine().ToLower();
            }
            switch (answer)
            {
                case "y":
                    Run();
                    break;
                case "n":
                    break;
                case "yes":
                    Run();
                    break;
                case "no":
                    break;
                default:
                    break;
            }
        }
        private void WinPrompt()
        {
            if (player2.winCount == 2)
            {
                Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " " + player2.name + ": " + player2.winCount);
                Console.WriteLine(player2.name + " is the WINNER!!! Sorry " + player1.name + ", you suck hard.");
                Console.WriteLine("You are an awful person. YOU LOSE!!!");
            }
            else if (player1.winCount == 2)
            {
                Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " " + "Computer: " + player2.winCount);
                Console.WriteLine("YOU ARE THE WINNER!!! CONGRATS!");
                Console.WriteLine("You has beat " + player2.name + ". Congrats " + player1.name + "!");
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            string replay = Console.ReadLine().ToLower();
            while (replay != "yes" && replay != "no" && replay != "y" && replay != "n")
            {
                Console.Clear();
                Console.WriteLine("Don't be a dummy, type 'yes' or 'no'. Typing 'y' or 'n' is fine too.");
                replay = Console.ReadLine().ToLower();
            }
            switch (replay)
            {
                case "yes":
                    Run();
                    break;
                case "no":
                    break;
                case "y":
                    Run();
                    break;
                case "n":
                    break;
                default:
                    break;
            }
        }
        public void Compare()
        {
            if (winningPlays.Contains(player1.choice + player2.choice))
            {
                Console.Clear();
                player1.winCount += 1;
                Console.WriteLine(player1.name + " chose " + player1.choice);
                Console.WriteLine(player2.name + " chose " + player2.choice);
                Console.WriteLine(player1.name + " WON THIS ROUND!");
            }
            else if (ties.Contains(player1.choice + player2.choice))
            {
                Console.Clear();
                Console.WriteLine(player1.name + " chose " + player1.choice);
                Console.WriteLine(player2.name + " chose " + player2.choice);
                Console.WriteLine("IT'S A TIE! You both suck.");
            }
            else
            {
                Console.Clear();
                player2.winCount += 1;
                Console.WriteLine(player1.name + " chose " + player1.choice);
                Console.WriteLine(player2.name + " chose " + player2.choice);
                Console.WriteLine(player2.name + " WON THIS ROUND!");
            }
        }
        public void NameYourself()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Challenge: Hooman or Computer");
                opponent = Console.ReadLine().ToLower();
            } while (opponent != "hooman" && opponent != "computer" && opponent != "h" && opponent != "c" && opponent != "cpu" && opponent != "human");
            if (opponent == "hooman" || opponent == "h" || opponent == "human")
            {
                player1 = new Human();
                player2 = new Human();
                player1.Name();
                player2.Name();

            }
            else if (opponent == "computer" || opponent == "c" || opponent == "cpu")
            {
                player1 = new Human();
                player1.Name();
                player2 = new CPU();
                player2.Name();
            }
        }
        public void Run()
        {
            NameYourself();
            WinsTies();
            while (player1.winCount != 2 && player2.winCount != 2)
            {
                player1.ChooseOption(player1.name);
                player2.ChooseOption(player2.name);
                Compare();
                Console.ReadLine();
            }
            WinPrompt();
            PlayAgain();
        }
    }
}
