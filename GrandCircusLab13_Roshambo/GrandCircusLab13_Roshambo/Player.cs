using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    public abstract class Player
    {        
        //create an abstract class called player that stores name and roshambo value
        //the class should include an abstract method called generateRoshambo 
        //that allows an inheriting class to generate and return a roshambo value
        public abstract Roshambo GenerateRoshambo();
    }
}
