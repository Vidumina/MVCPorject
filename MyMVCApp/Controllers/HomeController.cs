using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            ViewData["Countries"]= new  List<string>(){ 
            "India",
                    "US",
                    "Sri Lanka",
                    "USA",
                    "Canada"
            
            };

            return View();
        }

        public String GetDetails()
        {
            //return View();
            return "Get Details Invorked";
        }

        //public ActionResult Index()
        //{
        //    return View();

        //}
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}