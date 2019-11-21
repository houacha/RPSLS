using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    abstract class Player
    {
        public string name;
        public string choice;
        public int winCount;
        public abstract void ChooseOption(string turn);
        public abstract void Name(string yourName);
    }
}
