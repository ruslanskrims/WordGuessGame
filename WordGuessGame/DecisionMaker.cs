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
            Console.WriteLine(a);
            if (a == word)
            {
                Console.WriteLine("Word is correct!");
                var b = TopicSelection.ChooseTheTopic();
                MenuNavigator.MenuNavigate(b);
            } else { 
                Console.WriteLine("Word is not correct!");
            }
            MenuNavigator.MenuNavigate(a);
        }
        public static void TakeAHint()
        {
            Console.WriteLine("You can choose the hint");
        }
    }
}
