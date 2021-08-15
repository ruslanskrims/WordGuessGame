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
            Console.WriteLine("What you want to do?" + System.Environment.NewLine +
                             "1) Guess a letter" + System.Environment.NewLine +
                             "2) Guess whole word" + System.Environment.NewLine +
                             "3) Get a hint" + System.Environment.NewLine +
                             "4) Exit the game" + System.Environment.NewLine);
            try
            {
                while ((userChoice != 1) && (userChoice != 2) && (userChoice != 3) && (userChoice != 4))
                {
                        userChoice = Convert.ToInt32(Console.ReadLine());
                }

                int choisehint = 0;
                if(userChoice == 1)
                {
                   
                    DecisionMaker.GuessTheLetter(answerForGame);
                    Console.WriteLine("ex");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Choose one of the hints given below..." + System.Environment.NewLine +
                      "1) I would like to know the length of this word" + System.Environment.NewLine +
                      "2) I would like to know the amount of identyical letters in the word" + System.Environment.NewLine +
                      "3) If there is such letter in the word?" + System.Environment.NewLine +
                      "4) Show me the first letter" + System.Environment.NewLine + 
                      "5) Open the random letter" + System.Environment.NewLine);
                    while ((choisehint != 1) && (choisehint != 2) && (choisehint != 3) && (choisehint != 4) && (choisehint != 5))
                    {
                        choisehint = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (userChoice == 4)
                {
                    Exit.ExitTheGameInstantly();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("TypeError!");
            }
        }
    }
 }
