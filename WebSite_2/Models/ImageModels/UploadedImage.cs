using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_2.Models.ImageModels
{
    public class UploadedImage
    {
        public string Name { get; set; }

        public string Src { get; set; }

        public string ext { get; set; }
        public bool Duplicate { get; set; }
    }
}