using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WiscoIpsum.Models;
using WiscoIpsum.Services;

namespace WiscoIpsum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new IpsumViewModel());
        }

        [HttpPost]
        public IActionResult Index(IpsumViewModel model)
        {
            model.IpsumText = IpsumGenerator.GenerateIpsum(model.Paragraphs);
            return View(model);
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
