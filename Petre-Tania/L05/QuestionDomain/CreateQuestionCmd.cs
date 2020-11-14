using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuestionDomain
{
    public struct CreateQuestionCmd
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Tags { get; private set; }
        public int Votes { get; private set; }

        public bool CanVote = false;

        public CreateQuestionCmd(string Title, string Description, string Tags)
        {
            this.Title = Title;
            this.Description = Description;
            this.Tags = Tags;
            this.Votes = Votes;
        }
    }
}