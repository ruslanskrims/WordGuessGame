using System;
using System.Collections.Generic;
using System.Linq;

namespace WordGuessGame
{
    class TopicSelection
    {
        public static string ChooseTheTopic()
        {
            int chosenTopic;
            var Topics = new Dictionary<int, string>();
            Topics.Add(1, "Programming");
            Topics.Add(2, "Space");
            Topics.Add(3, "Exit the game");
            Console.WriteLine("What topic you would like to choose?");
            foreach(var item in Topics)
            {
                Console.WriteLine($"{item.Key}) {item.Value}");
            }

            chosenTopic = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int randomID = rand.Next(1, Collections.programmingList.Count + 1);

            var filteredResult = from element in Collections.programmingList
                                 where element.QuestionId == randomID
                                 select element.QuestionAnswer;

            switch (chosenTopic)
            {
                case 1:
                    foreach (var element in Collections.programmingList)
                    {
                        if (element.QuestionId == randomID)
                        {

                            Console.WriteLine(element.QuestionMessage);
                            return element.QuestionAnswer;
                        }
                    }
                    break;
                case 2:
                    foreach (var element in Collections.sovietSpaceList)
                    {
                        if (element.QuestionId == randomID)
                        {
                            Console.WriteLine(element.QuestionMessage);
                            return element.QuestionAnswer;
                        }
                    }
                    break;
                case 3:
                    Exit.ExitTheGameInstantly();
                    break;
                default:
                    return "";
            }
            return "";
        }
    }
}
