using System;
using System.Linq;
namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = TopicSelection.ChooseTheTopic();
            Console.WriteLine(a);
            MenuNavigator.MenuNavigate(a);
            
            /*
            QuestionGenerator.GenerateRandomQuestions();
            */
        }
    }
}