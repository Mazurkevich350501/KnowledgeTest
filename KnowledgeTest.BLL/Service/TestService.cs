using System;
using System.Collections;
using System.Collections.Generic;
using KnowledgeTest.BLL.Interface;
using KnowledgeTest.BLL.Model.Test;
using KnowledgeTest.Controllers;
using KnowledgeTest.DAL.Model.Test;

namespace KnowledgeTest.BLL.Service
{
    public class TestService : ITestService
    {
        public EditTestModel Get(Guid? id)
        {
            return id != null
                ? new EditTestModel()
                : new EditTestModel();
        }

        public void Save(EditTestModel model)
        {
            throw new NotImplementedException();
        }

        public void Save(EditQuestionModel model)
        {
            throw new NotImplementedException();
        }

        public EditQuestionModel GetQuestion(Guid id)
        {
            return new EditQuestionModel();
        }

        public QuestionsModel GetQuestions(Guid testId)
        {
            return new QuestionsModel();
        }
    }
}
