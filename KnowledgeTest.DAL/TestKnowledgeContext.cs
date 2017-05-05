using System.Data.Entity;
using KnowledgeTest.DAL.Model;
using KnowledgeTest.DAL.Model.Test;

namespace KnowledgeTest.DAL
{
    public class TestKnowledgeContext : DbContext
    {
        public TestKnowledgeContext() : base("DbConnection")
        { }

        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Substitution> Substitutions { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
