using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_2.Models.ImageModels
{
    public class Image
    {
        public int ImageID { get; set; }

        public string Name { get; set; }

        public string UrlName { get; set; }

        public string Src { get; set; }

        public string ImageExt { get; set; }

        public int Size { get; set; }

        public virtual ICollection<ImageCategory> Categories { get; set; }


        public DateTime PublishDate { get; set; }


    }
}