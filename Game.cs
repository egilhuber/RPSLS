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
        public string OpName;
        public string OgName;
        public string TwoName;

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
        public string HowManyPlayers()
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
                    OpName = Console.ReadLine();
                    Console.WriteLine($"Hello {OpName}");
                    return OpName;
                case "2":
                    Console.WriteLine("Enter player one name.");
                    OgName = Console.ReadLine();
                    Console.WriteLine($"Hello {OgName}");
                    Console.WriteLine("Enter player two name.");
                    TwoName = Console.ReadLine();
                    Console.WriteLine($"Hello {TwoName}");
                    return OgName + TwoName;

            }
            return ("fin");
        }



    }
}
