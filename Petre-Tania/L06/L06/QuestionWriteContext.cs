﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L06
{
    public class QuestionWriteContext
    {
        public ICollection<int> AuthorIds { get; }
        public ICollection<int> QuestionIds { get; }

        public QuestionWriteContext(ICollection<int> authorIds, ICollection<int> questionIds)
        {
            AuthorIds = authorIds;
            QuestionIds = questionIds;
        }
    }
}