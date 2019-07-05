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
        public string chosenGesture;
        //ctor
        public Human(string name) : base (name) 
        {
            this.name = name;
        }

        //member methods
        public override string ChooseGesture()
        {
            chosenGesture = Console.ReadLine();
            return chosenGesture;
        }

    }
}
