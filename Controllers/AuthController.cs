using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public AuthController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isAuthenticated = false;
            string displayName = model.UserName;

            try
            {
                var user = _mongoDbService.Users
                    .Find(u => u.UserName == model.UserName && u.Password == model.Password)
                    .FirstOrDefault();

                if (user != null)
                {
                    isAuthenticated = true;
                    displayName = user.UserName;
                }
            }
            catch (Exception)
            {
                // Fallback authentication
                if (model.UserName == "admin" && model.Password == "admin123")
                {
                    isAuthenticated = true;
                    displayName = "admin (Fallback)";
                }
            }

            if (isAuthenticated)
            {
                HttpContext.Session.SetString("UserID", model.UserName);
                HttpContext.Session.SetString("UserName", displayName);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid Username or Password.");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
