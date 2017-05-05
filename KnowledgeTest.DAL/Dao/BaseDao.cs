using System.Data.Entity;

namespace KnowledgeTest.DAL.Dao
{
    public class BaseDao
    {
        protected readonly DbContext Context;
        public BaseDao(DbContext context)
        {
            Context = context;
        }
    }
}
