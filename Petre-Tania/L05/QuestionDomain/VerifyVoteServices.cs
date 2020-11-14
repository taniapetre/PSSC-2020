using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.Votes;

namespace QuestionDomain
{
    public class VerifyVotesService
    {
        public Result<VerifiedVotes> VerifyVotes(UnverifiedVotes votes)
        {
            return new VerifiedVotes(votes);
        }
    }
}