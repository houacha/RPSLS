using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS
{
    class Human : Player
    {
        public Human()
        {

        }
        public void ChooseOption()
        {
            Console.WriteLine("Choose Your Warrior:");
            foreach (string choices in options)
            {
                Console.WriteLine(choices);
            }
            choice = Console.ReadLine();
        }
    }
}
