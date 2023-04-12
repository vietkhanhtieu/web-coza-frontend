using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class ShoppingCartController : Controller
    {
        
        private const string cartSesstion = "cartSesstion";
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = Session[cartSesstion];
            var list = new List<CartItem>();
            if(cart != null)
            {
                list= (List<CartItem>)cart;
            }
            return View(list);
        }

       // public ActionResult AddItem(int productId, int quanlity)
        //{
            //var cart = Session[cartSesstion];
            //if(cart!= null)
            //{
            //    var list = (List<CartItem>)cart;
            //   if(list.Exists(m => m.product.ID == productId))
            //    {
            //        foreach(var item in list)
            //        {
            //            if(item.product.ID == productId)
            //            {
            //                item.quanlity += quanlity;
                            
            //            }
            //        }
            //    }
            //    else
            //    {
            //        var item = new CartItem();
            //        item.product.ID = productId;
            //        item.quanlity = productId;
            //        list.Add(item);
            //    }
            //    Session[cartSesstion] = list;
            //}
            //else
            //{
            //    var item = new CartItem();
            //    item.product.ID = productId;
            //    item.quanlity = quanlity;
            //    var list = new List<CartItem>();
            //    list.Add(item);


            //    // gan vao sesstion
            //    Session[cartSesstion] = list;
            //}
            //return RedirectToAction("Index");
       // }
    }
}