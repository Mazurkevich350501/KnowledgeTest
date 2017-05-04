using System;

namespace KnowledgeTest.DAL.Model
{
    public class Result
    {
        public Guid ResultId { get; set; }
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }
        public DateTime Date { get; set; }
        public int Points { get; set; }
    }
}
