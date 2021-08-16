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
            bool decisionIsMade = false;
            int amountOfSameLettersInWord;
            Console.WriteLine("What you want to do?" + System.Environment.NewLine +
                             "1) Guess whole word" + System.Environment.NewLine +
                             "2) Get a hint" + System.Environment.NewLine +
                             "3) Exit the game" + System.Environment.NewLine);
                while ((userChoice != 1) && (userChoice != 2) && (userChoice != 3) && (userChoice != 4))
                {
                    Int32.TryParse(s: Console.ReadLine(), out userChoice);
                }

                int choisehint = 0;
                switch (userChoice)
                {
                    case 1:
                        DecisionMaker.GuessTheWord(answerForGame);
                        break;
                    case 2:
                        Console.WriteLine("Choose one of the hints given below..." + System.Environment.NewLine +
                      "1) I would like to know the length of this word" + System.Environment.NewLine +
                      "2) I would like to know the amount of identyical letters in the word" + System.Environment.NewLine +
                      "3) If there is such letter in the word?" + System.Environment.NewLine +
                      "4) Show me the first letter" + System.Environment.NewLine +
                      "5) Open the random letter" + System.Environment.NewLine);
                        {
                        decisionIsMade = Int32.TryParse(Console.ReadLine(), out choisehint)
                        && choisehint > 0
                        && choisehint <= 5;
                        }
                        switch(choisehint)
                        {
                        case 1:
                            Console.WriteLine(answerForGame.Length);
                            break;
                        case 2:
                            Console.WriteLine("Write a letter to count it's duplication in the word");
                            char letter = (char)Console.Read();
                            amountOfSameLettersInWord = DecisionMaker.CountTheAmountOfGivenLetter(answerForGame, letter);
                            Console.WriteLine($"The amount of letters in word is {amountOfSameLettersInWord} letters");
                            break;
                        case 3:
                            DecisionMaker.GuessTheLetter(answerForGame);
                            break;
                        case 4:
                            DecisionMaker.ShowFirstLetterOfWord(answerForGame);
                            break;
                        case 5:
                            DecisionMaker.ShowRandomLetterInWord(answerForGame);
                            break;
                        default:
                            break;
                    }
                    if(!decisionIsMade)
                    {
                        Console.WriteLine("Decision is higher than 6");
                        MenuNavigator.MenuNavigate(answerForGame);
                    }
                        break;
                    case 3:
                    Exit.ExitTheGameInstantly();
                    
                    break;
                    case 4:
                        DecisionMaker.ShowFirstLetterOfWord(answerForGame);
                        break;
                    default:
                        Exit.ExitTheGameInstantly();
                        break;
                }
        }
    }
}
