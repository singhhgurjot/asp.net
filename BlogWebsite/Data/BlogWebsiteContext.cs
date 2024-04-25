using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Models;

namespace BlogWebsite.Data
{
    public class BlogWebsiteContext : DbContext
    {
        public BlogWebsiteContext (DbContextOptions<BlogWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWebsite.Models.RegisterModel> RegisterModel { get; set; } = default!;
        public DbSet<BlogWebsite.Models.BlogModel> BlogModel { get; set; } = default!;
       
    }
}
