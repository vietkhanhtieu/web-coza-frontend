using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class HomeController : Controller
    {

        coza_storeEntities7 db = new coza_storeEntities7();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getBanner()
        {
            var v = from t in db.BANERs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getSlider()
        {
            var v = from t in db.SLIDERs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getProduct()
        {
            ViewBag.meta = "products";
            var v =
                    from t in db.PRODUCTs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            
            return PartialView(v.ToList());
        }






    }
}