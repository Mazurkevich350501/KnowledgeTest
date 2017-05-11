using System.Collections.Generic;

namespace KnowledgeTest.BLL.Model.Test
{
    public class QuestionsModel
    {
        public QuestionsModel()
        {
            TestName = "test#1";
            Questions = new List<QuestionDescroptionModel>
            {
                new QuestionDescroptionModel(),
                new QuestionDescroptionModel()
            };
        }

        public string TestName { get; }
        public ICollection<QuestionDescroptionModel> Questions { get; }
    }
}
