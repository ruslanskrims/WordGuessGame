using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    public class DecisionMaker
    {
        public static void GuessTheLetter(string a)
        {
            Console.WriteLine("Enter the letter,please...");
            char letter = (char)Console.Read();
            bool result = a.Contains(letter);
            if(result)
            {
                Console.WriteLine("Correct! There is such letter in the word");
            } else
            {
                Console.WriteLine("Wrong! There is no such a letter in the word");
            }
            MenuNavigator.MenuNavigate(a);
        }

        public static void GuessTheWord(string a)
        {
            Console.WriteLine("Enter the word,please...");
            string word = Console.ReadLine().ToString();
            if (a == word)
            {
                Console.WriteLine($"Word is correct! It is a {a}");
                var b = TopicSelection.ChooseTheTopic();
                MenuNavigator.MenuNavigate(b);
            } else { 
                Console.WriteLine("Word is not correct!");
            }
            MenuNavigator.MenuNavigate(a);
        }
        public static void TakeAHint(int choisehint, string answerForGame, int hints)
        {
            bool decisionIsMade = false;
            Console.WriteLine("Choose one of the hints given below..." + System.Environment.NewLine +
                      "1) I would like to know the length of this word" + System.Environment.NewLine +
                      "2) I would like to know the amount of identyical letters in the word" + System.Environment.NewLine +
                      "3) If there is such letter in the word?" + System.Environment.NewLine +
                      "4) Show me the first letter" + System.Environment.NewLine +
                      "5) Open the random letter" + System.Environment.NewLine);
                decisionIsMade = Int32.TryParse(Console.ReadLine(), out choisehint)
                && choisehint > 0
                && choisehint <= 5;
            switch (choisehint)
            {
                case 1:
                    GetWordLength(answerForGame);
                    break;
                case 2:
                    CountTheAmountOfGivenLetter(answerForGame);
                    break;
                case 3:
                    GuessTheLetter(answerForGame);
                    break;
                case 4:
                    ShowFirstLetterOfWord(answerForGame);
                    break;
                case 5:
                    ShowRandomLetterInWord(answerForGame);
                    break;
                default:
                    break;
            }
            if (!decisionIsMade)
            {
                Console.WriteLine("There is no decision with such number. Try again!");
                decisionIsMade = false;
            }
            if (hints > 0)
            {
                hints--;
                Console.WriteLine($"You have {hints} hints left");
            } else
            {
                Console.WriteLine("You are out of hints!");
                MenuNavigator.MenuNavigate(answerForGame);
            }
            DecisionMaker.TakeAHint(choisehint, answerForGame, hints);
        }

        public static void GetWordLength(string word)
        {
            Console.WriteLine(word.Length);
        }               

        public static void CountTheAmountOfGivenLetter(string word)
        {
            int amountOfSameLettersInWord;
            Console.WriteLine("Write a letter to count it's duplication in the word");
            char countableLetter = (char)Console.Read();
            amountOfSameLettersInWord = word.Count(letter => letter == countableLetter);
            Console.WriteLine($"The amount of letters in word is {amountOfSameLettersInWord} letters");
        }

        public static void ShowFirstLetterOfWord(string word)
        {
            char firstname_initial;
            firstname_initial = word[0];
            Console.WriteLine($"First letter of the word is {firstname_initial}");
        }

        public static void ShowRandomLetterInWord(string word)
        {
                Random random = new Random();
                int index = random.Next(0, word.Length);
                Console.WriteLine($"The random letter of the word is {word[index]}");
        }
    }
}
