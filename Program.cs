using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
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
            newGame.PlayGame();
            

            
        }
    }
}
