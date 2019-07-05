using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            Game newGame = new Game();



            Console.WriteLine("---");
            Console.WriteLine("Welcome to Rockpaperscissorslizardspock.");
            newGame.PromptRules();
            newGame.HowManyPlayers();
            Human PlayerOne = new Human("name");
            ComputerAi Dell = new ComputerAi("compName");
            Human SecondPlayer = new Human("TwoName");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
            PlayerOne.ChooseGesture();
            Dell.ChooseGesture();

            //newGame.WhoWinsThisRound();
            if (PlayerOne.chosenGesture == Dell.selection)
            {
                Console.WriteLine("Tie");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture== "Rock" && Dell.selection == "Paper")
            {
                Console.WriteLine(" computer wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Paper")
            {
                Console.WriteLine("player one  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Paper")
            {
                Console.WriteLine("player wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Paper")
            {
                Console.WriteLine("computer  wins");
                Console.ReadLine();
            }
            //
            else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Rock")
            {
                Console.WriteLine("player   wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Rock")
            {
                Console.WriteLine("computer  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Rock")
            {
                Console.WriteLine("computer  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Rock")
            {
                Console.WriteLine("player  wins");
                Console.ReadLine();
            }
            //
            else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Scissors")
            {
                Console.WriteLine("  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Scissors")
            {
                Console.WriteLine("  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Scissors")
            {
                Console.WriteLine("  wins");
                Console.ReadLine();
            }
            else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Scissors")
            {
                Console.WriteLine("  wins");
                Console.ReadLine();
            }


        }
    }
}
