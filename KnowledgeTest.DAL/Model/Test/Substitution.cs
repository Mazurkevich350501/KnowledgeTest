using System;

namespace KnowledgeTest.DAL.Model.Test
{
    public class Substitution
    {
        public Guid SubstitutionId { get; set; }
        public Guid TestId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }
}
