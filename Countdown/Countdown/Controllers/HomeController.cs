using System.Web.Mvc;
using CountdownService.Controllers;

namespace Countdown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var movieList = new MovieInfoController().Get();
            return View(movieList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}