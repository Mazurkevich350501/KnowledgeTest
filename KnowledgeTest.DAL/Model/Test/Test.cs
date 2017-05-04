using System;
using System.Collections.Generic;

namespace KnowledgeTest.DAL.Model.Test
{
    public class Test
    {
        public Guid TestId { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public TimeSpan? TestTime { get; set; }
        public int MinQuestionsCount { get; set; }
    }
}
