using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.Models
{
    [Serializable]
    public class CartItem
    {
        public PRODUCT product { set; get; }
        public int quanlity { set; get; }
    }
}