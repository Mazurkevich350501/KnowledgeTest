using System;
using System.Collections.Generic;

namespace KnowledgeTest.Controllers
{
    public class EditQuestionModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Dictionary<string, Dictionary<int, string>> QusertionSubstitutions { get; set; }
        public Dictionary<string, Dictionary<int, ICollection<string>>> AnswerSubstitutions { get; set; }
        public Dictionary<string, bool> Answers { get; set; }
    }
}