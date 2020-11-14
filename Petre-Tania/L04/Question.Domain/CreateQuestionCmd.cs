using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    public struct CreateQuestionCmd
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Tags { get; private set; }

        public CreateQuestionCmd(string Title, string Description, string Tags)
        {
            this.Title = Title;
            this.Description = Description;
            this.Tags = Tags;
        }
    }
}