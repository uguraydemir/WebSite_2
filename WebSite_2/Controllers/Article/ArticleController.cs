using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_2.Models;

namespace WebSite_2.Controllers.Article
{
    public class ArticleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllArticles()
        {

            var ArticleList = db.Articles.ToList();
            return View(ArticleList);
        }
    }
}