using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    abstract class Player
    {
        public List<string> options = new List<string>(){ "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public string name;
        public string choice;
        public int winCount;
        public abstract void ChooseOption(string turn);
        public abstract void Name();
    }
}
