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
            var choosenTopic = TopicSelection.ChooseTheTopic();
            MenuNavigator.MenuNavigate(choosenTopic, true);
        }
    }
}