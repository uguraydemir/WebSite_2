using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite_2.Models.AuthorModels;

namespace WebSite_2.Models.ArticleModels
{
    public class ArticleModel
    {

        public int ArticleModelID { get; set; }

        public string Tittle { get; set; }
         
        public string Content { get; set; }

        public virtual Author Author { get; set; }

        public string Summary { get; set; }


        //public string MainImage { get; set; }


        public virtual ICollection<CategoryModels.ArticleCategory> Category { get; set; }


    }
}