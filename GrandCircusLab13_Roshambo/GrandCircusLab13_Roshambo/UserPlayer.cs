using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    class UserPlayer : Player
    {
        //third player class that inherits from player and implements the generateRoshambo method
        //this method can return any value user chooses
        private string _name { get; set; }

        public UserPlayer(string name, Roshambo userInput)
        {
            _name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            Array rpsArray = Enum.GetValues(typeof(Roshambo));
            Random r = new Random();
            Roshambo randomRPS = (Roshambo)rpsArray.GetValue(r.Next(rpsArray.Length));
            return randomRPS;
        }
    }
}
