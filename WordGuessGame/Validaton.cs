using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGuessGame
{
    class Validation
    {
        public static bool inputCheck(string input, string inputType)
        {
            switch (inputType)
            {
                case ("str"):
                    if (input.All(Char.IsLetter) && input.Length > 0)
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! you must input string");
                    break;
                case ("chr"):
                    if (input.All(Char.IsLetter) && input.Length == 1)
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! you must input character");
                    break;
                case ("int"):
                    if (input.All(Char.IsDigit) && input.Length > 0)
                    {
                        return true;
                    }
                    Console.WriteLine("Error!! You must input number");
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
