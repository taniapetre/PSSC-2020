using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.Question;

namespace QuestionDomain
{
    public class VerifyQuestionService
    {
        public Result<VerifiedQuestion> VerifiedQuestion(UnverifiedQuestion question)
        {
            
            return new VerifiedQuestion(question);
        }
    }
}