using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class getMenuController : Controller
    {

        coza_storeEntities7 db = new coza_storeEntities7();
        // GET: getMenu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getMeNu()
        {
            var v = from t in db.MENUs
                    where t.HIDE == true    
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }

    }
}