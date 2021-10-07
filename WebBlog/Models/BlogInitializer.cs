using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Categori> kategoriler = new List<Categori>()
            {
                new Categori(){KategoriAdi="Birinci Kategori"},
                new Categori(){KategoriAdi="İki Kategori"},
                new Categori(){KategoriAdi="üçinci Kategori"},
                new Categori(){KategoriAdi="Dörtrinci Kategori"},
                new Categori(){KategoriAdi="Beşinci Kategori"},
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik = "aaa", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=1},
                new Blog(){Baslik = "ga", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=1},
                new Blog(){Baslik = "af", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=1},
                new Blog(){Baslik = "fa", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=1},
                new Blog(){Baslik = "ac", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=2},
                new Blog(){Baslik = "as", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=2},
                new Blog(){Baslik = "sadaa", Aciklama="f",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=2},
                new Blog(){Baslik = "az", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=3},
                new Blog(){Baslik = "za", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=3},
                new Blog(){Baslik = "an", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=3},
                new Blog(){Baslik = "nsasaa", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=4},
                new Blog(){Baslik = "ma", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=4},
                new Blog(){Baslik = "ka", Aciklama="b",Icerik = "c",Onay = true,EklenmeTarihi = DateTime.Now,AnaSayfa = true,ResimAlani="1.jpg",CategoriId=4},
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}