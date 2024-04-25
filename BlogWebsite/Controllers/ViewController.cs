using BlogWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Models;
namespace BlogWebsite.Controllers
{
    public class ViewController : Controller
    {
        private readonly BlogWebsiteContext _context;

        public ViewController (BlogWebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Console.WriteLine("This is id" + TempData["id"]);
            if (TempData["id"] != null && int.TryParse(TempData["id"].ToString(), out int userId))
            {
                
                var blogs = _context.BlogModel.Where(b => b.UserId == userId).ToList();
                foreach(var blog in blogs)
                {
                    Console.WriteLine(blog);
                }
                return View(blogs);
            }
            Console.WriteLine(TempData["id"]);
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id) 
        {
            Console.WriteLine("In delete");
            var blog = await _context.BlogModel.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            _context.BlogModel.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");
        }
        public IActionResult Detail(int id)
        {
            var blog = _context.BlogModel.FirstOrDefault(b => b.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
    }
}
