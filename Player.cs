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
        public List<string> losingPlays = new List<string>();
        public List<string> ties = new List<string>();
        public List<string> combos = new List<string>();
        public string choice;
        public int winCount;
        public string[] options = {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
        public Player()
        {

        }
        public void AllCombos()
        {
            for (int i = 0; i < options.Length; i++)
            {
                for (int j = 0; j < options.Length; j++)
                {
                    if (combos.Contains((options[j] + options[i]).ToLower()))
                    {
                        continue;
                    }
                    else
                    {
                        combos.Add((options[i] + options[j]).ToLower());
                    }
                }
            }
        }
        public void WinsLoseTie()
        {
            for (int i = 0; i < options.Length; i++)
            {
                for (int j = 0; j < options.Length; j++)
                {
                  
                }
            }
        }
    }
}
