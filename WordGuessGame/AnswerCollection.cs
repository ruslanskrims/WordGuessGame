using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordGuessGame
{
    class AnswerCollection
    {
        public string Word;
        public string Question;
        /*IList answerList = new List<object[]>();*/
        public AnswerCollection(string word, string question)
        {
            this.Word = word;
            this.Question = question;
        }
    }
}
