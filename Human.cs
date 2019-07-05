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
        public string name;
        public string chosenGesture;
        public int score;
        //ctor
        public Human(string name) : base (name) 
        {
            this.name = name;
            score = 0;
        }

        //member methods
        public override string ChooseGesture()
        {
            chosenGesture = Console.ReadLine();
            return chosenGesture;
        }

        public override int increaseScore()
        {
            score++;
            Console.WriteLine($"{name} score: {score}");
            Console.WriteLine("---");
            return score;

        }

    }
}
