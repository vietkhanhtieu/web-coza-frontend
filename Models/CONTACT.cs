//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTACT
    {
        public int ID { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string META { get; set; }
        public Nullable<bool> HIDE { get; set; }
        public Nullable<int> ORDER { get; set; }
        public Nullable<System.DateTime> DATE_BEGIN { get; set; }
        public string IMG { get; set; }
    }
}