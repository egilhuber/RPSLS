using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {

        //member variables 
        string name;
        //ctor
        public Human(string name) : base (name) 
        {
            this.name = name;
        }

        //member methods
        public override void ChooseGesture()
        {
            string chosenGesture = Console.ReadLine();
        }

    }
}
