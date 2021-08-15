using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuessGame
{
    class QuestionGenerator
    {
        public static void GenerateRandomQuestions()
        {
            var rand = new Random();

            AnswerCollection word1 = new AnswerCollection("tractor", "An engineering vehicle specifically designed" +
                        " to deliver a high tractive effort" +
                        " (or torque) at slow speeds, for the purposes of hauling a trailer" +
                        " or machinery such as that used in agriculture, mining or construction.");
            AnswerCollection word2 = new AnswerCollection("vampire", "A creature from folklore that subsists by feeding on the vital essence" +
                        " (generally in the form of blood) of the living.");
            AnswerCollection word3 = new AnswerCollection("computer", "A machine that can be programmed to carry out" +
                        " sequences of arithmetic or logical operations automatically.");
            var xWord = rand.Next(0, 2);
            switch (xWord)
            {
                case 0:
                    Console.WriteLine(word1.Question);
                    break;
                case 1:
                    Console.WriteLine(word2.Question);
                    break;
                case 2:
                    Console.WriteLine(word3.Question);
                    break;
                default:
                    break;
            }
        }
    }
}
