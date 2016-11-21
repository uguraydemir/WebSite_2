using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_2.Controllers.SocialMedia
{
    public class FacebookController : Controller
    {
        // GET: Facebook
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FacebookShare()
        {
            return View();
        }


    }
}