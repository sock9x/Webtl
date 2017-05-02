using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanNhacContext;
namespace webamnhac.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Casi a = new Casi();
            
            return View();
        }

        public ActionResult Specials()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Single(int? id)
        {
            if (id == null)
                return HttpNotFound();
          //  Song song = db.Song.SingleOrDefault(db => db.IDSong == id);
       //     if (song == null)
       //         return HttpNotFound();
            return View(1);
            
        }
        public ActionResult Artists()
        {
            return View();
        }
        public ActionResult Favorites()
        {
            return View();
        }

    }
}