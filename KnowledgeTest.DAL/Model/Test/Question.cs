using System;
using System.Collections.Generic;

namespace KnowledgeTest.DAL.Model.Test
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<Substitution> Substitution { get; set; }
    }
}
