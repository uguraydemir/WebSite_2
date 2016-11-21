using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_2.Models.CategoryModels
{
    public class ArticleCategory
    {
        public int ArticleCategoryID { get; set; }

        public string CatName { get; set; }

        public virtual ICollection<ArticleModels.ArticleModel> ArticlesCategory{ get; set; }

    }
}