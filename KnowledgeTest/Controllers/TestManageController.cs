using System.Web.Mvc;

namespace KnowledgeTest.Controllers
{
    public class TestManageController : Controller
    {
        [HttpGet]
        public ActionResult Get(string guid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}