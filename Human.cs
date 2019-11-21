using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class Human : Player
    {
        public string[] options = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public Human()
        {

        }
        public override void ChooseOption(string turn)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(turn + "'s turn");
                Console.WriteLine("Choose Your Warrior:");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine((i+1) + ". " + options[i]);
                }
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        choice = "rock";
                        break;
                    case "2":
                        choice = "paper";
                        break;
                    case "3":
                        choice = "scissors";
                        break;
                    case "4":
                        choice = "lizard";
                        break;
                    case "5":
                        choice = "spock";
                        break;
                    default:
                        break;
                }
            } while (choice != "paper" && choice != "rock" && choice != "scissors" && choice != "spock" && choice != "lizard");
        }
        public override void Name(string yourName)
        {
            Console.Clear();
            Console.WriteLine("Enter name for Player " + yourName + ":");
            name = Console.ReadLine();

        }
    }
}
