using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13_Roshambo
{
    class Program
    {
        public static int drawCount;
        public static int winCount;
        public static int lossCount;

        static void Main(string[] args)
        {
            Validation validate = new Validation();
            RoshamboApp roshamboApp = new RoshamboApp();
            
            string player = "";
            string validatePlayer;
            string opponent;
            string userRPS;
            bool isPlayer = false;
            bool exitGame = false;
            

        Console.WriteLine("Welcome to Rock Paper Scissors!");

            //enter a name and select opponent
            Console.Write("Enter your name: ");

            while (!isPlayer)
            {
                player = Console.ReadLine();
                isPlayer = validate.String(player, @"^[A-Za-z]{1,30}$", "Please enter a valid name.");
            }

            do
            {
                Console.WriteLine("Would you like to play against Jim or Dwight?");
                opponent = Console.ReadLine();
                validatePlayer = roshamboApp.ValidatePlayer(opponent.ToLower());
            } while (validatePlayer == "not valid");

            Player enemey = roshamboApp.ChoosePlayer(opponent.ToLower());
            while (!exitGame)
            {
                bool? yn = null;
                //promp player to select rock paper or sissors
                do
                {
                    Console.WriteLine("Select 'Rock', 'Paper' or 'Scissors'. (R/P/S)");
                    userRPS = validate.RPSSelection(Console.ReadLine().ToLower());
                } while (userRPS == "not valid");

                //display players choice and the result of the match
                RPSBattle gameLogic = new RPSBattle();
                gameLogic.Battle(userRPS, enemey.GenerateRoshambo().ToString(), player, opponent);

                //prompt user to play again
                while (yn == null)
                {
                    Console.WriteLine("Play again? (y/n)");
                    string promptUser = Console.ReadLine();
                    yn = validate.YesNo(promptUser, "Enter a valid response");
                }

                if(yn == true)
                {
                    exitGame = false;
                }
                else if(yn == false)
                {
                    Console.WriteLine($"Wins: {winCount}\n" +
                                      $"Losses: {lossCount}\n" +
                                      $"Draws: {drawCount}");
                    Console.ReadLine();
                    exitGame = true;
                }
            }





        }
    }
}
