using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    //create a second player that randomly select from the three
    class RandomPlayer : Player
    {
        private string _name { get; set; }

        public RandomPlayer(string name)
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
