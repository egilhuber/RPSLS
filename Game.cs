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

        //public void RunSinglePlayerGame()
        //{
        //    while (PlayerOne.score < 2 && Dell.score < 2)
        //    {
        //        Console.WriteLine("---");
        //        Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
        //        PlayerOne.ChooseGesture();
        //        Dell.ChooseGesture();


        //        if (PlayerOne.chosenGesture == Dell.selection)
        //        {
        //            Console.WriteLine("Tie");
        //        }
        //        else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Paper")
        //        {
        //            Console.WriteLine(" computer wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Paper")
        //        {
        //            Console.WriteLine("player one  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Paper")
        //        {
        //            Console.WriteLine("player wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Paper")
        //        {
        //            Console.WriteLine("computer  wins");
        //            Dell.increaseScore();
        //        }
        //        //
        //        else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Rock")
        //        {
        //            Console.WriteLine("player   wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Rock")
        //        {
        //            Console.WriteLine("computer  wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Rock")
        //        {
        //            Console.WriteLine("computer  wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Rock")
        //        {
        //            Console.WriteLine("player  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        //
        //        else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Scissors")
        //        {
        //            Console.WriteLine("player  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Scissors")
        //        {
        //            Console.WriteLine(" computer wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Scissors")
        //        {
        //            Console.WriteLine("computer  wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Scissors")
        //        {
        //            Console.WriteLine("player  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        //
        //        else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Lizard")
        //        {
        //            Console.WriteLine("player  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Lizard")
        //        {
        //            Console.WriteLine("computer  wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Lizard")
        //        {
        //            Console.WriteLine("player  wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Lizard")
        //        {
        //            Console.WriteLine(" computer wins");
        //            Dell.increaseScore();
        //        }
        //        //
        //        else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Spock")
        //        {
        //            Console.WriteLine(" computer wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Spock")
        //        {
        //            Console.WriteLine(" player wins");
        //            PlayerOne.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Spock")
        //        {
        //            Console.WriteLine(" computer wins");
        //            Dell.increaseScore();
        //        }
        //        else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Spock")
        //        {
        //            Console.WriteLine(" player wins");
        //            PlayerOne.increaseScore();
        //        }
        //    }
        //}









        //public void CheckScore(object playerA, object playerB)
        //{
        //    if (playerA.score > 2 && playerA.score > playerB.score)
        //    {
        //        Console.WriteLine($"{playerA.name} wins");
        //        Console.ReadLine();
        //    }
        //    else if (playerB.score > 2 && playerB.score > playerA.score)
        //    {
        //        Console.WriteLine("Computer wins");
        //        Console.ReadLine();
        //    }
        //}

    }
}
