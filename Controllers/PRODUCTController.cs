using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class PRODUCTController : Controller
    {
        coza_storeEntities7 db = new coza_storeEntities7();
        // GET: PRODUCT
        public ActionResult Index()
        {
            return View();
        }

    

        public ActionResult detail(string name)
        {

            ViewBag.meta = "them-gio-hang";
            var v = from t in db.PRODUCTs
                    where t.NAME == name
                    select t;
            return View(v.FirstOrDefault());
        }
    }
}