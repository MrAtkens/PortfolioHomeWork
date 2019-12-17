using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioAspNetCore.Models;
using PortfolioAspNetCore.Services;

namespace PortfolioAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExpiretisService expiretisService;

        public HomeController(ILogger<HomeController> logger, ExpiretisService expiretisService)
        {
            this.expiretisService = expiretisService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Expiretis> expiretis = await expiretisService.GetExpiretis();
            ViewBag.Expiretis = expiretis;
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string path = startupPath + "/wwwroot/About.txt";
            using (StreamReader sw = new StreamReader(path, false))
            {
                ViewBag.Description = await sw.ReadToEndAsync();
            }
            return View();
        }
    }
}
