using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Lab01c_HTMLl.Controllers
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
        public ActionResult Home_View()
        {

            return View();
        }
        public ActionResult Login_View()
        {

            return View();
        }
        public ActionResult Register_View()
        {

            return View();
        }
        public ActionResult Repass_View()
        {

            return View();
        }
        public ActionResult BaiTapNangCao()
        {

            return View();
        }
    }
}