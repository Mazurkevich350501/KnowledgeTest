using System;

namespace KnowledgeTest.BLL.Model.Test
{
    public class QuestionDescroptionModel
    {
        public QuestionDescroptionModel()
        {
            Id = Guid.NewGuid();
            Title = "Title";
            Description = "<button>asd</button>";
        }
        public Guid Id { get; }
        public string Title { get; }
        public string Description { get; }
    }
}
