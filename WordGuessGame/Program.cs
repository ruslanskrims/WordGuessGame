using System;
using System.Linq;
namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        public static void StartGame()
        {
            var a = TopicSelection.ChooseTheTopic();
            MenuNavigator.MenuNavigate(a);
        }
    }
}