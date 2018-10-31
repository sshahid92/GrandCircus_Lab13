using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    class RoshamboApp
    {

        public RoshamboApp()
        {
        }

        public string ValidatePlayer(string input)
        {
            if(input == "jim")
            {
                Console.WriteLine("You will face Jim!");
                return "jim";
            }
            else if(input == "dwight")
            {
                Console.WriteLine("You will face Dwight!");
                return "dwight";
            }
            else
            {
                Console.WriteLine("That is not a valid answer. Please try again.");
                return "not valid";
            }
        }

        public Player ChoosePlayer(string input)
        {
            if(input == "jim")
            {
                RandomPlayer randomJim = new RandomPlayer("Jim");
                return randomJim;
            }
            else
            {
                RockPlayer rockDwight = new RockPlayer("Dwight");
                return rockDwight;
            }
        }
    }
}
