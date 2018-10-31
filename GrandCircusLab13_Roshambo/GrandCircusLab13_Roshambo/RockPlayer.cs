using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{   
    //create one player that always selects rocks
    class RockPlayer : Player
    {
        private string _name { get; set; }

        public RockPlayer(string name)
        {
            _name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
