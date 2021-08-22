using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace WordGuessGame
{
    class Collections
    {
        public static IList<Question> programmingList = new List<Question>
            {
              new Question { QuestionId = 1, QuestionAnswer = "javascript", QuestionMessage = "Which programming language was developed by Brendan Eich, but was renamed in 1995?"},
              new Question { QuestionId = 2, QuestionAnswer = "inheritance", QuestionMessage = "In object-oriented programming, it refers to the ability of an object to take on one or more characteristics from other classes of objects"},
              new Question { QuestionId = 3, QuestionAnswer = "library", QuestionMessage ="It is a collection of files, programs, routines, scripts, or functions that can be referenced in the programming code"}
        };
        public static IList<Question> sovietSpaceList = new List<Question>
            {
               new Question { QuestionId = 1, QuestionAnswer = "gagarin", QuestionMessage = "Surname of the person, who was the first human that made a journey into outer space"},
               new Question { QuestionId = 2, QuestionAnswer = "korolyov", QuestionMessage = "Surname of the person, who made first successful launch of the first Soviet ballistic missile GIDR-10"},
               new Question { QuestionId = 3, QuestionAnswer = "strelka", QuestionMessage ="Name of the first dog that came back to Earth from the space by soviet space programm in 1960"}
        };
    }
}
