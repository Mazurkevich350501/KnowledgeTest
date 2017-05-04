using System.Web.Mvc;

namespace KnowledgeTest.Controllers
{
    public class ClassManageController : Controller
    {
        [HttpGet]
        public ActionResult GetClass(string guid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveClass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteClass()
        {
            return View();
        }
    }
}