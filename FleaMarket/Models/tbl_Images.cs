//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FleaMarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Images
    {
        public int id_images { get; set; }
        public string images_name { get; set; }
        public Nullable<int> id_product { get; set; }
    
        public virtual tbl_ProductMore tbl_ProductMore { get; set; }
        public virtual tbl_Product tbl_Product { get; set; }
    }
}
