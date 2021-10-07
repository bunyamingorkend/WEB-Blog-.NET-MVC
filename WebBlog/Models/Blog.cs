using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Icerik { get; set; }
        public string ResimAlani { get; set; }
        public bool Onay { get; set; }
        public bool AnaSayfa{ get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int CategoriId { get; set; }
        public Categori Categori { get; set; }

    }
}