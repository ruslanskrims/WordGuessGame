using System;
using System.Collections.Generic;
using System.Text;

namespace WordGuessGame
{
    public class Exit
    {
        public static void ExitTheGameInstantly()
        {
            Console.WriteLine("You have exited the game");
        }
        public static void ExitTheGameByPressingEscKey()
        {
            ConsoleKeyInfo cki;
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
