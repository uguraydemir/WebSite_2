using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_2.Models;
using WebSite_2.Models.ArticleModels;
using WebSite_2.Models.CategoryModels;
//using WebSite_2.Models.ArticleModels;




namespace WebSite_2.Controllers.AdminArticle
{
    public class EditArticleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();




        // GET: EditArticle
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateArticle()
        {
            ViewBag.CategoryList = db.ArticleCategory.ToList();
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CreateArticle(ArticleModel article, List<string> CatName)
        {

            List<ArticleCategory> CategoryList = new List<ArticleCategory>();

            foreach (var cat in CatName)
            {
                var catId = Convert.ToInt32(cat);
                var findCat = db.ArticleCategory.FirstOrDefault(u=>u.ArticleCategoryID == catId);
                CategoryList.Add(findCat);
            }



            ArticleModel art = new ArticleModel();
            art.Author = article.Author;
            //art.Category = findCat;
            art.Category = CategoryList;
            art.Content = article.Content;
            art.Tittle = article.Tittle;
            db.Articles.Add(art);
            db.SaveChanges();
             
            return RedirectToAction("CreateArticle");
        }





    }
}