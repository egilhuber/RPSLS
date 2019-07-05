﻿using System;
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

            do
            {
                Console.WriteLine("---");
                Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
                PlayerOne.ChooseGesture();
                Dell.ChooseGesture();


                if (PlayerOne.chosenGesture == Dell.selection)
                {
                    Console.WriteLine("Tie");
                }
                else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Paper")
                {
                    Console.WriteLine(" computer wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Paper")
                {
                    Console.WriteLine("player one  wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Paper")
                {
                    Console.WriteLine("player wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Paper")
                {
                    Console.WriteLine("computer  wins");
                    Dell.increaseScore();
                }
                //
                else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Rock")
                {
                    Console.WriteLine("player   wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Rock")
                {
                    Console.WriteLine("computer  wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Rock")
                {
                    Console.WriteLine("computer  wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Rock")
                {
                    Console.WriteLine("player  wins");
                    PlayerOne.increaseScore();
                }
                //
                else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Scissors")
                {
                    Console.WriteLine("player  wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Scissors")
                {
                    Console.WriteLine(" computer wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Scissors")
                {
                    Console.WriteLine("computer  wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Scissors")
                {
                    Console.WriteLine("player  wins");
                    PlayerOne.increaseScore();
                }
                //
                else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Lizard")
                {
                    Console.WriteLine("player  wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Lizard")
                {
                    Console.WriteLine("computer  wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Lizard")
                {
                    Console.WriteLine("player  wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Spock" && Dell.selection == "Lizard")
                {
                    Console.WriteLine(" computer wins");
                    Dell.increaseScore();
                }
                //
                else if (PlayerOne.chosenGesture == "Rock" && Dell.selection == "Spock")
                {
                    Console.WriteLine(" computer wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Paper" && Dell.selection == "Spock")
                {
                    Console.WriteLine(" player wins");
                    PlayerOne.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Scissors" && Dell.selection == "Spock")
                {
                    Console.WriteLine(" computer wins");
                    Dell.increaseScore();
                }
                else if (PlayerOne.chosenGesture == "Lizard" && Dell.selection == "Spock")
                {
                    Console.WriteLine(" player wins");
                    PlayerOne.increaseScore();
                }

            }
            while (PlayerOne.score < 2 && Dell.score < 2);
            Console.WriteLine("---");
            if (PlayerOne.score > 2 && PlayerOne.score > Dell.score)
            {
                Console.WriteLine($"{PlayerOne.name} wins");
                Console.ReadLine();
            }
            else if (Dell.score > 2 && Dell.score > PlayerOne.score)
            {
                Console.WriteLine($"Computer wins");
                Console.ReadLine();
            }
        }
    }
}
