using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notenverwaltung.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
/*            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction(nameof(UserController.index), "Users");
                }
                if (User.IsInRole("Student"))
                {
                    return RedirectToRoute("Grades/getStudent?" + User.Identity.Name);
                }
            }
            else
            {
                return RedirectToRoute("Access/Login");
            }*/

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
