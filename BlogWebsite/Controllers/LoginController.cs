using BlogWebsite.Data;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class LoginController : Controller
    {
        private readonly BlogWebsiteContext _context;

        public LoginController(BlogWebsiteContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = _context.RegisterModel.SingleOrDefault(u => u.Username == loginModel.Username && u.Password == loginModel.Password);
                if (user != null)
                {
                    // User found, redirect to home or dashboard
                
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // User not found, add error message and return to login page
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View(loginModel);
                }
            }
            return View(loginModel);
        }
    }
}
