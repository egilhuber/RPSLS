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
            chosenGesture.ToLower();
            if (chosenGesture == "rock")
            {
               return chosenGesture.ToLower(); 
            }
            else if (chosenGesture == "paper")
            {
                return chosenGesture.ToLower();
            }
            else if (chosenGesture == "scissors")
            {
                return chosenGesture.ToLower();
            }
            else if (chosenGesture == "lizard")
            {
                return chosenGesture.ToLower();
            }
            else if (chosenGesture == "spock")
            {
                return chosenGesture.ToLower();
            }
            else
            {
                Console.WriteLine("Invalid entry.");
                ChooseGesture();
            }
            return "shouldn't be here";

        }

        public override int IncreaseScore(string pName)
        {
            score++;
            if (score >= 2)
            {
                Console.WriteLine($"{pName} wins game");
                Console.WriteLine($"{pName}'s final score: {score}");
                Console.ReadLine();
                return score;
            }
            else
            {
                Console.WriteLine($"{pName} score: {score}");
                Console.WriteLine("---");
                return score;
            }
        }

    }
}
