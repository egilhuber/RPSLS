using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerAi : Player
    {

        //member variables
        string name;
        //ctor
        public ComputerAi(string name):base(name)
        {
            this.name = name;
        }
        //member methods

        public override void ChooseGesture()
        {
            int RandomNumber(int min, int max)
            {
                Random compChoice = new Random();
                return compChoice.Next(min, max);
            }
            RandomNumber(0, 4);
            bool computerChoice = false;
            Console.WriteLine(computerChoice);
        }

    }
}
