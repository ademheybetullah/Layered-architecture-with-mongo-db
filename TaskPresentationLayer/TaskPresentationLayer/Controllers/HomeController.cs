using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;

namespace TaskPresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        LinkBusiness linkBusiness = new LinkBusiness();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {

            List<NewLink> gelenLink = linkBusiness.GetLink("Android");
            return View(gelenLink);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}