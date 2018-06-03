using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.SqlClient;

namespace wetubeAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var testClass = new UserController();
            testClass.PostNewUser();
            return View();
        }
    }
}
