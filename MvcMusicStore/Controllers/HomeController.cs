using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        
        /*public ActionResult Search(string q)
        {
            var album = storeDB.Albums
                                .Include("Artist")
                                .Where(album => a.Title.Contains(q))
                                .Take(10);
            return View(albums);
        }*/
    }
}