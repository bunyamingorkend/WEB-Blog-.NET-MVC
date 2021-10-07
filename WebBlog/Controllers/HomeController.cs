using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            var bloglar = context.Bloglar
                .Select(i => new BlogModel()
                {
                    Id = i.Id,
                    Baslik = i.Baslik.Length > 2 ? i.Baslik.Substring(0, 2) + "..." : i.Baslik,
                    Aciklama=i.Aciklama,
                    EklenmeTarihi=i.EklenmeTarihi,
                     AnaSayfa =i.AnaSayfa,
                      Onay=i.Onay,
                       ResimAlani=i.ResimAlani

                })
                .Where(i => i.AnaSayfa == true && i.Onay==true);
            return View(bloglar.ToList());
        }
    }
}