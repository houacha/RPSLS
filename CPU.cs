using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class CPU : Player
    {
        public int Rng(int startNum, int finalNum)
        {
            Random random = new Random();
            return random.Next(startNum, finalNum);
        }
        public CPU()
        {

        }
        public void ComputerChoose()
        {
            switch (Rng(1,6))
            {
                case 1:
                    choice = "spock";
                    break;
                case 2:
                    choice = "rock";
                    break;
                case 3:
                    choice = "paper";
                    break;
                case 4:
                    choice = "scissors";
                    break;
                case 5:
                    choice = "lizard";
                    break;
                default:
                    break;
            }
        }
    }
}
