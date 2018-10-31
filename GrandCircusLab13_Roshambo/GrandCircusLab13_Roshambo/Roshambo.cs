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
        scissors
    }
    public class RPSBattle
    {
        
        public void Battle(string playerInput, string opponentInput, string playerName, string opponentName)
        {
            Console.WriteLine($"{playerName}: {playerInput}");
            Console.WriteLine($"{opponentName}: {opponentInput}");

            if (playerInput == opponentInput)
            {
                Program.drawCount++;
                Console.WriteLine("DRAW!");
            }
            else if ((playerInput == "rock" && opponentInput == "scissors") ||
                    (playerInput == "paper" && opponentInput == "rock") ||
                    (playerInput == "scissors" && opponentInput == "paper"))
            {
                Program.winCount++;
                Console.WriteLine($"{playerName} wins!");
            }

            else if ((opponentInput == "rock" && playerInput == "scissors") ||
                    (opponentInput == "paper" && playerInput == "rock") ||
                    (opponentInput == "scissors" && playerInput == "paper"))
            {
                Program.lossCount++;
                Console.WriteLine($"{opponentName} wins!");
            }
        }
    }

}
