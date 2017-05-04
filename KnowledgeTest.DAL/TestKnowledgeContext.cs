using System.Data.Entity;
using KnowledgeTest.DAL.Model;
using KnowledgeTest.DAL.Model.Test;

namespace KnowledgeTest.DAL
{
    public class TestKnowledgeContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Substitution> Substitution { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
