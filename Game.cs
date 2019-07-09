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
        public string TwoName;
        public string CompName;
        public int PlayerQuant;

        

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
                case "Y":
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
                case "N":
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

            if (PlayerQuantity == "1")
            {
                Console.WriteLine($"{PlayerQuantity}? Great!");
                Console.WriteLine("---");
                NamePlayerOne();
                NameComputer();
                RunSinglePlayerGame(OpName, CompName);
            }
            else if (PlayerQuantity == "2")
            {
                Console.WriteLine($"{PlayerQuantity}? Great!");
                Console.WriteLine("---");
                NamePlayerOne();
                NamePlayerTwo();
                RunTwoPlayerGame(OpName, TwoName);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2.");
                HowManyPlayers();
            }
            return ("shouldn't be here");
        }
        public string NamePlayerOne()
        {
            Console.WriteLine("Enter player one name.");
            OpName = Console.ReadLine();
            if (OpName == "flamingo" || OpName == "Flamingo")
            {



                Console.WriteLine("     ___                      ");
                Console.WriteLine("   ,'   `.                    ");
                Console.WriteLine("  /_. _,. |                   ");
                Console.WriteLine(" 0 /0'   | :                  ");
                Console.WriteLine("  \\|    / :                  ");
                Console.WriteLine("   `'   / /                   ");
                Console.WriteLine("       / /                    ");
                Console.WriteLine("      : :                     ");
                Console.WriteLine("      | :    _______          ");
                Console.WriteLine("      :  | ,'       `-._      ");
                Console.WriteLine("      '   /    .  .  .  |     ");
                Console.WriteLine("       : `' :  :  :  : , :    ");
                Console.WriteLine("        |`./  /  /  / : ::    ");
                Console.WriteLine("         `. `'../__/ / ,.|    ");
                Console.WriteLine("            `'-.____;-'`\\|   ");
                Console.WriteLine("                | //   / '|   ");
                Console.WriteLine("                 ::|          ");
                Console.WriteLine("                 ||\\         ");
                Console.WriteLine("                 || \\        ");
                Console.WriteLine("                 ||  ||       ");
                Console.WriteLine("                 || //        ");
                Console.WriteLine("                 ||//         ");
                Console.WriteLine("                 ||/          ");
                Console.WriteLine("                 ||           ");
                Console.WriteLine("                /||           ");
                Console.WriteLine("                `||-          ");
                Console.WriteLine("              __,':           ");



            }
            else if (OpName == "banana" || OpName == "Banana")
            {
                Console.WriteLine(" /`-.__                                 /|    ");
                Console.WriteLine(" `. .  ~~--..__                   __..-' ,'   ");
                Console.WriteLine("   `.`-.._     ~~---...___...---~~  _,~,/     ");
                Console.WriteLine("     `-._ ~--..__             __..-~ _-~      ");
                Console.WriteLine("         ~~-..__ ~~--.....--~~   _.-~         ");
                Console.WriteLine("                ~~--...___...--~~             ");
            }
            Console.WriteLine($"Hello {OpName}");
            return OpName;
        }
        public string NameComputer()
        {
            Console.WriteLine("Please name the computer.");
            CompName = Console.ReadLine();
            if (CompName == "flamingo" || CompName == "Flamingo")
            {

                Console.WriteLine("     ___                      ");
                Console.WriteLine("   ,'   `.                    ");
                Console.WriteLine("  /_. _,. |                   ");
                Console.WriteLine(" 0 /0'   | :                  ");
                Console.WriteLine("  \\|    / :                  ");
                Console.WriteLine("   `'   / /                   ");
                Console.WriteLine("       / /                    ");
                Console.WriteLine("      : :                     ");
                Console.WriteLine("      | :    _______          ");
                Console.WriteLine("      :  | ,'       `-._      ");
                Console.WriteLine("      '   /    .  .  .  |     ");
                Console.WriteLine("       : `' :  :  :  : , :    ");
                Console.WriteLine("        |`./  /  /  / : ::    ");
                Console.WriteLine("         `. `'../__/ / ,.|    ");
                Console.WriteLine("            `'-.____;-'`\\|   ");
                Console.WriteLine("                | //   / '|   ");
                Console.WriteLine("                 ::|          ");
                Console.WriteLine("                 ||\\         ");
                Console.WriteLine("                 || \\        ");
                Console.WriteLine("                 ||  ||       ");
                Console.WriteLine("                 || //        ");
                Console.WriteLine("                 ||//         ");
                Console.WriteLine("                 ||/          ");
                Console.WriteLine("                 ||           ");
                Console.WriteLine("                /||           ");
                Console.WriteLine("                `||-          ");
                Console.WriteLine("              __,':           ");



            }
            else if (CompName == "banana" || CompName == "Banana")
            {
                Console.WriteLine(" /`-.__                                 /|    ");
                Console.WriteLine(" `. .  ~~--..__                   __..-' ,'   ");
                Console.WriteLine("   `.`-.._     ~~---...___...---~~  _,~,/     ");
                Console.WriteLine("     `-._ ~--..__             __..-~ _-~      ");
                Console.WriteLine("         ~~-..__ ~~--.....--~~   _.-~         ");
                Console.WriteLine("                ~~--...___...--~~             ");
            }
            Console.WriteLine($"Computer's name is {CompName}");
            return CompName;
        }
        public string NamePlayerTwo()
        {
            Console.WriteLine("Enter player two name.");
            TwoName = Console.ReadLine();
            if (TwoName == "flamingo" || TwoName == "Flamingo")
            {

                Console.WriteLine("     ___                      ");
                Console.WriteLine("   ,'   `.                    ");
                Console.WriteLine("  /_. _,. |                   ");
                Console.WriteLine(" 0 /0'   | :                  ");
                Console.WriteLine("  \\|    / :                  ");
                Console.WriteLine("   `'   / /                   ");
                Console.WriteLine("       / /                    ");
                Console.WriteLine("      : :                     ");
                Console.WriteLine("      | :    _______          ");
                Console.WriteLine("      :  | ,'       `-._      ");
                Console.WriteLine("      '   /    .  .  .  |     ");
                Console.WriteLine("       : `' :  :  :  : , :    ");
                Console.WriteLine("        |`./  /  /  / : ::    ");
                Console.WriteLine("         `. `'../__/ / ,.|    ");
                Console.WriteLine("            `'-.____;-'`\\|   ");
                Console.WriteLine("                | //   / '|   ");
                Console.WriteLine("                 ::|          ");
                Console.WriteLine("                 ||\\         ");
                Console.WriteLine("                 || \\        ");
                Console.WriteLine("                 ||  ||       ");
                Console.WriteLine("                 || //        ");
                Console.WriteLine("                 ||//         ");
                Console.WriteLine("                 ||/          ");
                Console.WriteLine("                 ||           ");
                Console.WriteLine("                /||           ");
                Console.WriteLine("                `||-          ");
                Console.WriteLine("              __,':           ");



            }
            else if (TwoName == "banana" || TwoName == "Banana")
            {
                Console.WriteLine(" /`-.__                                 /|    ");
                Console.WriteLine(" `. .  ~~--..__                   __..-' ,'   ");
                Console.WriteLine("   `.`-.._     ~~---...___...---~~  _,~,/     ");
                Console.WriteLine("     `-._ ~--..__             __..-~ _-~      ");
                Console.WriteLine("         ~~-..__ ~~--.....--~~   _.-~         ");
                Console.WriteLine("                ~~--...___...--~~             ");
            }
            Console.WriteLine($"Hello {TwoName}");
            return TwoName;
        }

        Human PlayerOne = new Human("Player One");
        ComputerAi Dell = new ComputerAi("Computer");
        Human PlayerTwo = new Human("Player 2");

        public void RunSinglePlayerGame(string pName, string cName)
        {
            while (PlayerOne.score < 2 && Dell.score < 2)
            {
                CheckScoreSingle(OpName, CompName);
                Console.WriteLine("---");
                Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
                PlayerOne.ChooseGesture();
                Dell.ChooseGesture();


                if (PlayerOne.chosenGesture == Dell.selection)
                {
                    Console.WriteLine("Tie");
                }
                else if (PlayerOne.chosenGesture == "rock" && Dell.selection == "paper")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "scissors" && Dell.selection == "paper")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "lizard" && Dell.selection == "paper")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "spock" && Dell.selection == "paper")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                //
                else if (PlayerOne.chosenGesture == "paper" && Dell.selection == "rock")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "scissors" && Dell.selection == "rock")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "lizard" && Dell.selection == "rock")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "spock" && Dell.selection == "rock")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && Dell.selection == "scissors")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "paper" && Dell.selection == "scissors")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "lizard" && Dell.selection == "scissors")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "spock" && Dell.selection == "scissors")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && Dell.selection == "lizard")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "paper" && Dell.selection == "lizard")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "scissors" && Dell.selection == "lizard")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "spock" && Dell.selection == "lizard")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && Dell.selection == "spock")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "paper" && Dell.selection == "spock")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
                else if (PlayerOne.chosenGesture == "scissors" && Dell.selection == "spock")
                {
                    Console.WriteLine($"{cName} scores");
                    Dell.IncreaseScore(cName);
                }
                else if (PlayerOne.chosenGesture == "lizard" && Dell.selection == "spock")
                {
                    Console.WriteLine($"{pName} scores");
                    PlayerOne.IncreaseScore(pName);
                }
            }
        }
        public void RunTwoPlayerGame(string p1Name, string p2Name)
        {
            while (PlayerOne.score < 2 && PlayerTwo.score < 2)
            {
                CheckScoreMulti(OpName, TwoName);
                Console.WriteLine("---");
                Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
                PlayerOne.ChooseGesture();
                PlayerTwo.ChooseGesture();


                if (PlayerOne.chosenGesture == PlayerTwo.chosenGesture)
                {
                    Console.WriteLine("Tie");
                }
                else if (PlayerOne.chosenGesture == "rock" && PlayerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "scissors" && PlayerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Player 1  scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "lizard" && PlayerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "spock" && PlayerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                //
                else if (PlayerOne.chosenGesture == "paper" && PlayerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "scissors" && PlayerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "lizard" && PlayerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "spock" && PlayerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && PlayerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "paper" && PlayerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "lizard" && PlayerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "spock" && PlayerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && PlayerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "paper" && PlayerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "scissors" && PlayerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "spock" && PlayerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                //
                else if (PlayerOne.chosenGesture == "rock" && PlayerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "paper" && PlayerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
                else if (PlayerOne.chosenGesture == "scissors" && PlayerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player 2 scores");
                    PlayerTwo.IncreaseScore(p2Name);
                }
                else if (PlayerOne.chosenGesture == "lizard" && PlayerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player 1 scores");
                    PlayerOne.IncreaseScore(p1Name);
                }
            }
        }









        public void CheckScoreSingle(string pName, string cName)
        {
            if (PlayerOne.score > 2 && PlayerOne.score > Dell.score)
            {
                Console.WriteLine($"{pName} wins");
                Console.ReadLine();
            }
            else if (Dell.score > 2 && Dell.score > PlayerOne.score)
            {
                Console.WriteLine($"{cName} wins");
                Console.ReadLine();
            }
        }


        public void CheckScoreMulti(string p1Name, string p2Name)
        {
            if (PlayerOne.score > 2 && PlayerOne.score > PlayerTwo.score)
            {
                Console.WriteLine($"{p1Name} wins");
                Console.ReadLine();
            }
            else if (PlayerTwo.score > 2 && PlayerTwo.score > PlayerOne.score)
            {
                Console.WriteLine($"{p2Name} 2 wins");
                Console.ReadLine();
            }
        }

    }
}
