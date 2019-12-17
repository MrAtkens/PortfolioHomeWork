using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAspNetCore.Models;
using PortfolioAspNetCore.Services;
using PortfolioAspNetCore.ViewModel;

namespace PortfolioAspNetCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly ExpiretisService expiretisService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AdminController(IHttpContextAccessor httpContextAccessor, ExpiretisService expiretisService)
        {
            this.expiretisService = expiretisService;
            this.httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingIn([FromForm] UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
           
            if(user.Login != "Biking")
            {
                return Conflict();
            }
           
            bool answer = BCrypt.Net.BCrypt.Verify(user.Password, "$2a$12$XsXPA6Dpg7McPrxxC1XZUej6s./axR5HJeIL8NGBW99T9z.kSJ9o."); // Nuke1042 for tests
            if (answer)
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Login) };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = false,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    RedirectUri = "/Admin/ExpiresAdmin"
                };
                await httpContextAccessor.HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("ExpiresAdmin");
            }
            return Conflict();
        }

        [Authorize]
        public async Task<ActionResult> ExpiresAdmin()
        {

            ViewBag.Expiretis = await expiretisService.GetExpiretis();
            return View();
        }

        [Authorize]
        public async Task<ActionResult> AboutAdmin()
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string path = startupPath + "/wwwroot/About.txt";
            using (StreamReader sw = new StreamReader(path, false))
            {
                ViewBag.Description = await sw.ReadToEndAsync();
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> CreateExpiretis([FromBody]ExpiretisViewModel expiretisVM)
        {
            Expiretis expiretis = await expiretisService.AddExpiretis(expiretisVM);
            if(expiretis.Article == "")
            {
                return Conflict();
            }
            return Json(expiretis);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> DeleteExpiretis([FromBody]ExpiretisIdVM expiretisId)
        {
            Expiretis expiretis = await expiretisService.DeleteExpiretis(expiretisId.Id);
            if (expiretis.Article == "")
            {
                return Conflict();
            }
            return Json(expiretis);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> EditExpiretis([FromBody]Expiretis expiretisEdit)
        {
            Expiretis expiretis = await expiretisService.ExpiretisEdit(expiretisEdit);
            if (expiretis.Article == "")
            {
                return Conflict();
            }
            return Json(expiretis);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> EditAbout([FromForm]AboutViewModel aboutViewModel)
        {
            try
            {
                string startupPath = System.IO.Directory.GetCurrentDirectory();
                string path = startupPath + "/wwwroot/About.txt";
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    await sw.WriteLineAsync(aboutViewModel.Description);
                }
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                return Conflict();
            }
        }

    }
}