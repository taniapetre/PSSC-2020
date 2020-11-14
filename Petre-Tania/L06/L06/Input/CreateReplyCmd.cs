using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace L06.Inputs
{
    public class CreateReplyCmd
    {
        [Required]
        public String AuthorId { get; }
        [Required]
        public String QuestionId { get; }
        [Required]
        [StringRange(10, 500)]
        public String Reply { get; }

        public CreateReplyCmd(String authorId, String questionId, String reply)
        {
            AuthorId = authorId;
            QuestionId = questionId;
            Reply = reply;
        }
    }
}
