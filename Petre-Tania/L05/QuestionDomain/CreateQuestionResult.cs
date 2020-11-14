using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestionDomain
{
    public static partial class CreateQuestionResult
    {
        public interface ICreateQuestionResult { }
        public class QuestionCreated : ICreateQuestionResult
        {
            public Guid QuestionId { get; private set; }
            public string Title { get; private set; }
            public string Description { get; private set; }
            public string Tags { get; private set; }
            public int Votes { get; private set; }

            public QuestionCreated(Guid QuestionId, string Title, string Description, string Tags)
            {
                this.QuestionId = QuestionId;
                this.Title = Title;
                this.Description = Description;
                this.Tags = Tags;
                this.Votes = Votes;
            }
        }

        public class QuestionNotCreated : ICreateQuestionResult
        {
            public string Reason { get; set; }

            public QuestionNotCreated(string reason)
            {
                Reason = reason;
            }
        }

        public class QuestionValidationFailed : ICreateQuestionResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }

    }
}