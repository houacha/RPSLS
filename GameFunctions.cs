using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    public class GameFuntions
    {
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
            while (answer != "yes" && answer != "no")
            {
                Console.Clear();
                Console.WriteLine("If you want to exit this prompt, you better answer 'yes' or 'no' to the initial question!");
                answer = Console.ReadLine().ToLower();
            }
            switch (answer)
            {
                case "yes":
                    Run();
                    break;
                case "no":
                    break;
                default:
                    break;
            }
        }
        public void Run()
        {
            bool isComputer = false;
            string opponent;
            Human player1 = new Human();
            player1.WinsTies();
            Human player2 = new Human();
            player2.WinsTies();
            CPU computer = new CPU();
            computer.WinsTies();
            do 
            {
                Console.Clear();
                Console.WriteLine("Challenge: Hooman or Computer");
                opponent = Console.ReadLine().ToLower();
            } while (opponent != "hooman" && opponent != "computer" && opponent != "h" && opponent != "c" && opponent != "cpu" && opponent != "human");
            if (opponent == "hooman" || opponent == "h" || opponent == "human")
            {
                 Console.Clear();
                 Console.WriteLine("Enter name for Player 1:");
                 player1.name = Console.ReadLine();
                 Console.Clear();
                 Console.WriteLine("Enter name for Player 2:");
                 player2.name = Console.ReadLine();
            }
            else if (opponent == "computer" || opponent == "c" || opponent == "cpu")
            {
                isComputer = true;
                Console.Clear();
                Console.WriteLine("Enter name for Player 1:");
                player1.name = Console.ReadLine();
            }
            while (player1.winCount != 2 && computer.winCount != 2 && player2.winCount != 2)
            {
                if (opponent == "hooman" || opponent == "h" || opponent == "human")
                {
                    player1.ChooseOption(player1.name);
                    player2.ChooseOption(player2.name);
                    if (player1.winningPlays.Contains(player1.choice + player2.choice))
                    {
                        Console.Clear();
                        player1.winCount += 1;
                        Console.WriteLine(player1.name + " chose " + player1.choice);
                        Console.WriteLine(player2.name + " chose " + player2.choice);
                        Console.WriteLine(player1.name + " WON THIS ROUND!");
                    }
                    else if (player1.ties.Contains(player1.choice + player2.choice))
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
                    Console.ReadLine();
                }
                else if (opponent == "computer" || opponent == "c" || opponent == "cpu")
                {

                    player1.ChooseOption(player1.name);
                    computer.ComputerChoose();
                    if (player1.winningPlays.Contains(player1.choice + computer.choice))
                    {
                        Console.Clear();
                        player1.winCount += 1;
                        Console.WriteLine(player1.name + " chose " + player1.choice);
                        Console.WriteLine("Computer chose " + computer.choice);
                        Console.WriteLine(player1.name + " WON THIS ROUND!");
                    }
                    else if (player1.ties.Contains(player1.choice + computer.choice))
                    {
                        Console.Clear();
                        Console.WriteLine(player1.name + " chose " + player1.choice);
                        Console.WriteLine("Computer chose " + computer.choice);
                        Console.WriteLine("IT'S A TIE! You both suck.");
                    }
                    else
                    {
                        Console.Clear();
                        computer.winCount += 1;
                        Console.WriteLine(player1.name + " chose " + player1.choice);
                        Console.WriteLine("Computer chose " + computer.choice);
                        Console.WriteLine("THE COMPUTER WON THIS ROUND!");
                    }
                    Console.ReadLine();
                }
            }
            if (computer.winCount == 2)
            {
                Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " Computer: " + computer.winCount);
                Console.WriteLine("You are an awful person. YOU LOSE!!!");
            }
            else if (player2.winCount == 2)
            {
                Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " " + player2.name + ": " + player2.winCount);
                Console.WriteLine(player2.name + " is the WINNER!!! Sorry " + player1.name + ", you suck hard.");
            }
            else if (player1.winCount == 2)
            {
                if (isComputer == true)
                {
                    Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " " + "Computer: " + computer.winCount);
                    Console.WriteLine("YOU ARE THE WINNER!!! CONGRATS!");
                }
                else {
                    Console.WriteLine("Final Scores: " + player1.name + ": " + player1.winCount + " " + player2.name + ": " + player2.winCount);
                    Console.WriteLine("You has beat " + player2.name + ". Congrats " + player1.name + "!");
                }
            }
            Console.ReadLine();
        }
    }
}
