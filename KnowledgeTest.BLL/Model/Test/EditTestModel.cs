using System;
using System.Collections.Generic;

namespace KnowledgeTest.BLL.Model.Test
{
    public class EditTestModel
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<QuestionDescroptionModel> Qustions { get; }
        public TestSettingsModel Settings { get; set; }
    }
}
