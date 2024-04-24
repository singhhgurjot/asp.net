using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Data;
using BlogWebsite.Models;

namespace BlogWebsite.Controllers
{
    public class RegisterController : Controller
    {
        private readonly BlogWebsiteContext _context;

        public RegisterController(BlogWebsiteContext context)
        {
            _context = context;
        }

      
        // GET: Register/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Email,Password,ConfirmPassword")] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Login");
            }
            return View(registerModel);
        }

    }
}
