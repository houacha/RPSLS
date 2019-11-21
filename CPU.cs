using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class CPU : Player
    {
        public CPU()
        {

        }
        public int Rng(int startNum, int finalNum)
        {
            Random random = new Random();
            return random.Next(startNum, finalNum);
        }
        public override void ChooseOption(string turn)
        {
            choice = options[Rng(0, 5)];
        }
        public override void Name()
        {
            name = "Super Underestimated Computer King: Egor Robot";
        }
    }
}
