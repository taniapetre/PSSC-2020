using System;
using System.Collections.Generic;

namespace QuestionDomain
{
    [Serializable]
    public class InvalidQuestionException : Exception
    {
        public InvalidQuestionException()
        { }

        public InvalidQuestionException(string title) : base($"The value \"{question}\" is an invalid question format.")
        { }
    }
}