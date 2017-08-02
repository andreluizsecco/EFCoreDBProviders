using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDBProviders.Context;
using EFCoreDBProviders.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDBProviders.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
