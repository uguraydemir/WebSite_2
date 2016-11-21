using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_2.Models.AuthorModels
{
    public class Author
    {
        public int AuthorID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public string BornPlace { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual ICollection<ArticleModels.ArticleModel> Articles{ get; set; }
    }


    
}