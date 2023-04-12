using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class BLOGController : Controller
    {
        coza_storeEntities7 db = new coza_storeEntities7();
        // GET: BLOG
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult getBlog()
        {
            ViewBag.meta = "Blog";
            var v = from t in db.BLOGs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult detailBLOG(string name)
        {
            var v = from t in db.BLOGs
                    where t.NAME == name
                    select t;
            return View(v.ToList());
        }
    }
}