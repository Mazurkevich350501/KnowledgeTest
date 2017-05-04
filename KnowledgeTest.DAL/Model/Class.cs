using System;
using System.Collections.Generic;

namespace KnowledgeTest.DAL.Model
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public IEnumerable<Test.Test> Tests { get; set; }
    }
}
