using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_CoreMovieInfo_ViewComponent.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        public IActionResult OnView()
        {
            ViewBag.movieId = this.id;
            return View();
        }

    }
}