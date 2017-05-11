using System;
using System.Collections.Generic;
using KnowledgeTest.BLL.Model.Test;
using KnowledgeTest.Controllers;
using KnowledgeTest.DAL.Model.Test;

namespace KnowledgeTest.BLL.Interface
{
    public interface ITestService
    {
        EditTestModel Get(Guid? id);
        void Save(EditTestModel model);
        void Save(EditQuestionModel model);
        EditQuestionModel GetQuestion(Guid id);
        QuestionsModel GetQuestions(Guid testId);
    }
}
