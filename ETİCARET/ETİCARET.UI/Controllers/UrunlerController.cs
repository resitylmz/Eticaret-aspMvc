using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETİCARET.UI.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        public ActionResult Index()
        {
            return View("Urunler");
        }
        public ActionResult UrunDetay()
        {
            return View("UrunDetay");
        }
    }
}