using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerAi : Player
    {

        //member variables
        string name;
        public string selection;
        //ctor
        public ComputerAi(string name):base(name)
        {
            this.name = name;
        }
        //member methods

        public override string ChooseGesture()
        {
            
            int RandomNumber(int min, int max)
            {
                Random compChoice = new Random();
                return compChoice.Next(min, max);
            }
           
            int computerChoice =  RandomNumber(0, 4);
            //Console.WriteLine("computer: " + computerChoice);
            List<string> CompGestures = new List<string>();
            CompGestures.Add("Rock");
            CompGestures.Add("Paper");
            CompGestures.Add("Scissors");
            CompGestures.Add("Lizard");
            CompGestures.Add("Spock");



            if (computerChoice == 0)
            {
                selection = CompGestures[0];
                Console.WriteLine(selection);
                Console.ReadLine();
                return selection;
            }
            else if (computerChoice == 1)
            {
                selection = CompGestures[1];
                Console.WriteLine(selection);
                Console.ReadLine();
                return selection;
            }
            else if (computerChoice == 2)
            {
                selection = CompGestures[2];
                Console.WriteLine(selection);
                Console.ReadLine();
                return selection;
            }
            else if (computerChoice == 3)
            {
                selection = CompGestures[3];
                Console.WriteLine(selection);
                Console.ReadLine();
                return selection;
            }
            else if (computerChoice == 4)
            {
                selection = CompGestures[4];
                Console.WriteLine(selection);
                Console.ReadLine();
                return selection;
            }
            return ("a string");
        }

    }
}
