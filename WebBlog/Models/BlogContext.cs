using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("BlogDb")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Categori> Kategoriler { get; set; }
    }
}