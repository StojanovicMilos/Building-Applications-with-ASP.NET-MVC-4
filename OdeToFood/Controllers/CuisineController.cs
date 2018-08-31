using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);

            return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        }
    }
}