using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    class MenuNavigator
    {
        public static void MenuNavigate(string answerForGame)
        {
            int userChoice = 0;
            bool isTopicWasPicked = false;
            Console.WriteLine("What you want to do?" + System.Environment.NewLine +
                             "1) Guess whole word" + System.Environment.NewLine +
                             "2) Get a hint" + System.Environment.NewLine +
                             "3) Exit the game" + System.Environment.NewLine);
            isTopicWasPicked = Int32.TryParse(Console.ReadLine(), out userChoice)
                && userChoice > 0
                && userChoice <= 3;
            int choisehint = 0;
            int hintsLeft = answerForGame.Length / 2;
            switch (userChoice)
            {
                case 1:
                    DecisionMaker.GuessTheWord(answerForGame);
                    break;
                case 2:
                    DecisionMaker.TakeAHint(choisehint, answerForGame, hintsLeft);
                    break;
                case 3:
                    Exit.ExitTheGameInstantly();
                    break;
                default:
                    break;
            }
            if (!isTopicWasPicked)
            {
                Console.WriteLine("There is no topic with such number. Try again!");
                isTopicWasPicked = false;
            }
        }
    }
}
