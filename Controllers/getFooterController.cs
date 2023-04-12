using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class getFooterController : Controller
    {

        coza_storeEntities7 db = new coza_storeEntities7();

        // GET: getFooter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getFooterF()
        {
            var v = from t in db.CATEGORies
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }

        public ActionResult getContactF()
        {
            var v = from t in db.CONTACTs
                    where t.HIDE == true
                    orderby t.ORDER ascending
                    select t;
            return PartialView(v.ToList());
        }







    }
}