using BlogWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BlogWebsiteContext _context;

        public DashboardController(BlogWebsiteContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
