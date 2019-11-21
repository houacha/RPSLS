using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class Player
    {
        public List<string> winningPlays = new List<string>();
        public List<string> ties = new List<string>();
        public List<string> combos = new List<string>();
        public string choice;
        public int winCount;
        public string[] options = {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
        public Player()
        {

        }
        public void WinsTies()
        {
            for (int i = 0; i < options.Length; i++)
            {
                for (int j = 0; j < options.Length; j++)
                {
                    if (winningPlays.Contains((options[j] + options[i]).ToLower()))
                    {
                        continue;
                    }
                    else if (options[j] == options[i])
                    {
                        ties.Add((options[j] + options[i]).ToLower());
                    }
                    else if (options[i] == "Rock")
                    {
                        if (options[j] == "Scissors" || options[j] == "Lizard")
                        {
                            winningPlays.Add((options[i] + options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (options[i] == "Scissors")
                    {
                        if (options[j] == "Paper" || options[j] == "Lizard")
                        {
                            winningPlays.Add((options[i] + options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (options[i] == "Paper")
                    {
                        if (options[j] == "Rock" || options[j] == "Spock")
                        {
                            winningPlays.Add((options[i] + options[j]).ToLower());
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (options[i] == "Spock")
                    {
                        if (options[j] == "Rock" || options[j] == "Scissors")
                        {
                            winningPlays.Add(options[i] + options[j]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (options[i] == "Lizard")
                    {
                        if (options[j] == "Spock" || options[j] == "Paper")
                        {
                            winningPlays.Add((options[i] + options[j]).ToLower());
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
    }
}
