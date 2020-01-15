using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETİCARET.UI.Areas.Admin.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Admin/Urunler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            return View("Urunler");
        }
    }
}