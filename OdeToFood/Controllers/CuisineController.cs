using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpPost]
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("Search!");
        }
    }
}