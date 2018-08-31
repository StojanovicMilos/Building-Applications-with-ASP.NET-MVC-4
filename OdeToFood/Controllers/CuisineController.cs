using System.Web.Mvc;
using System;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something terrble has happened!");
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}