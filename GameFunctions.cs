using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    public class GameFuntions
    {
        public List<string> winningPlays = new List<string>();
        public List<string> losingPlays = new List<string>();
        public List<string> ties = new List<string>();
        public GameFuntions()
        {

        }
        public void Run()
        {
            Human player1 = new Human();
            player1.AllCombos();
            Human player2 = new Human();
            player2.AllCombos();
            CPU computer = new CPU();
            computer.AllCombos();
            // player1.ChooseOption();
            // Console.WriteLine(player1.choice.ToLower());
            // Console.ReadLine();

        }
    }
}
