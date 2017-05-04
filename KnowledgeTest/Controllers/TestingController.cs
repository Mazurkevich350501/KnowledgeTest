using System.Web.Mvc;

namespace KnowledgeTest.Controllers
{
    public class TestingController : Controller
    {
        [HttpGet]
        public ActionResult Start()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CalculateResult()
        {
            return View();
        }
    }
}