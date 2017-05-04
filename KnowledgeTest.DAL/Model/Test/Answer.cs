using System;

namespace KnowledgeTest.DAL.Model.Test
{
    public class Answer
    {
        public Guid AnswerId { get; set; }
        public Guid? SubstitutionId { get; set; }
        public Guid TestId { get; set; }
        public virtual Substitution Substitution { get; set; }
        public string Body { get; set; }
    }
}
