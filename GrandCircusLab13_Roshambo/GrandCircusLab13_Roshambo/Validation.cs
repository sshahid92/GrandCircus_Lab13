using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    class Validation
    {
        public Validation()
        {
        }
        
        public string RPSSelection(string input)
        {
            switch (input)
            {
                case "r":
                case "rock":
                    return "rock";

                case "p":
                case "paper":
                    return "paper";

                case "s":
                case "scissors":
                    return "scissors";
                
                default:
                    Console.WriteLine("That is not a valid selection. Try again.");
                    return "not valid";
            }
        }

        public bool String(string input, string regex, string failMessage)
        {
            bool validate = Regex.IsMatch(input, regex);
            if (validate == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine(failMessage);
                return false;
            }
        }

        public bool? YesNo(string input, string nullMessage)
        {
            switch (input)
            {
                case "yes":
                case "y":
                    return true;

                case "no":
                case "n":
                    return false;


                default:
                    Console.WriteLine(nullMessage);
                    return null;
            }
        }
    }
}
