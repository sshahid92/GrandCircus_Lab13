using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    public enum Roshambo
    {
        //build an enum that contains rock, paper, and sissors        
        rock,
        paper,
        scisscor
    }
    public class RPSBattle
    {
        public void Battle(string playerInput, string opponentInput, string playerName, string opponentName)
        {
            Console.WriteLine($"{playerName}: {playerInput}");
            Console.WriteLine($"{opponentName}: {opponentInput}");

            if (playerInput == opponentInput)
            {
                Console.WriteLine("DRAW!");
            }
            else if (playerInput == "rock" && opponentInput == "scissors")
            {
                Console.WriteLine($"{playerName} wins!");
            }
            else if (playerInput == "paper" && opponentInput == "rock")
            {
                Console.WriteLine($"{playerName} wins!");
            }
            else if (playerInput == "scissors" && opponentInput == "paper")
            {
                Console.WriteLine($"{playerName} wins!");
            }

            else if (opponentInput == "rock" && playerInput == "scissors")
            {
                Console.WriteLine($"{opponentName} wins!");
            }
            else if (opponentInput == "paper" && playerInput == "rock")
            {
                Console.WriteLine($"{opponentName} wins!");
            }
            else if (opponentInput == "scissors" && playerInput == "paper")
            {
                Console.WriteLine($"{opponentName} wins!");
            }
        }
    }

}
