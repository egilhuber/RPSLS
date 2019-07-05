using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        //member variables 
        public string name;
        public int score;
        //ctor
        public Player(string name)
        {
            this.name = name;
            score = 0;
        }

        //member methods
        abstract public string ChooseGesture();

        abstract public int increaseScore();


    }
}
