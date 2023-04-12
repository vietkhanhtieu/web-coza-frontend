using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class CONTACTController : Controller
    {
        coza_storeEntities7 db = new coza_storeEntities7();

        // GET: CONTACT
        public ActionResult Index()
        {

            var v = from t in db.CONTACTs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return View(v.ToList());
        }

        //public ActionResult getContactC()
        //{
        //    var v = from t in db.CONTACTs
        //            where t.HIDE == true
        //            orderby t.ORDER ascending
        //            select t;
        //    return PartialView(v.SingleOrDefault());
        //}
    }
}