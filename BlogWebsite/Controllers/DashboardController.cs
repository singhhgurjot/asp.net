using BlogWebsite.Data;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Write([Bind("Id,Title,Content,UserId")] BlogModel blogModel)
        {
            if (ModelState.IsValid)
            {   
                _context.Add(blogModel);
                await _context.SaveChangesAsync();
                TempData["message"] = "Blog Created Successfully";
        
                return RedirectToAction("Index","View");
            }
            Console.WriteLine("Something Went Wrong");
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    var errorMessage = error.ErrorMessage;
                    Console.WriteLine(errorMessage);
                    // Log or display the error message
                }
            }
            return View(blogModel);

        }
    }
}
