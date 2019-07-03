using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {

        //member variables

        //ctor
        public Game()
        {

        }

        //member methods
        public void PromptRules()
        {
            Console.WriteLine("---");
            Console.WriteLine("Would you like to review the rules?");
            string DisplayRulesResponse = Console.ReadLine();
            switch(DisplayRulesResponse)
            {
                case "yes":
                case "y":
                case "Yes":
                case "YES":
                    Console.WriteLine("---");
                    Console.WriteLine("Rock crushes scissors and lizard \n" +
                        "Paper covers rock and disproves Spock \n" +
                        "Scissors cut paper and decapitate lizard \n" +
                        "Lizard eats paper and poisons Spock \n" +
                        "Spock breaks scissors and vaporizes rock");
                    break;
                case "no":
                case "n":
                case "No":
                case "NO":
                    Console.WriteLine("---");
                    Console.WriteLine("okay");
                    break;
                default:
                    Console.WriteLine("---");
                    Console.WriteLine("Please enter yes or no.");
                    PromptRules();
                    break;
            }
        }
        public void HowManyPlayers()
        {
            Console.WriteLine("---");
            Console.WriteLine("1 or 2 players?");
            string PlayerQuantity = Console.ReadLine();
            Console.WriteLine($"{PlayerQuantity}? Great!");
            Console.WriteLine("---");
            switch (PlayerQuantity)
            {
                case "1":
                    Console.WriteLine("Enter player one name.");
                    string OpName = Console.ReadLine();
                    Human PlayerOne = new Human(OpName);
                    Console.WriteLine($"Hello {OpName}");
                    Console.WriteLine("Please name the computer.");
                    string compName = Console.ReadLine();
                    ComputerAi Dell = new ComputerAi(compName);
                    Console.WriteLine($"You have named the computer {compName}.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Enter player one name.");
                    string OgName = Console.ReadLine();
                    Human FirstPlayer = new Human(OgName);
                    Console.WriteLine($"Hello {OgName}");
                    Console.WriteLine("Enter player two name.");
                    string TwoName = Console.ReadLine();
                    Human SecondPlayer = new Human(TwoName);
                    Console.WriteLine($"Hello {TwoName}");
                    Console.ReadLine();
                    break;

            }
                
        }
        public void PlayGame()
        {
            Console.WriteLine();

        }

    }
}
