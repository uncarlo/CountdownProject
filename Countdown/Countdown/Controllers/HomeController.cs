using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CountdownService;

namespace Countdown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var movieList = new CountdownService.Controllers.MovieInfoController().Get();
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