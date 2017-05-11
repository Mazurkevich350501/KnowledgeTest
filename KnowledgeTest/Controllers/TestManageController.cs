using System;
using System.Web.Mvc;
using KnowledgeTest.BLL.Interface;
using KnowledgeTest.BLL.Model.Test;

namespace KnowledgeTest.Controllers
{
    public class TestManageController : Controller
    {
        private readonly ITestService _testService;

        public TestManageController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public ActionResult Index(string id)
        {
            Guid guid;
            return View(Guid.TryParse(id, out guid)
                ? _testService.Get(guid)
                : _testService.Get(null));
        }

        [HttpPost]
        public ActionResult Save(EditTestModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(EditQuestionModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditQuestion(Guid id)
        {
            return View(_testService.GetQuestion(id));
        }

        [HttpGet]
        public ActionResult Questions(Guid id)
        {
            return View(_testService.GetQuestions(id));
        }

        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}