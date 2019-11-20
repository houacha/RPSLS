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
                    choice = "Spock";
                    break;
                case 2:
                    choice = "Rock";
                    break;
                case 3:
                    choice = "Paper";
                    break;
                case 4:
                    choice = "Scissors";
                    break;
                case 5:
                    choice = "Lizard";
                    break;
                default:
                    break;
            }
        }
    }
}
