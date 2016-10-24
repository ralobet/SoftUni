using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCBlog.Models;

namespace MVCBlog.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.Include(p => p.Author)
                .OrderByDescending(p => p.Date).Take(3);
            
            var SidebarPosts = db.Posts.Include(p => p.Author)
                .OrderByDescending(p => p.Date).Take(5);
            ViewBag.SidebarPosts = SidebarPosts;
            return View(posts.ToList());
        }
    }
}