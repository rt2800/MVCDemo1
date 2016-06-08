using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> allMovies = new List<Movie>()
        {
            new    Movie(){Id=1, Title="Angry Birds",Rating=4, ImageUrl="http://placehold.it/140x100"},
            new    Movie(){Id=2, Title="Kunfu Panda 3",Rating=4, ImageUrl="http://placehold.it/140x100"},
            new    Movie(){Id=3, Title="Zootopia",Rating=4, ImageUrl="http://placehold.it/140x100"},
        };
        // GET: Movies
        public ActionResult Index()
        {
            //Pass Small amount Data from Action to View
            ViewBag.Message = "Welcome Sameera!";
            return View(allMovies);
            //1. View(); Empty Model to View Index
            //2. View(obj); Model to View Index
            //3. View("XYZ",obj); Obj to View Name XYZ
        }

        public ActionResult Details(int id)
        {
            var movie = allMovies.Find(m => m.Id==id);
            return View("NewDetails",movie);//Name of View is same as name of Action
        }

        public ActionResult NewDetails(int id)
        {
            var movie = allMovies.Find(m => m.Id == id);
            return View(movie);//Name of View is same as name of Action
        }

        public ActionResult NewDetailsAsync(int id)
        {
            var movie = allMovies.Find(m => m.Id == id);
            return PartialView("_MoviePartial",movie);//Name of View is same as name of Action
        }

    }
}