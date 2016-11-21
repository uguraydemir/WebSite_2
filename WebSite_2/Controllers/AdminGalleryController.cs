using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_2.Models;
using WebSite_2.Models.ImageModels;



namespace WebSite_2.Controllers
{
    public class AdminGalleryController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: AdminGallery
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UploadImage()
        {
            return View();
        }
        public ActionResult UImage3()
        {
            return View();
        }


        public ActionResult UImage2()
        {
            return View();
        }

        public ActionResult UImage()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase image)
        {

            if (image != null)
            {
                var imagePath = Server.MapPath("~/Images/");

                var imageFolder = "~/Images/";
                Image img = new Image();
                UploadedImage uploaded = new UploadedImage();
                uploaded.Duplicate = true;
                var Name = Path.GetFileNameWithoutExtension(image.FileName);
                var ext = Path.GetExtension(image.FileName);
                var size = (image.ContentLength);
                var type = image.ContentType;
                var fullName = Path.GetFileName(image.FileName);
                var check = DublicateImage(Name, size);
                if (check == false)
                {


                    img.Name = Name;
                    img.PublishDate = DateTime.Now;
                    img.Size = size;
                    img.ImageExt = ext;
                    img.Src = Name + ext;
                    img.UrlName = imagePath + Name + ext;
                    
                    var save = Path.Combine(imagePath, Name + ext);
                    image.SaveAs(save);
                    


                    db.Images.Add(img);
                    db.SaveChanges();
                    uploaded.Name = Name;
                    uploaded.Src = Name + ext;
                    uploaded.Duplicate = false;
                    uploaded.ext = ext;

                }
                
                return Json(uploaded, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("UploadImage");
            }
        }


        public bool DublicateImage(string name, int size)
        {
            var result = false;
            var check = db.Images.FirstOrDefault(model => model.Name == name && model.Size == size);
            if (check != null)
            {
                result = true;
            }


            return result;
        }



        public PartialViewResult PartialGallery()
        {
            var list = db.Images.ToList();
            return PartialView(list);
        }

    }
}