using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class ABOUTController : Controller
    {
        coza_storeEntities7 db = new coza_storeEntities7();
        // GET: ABOUT
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getAbout()
        {
            var v = from t in db.ABOUTs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
   
}