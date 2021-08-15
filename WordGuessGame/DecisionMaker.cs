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
            Console.WriteLine(result);
            MenuNavigator.MenuNavigate(a);
        }
    }
}
