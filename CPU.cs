using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class CPU : Player
    {
        public int Rng()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
        public CPU()
        {

        }
        public void ComputerChoose()
        {
            switch (Rng())
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
