using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobSearch.Models;

namespace JobSearch.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
