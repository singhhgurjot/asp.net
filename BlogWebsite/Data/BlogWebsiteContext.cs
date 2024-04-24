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
        public DbSet<BlogModel> BlogModel { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogModel>()
                .HasOne(b => b.User)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.UserId);
        }
    }
}
