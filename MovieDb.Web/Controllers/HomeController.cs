using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieDb.Business;
using MovieDb.Web.Models;

namespace MovieDb.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieBusiness movieBusiness;

        public HomeController(MovieBusiness movieBusiness)
        {
            this.movieBusiness = movieBusiness;
        }
        public async Task<IActionResult> Index()
        {   
            var movies = await movieBusiness.GetPopularMovies(1);
            return View(movies);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
