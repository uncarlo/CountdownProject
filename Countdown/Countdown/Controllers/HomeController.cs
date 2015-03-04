using System;
using System.Linq;
using System.Web.Mvc;
using CountdownService.Controllers;
using CountdownService.Models;

namespace Countdown.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var movieList = new MovieInfoController().Get();
            movieList = movieList.OrderBy(x => x.Phase).ThenBy(x => x.ReleaseDate);
            return View(movieList);
        }

        [Route("Home/Details/{movieId}")]
        public ActionResult Details(int movieId)
        {
            var movie = new MovieInfoController().Get(movieId);
            return View(movie);
        }
        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Home/Create")]
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            var movie = new MovieInfo();
            movie.Name = "Iron Fist";
            movie.ReleaseDate = new DateTime(2018, 12, 15);
            return View(movie);
        }

        [Route("Home/Create")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(MovieInfo movie)
        {
            try
            {
                new MovieInfoController().Post(movie);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(movie);
            }
        }
    }
}