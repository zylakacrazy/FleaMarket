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
    
    public partial class tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Product()
        {
            this.tbl_Images = new HashSet<tbl_Images>();
        }
    
        public int id_product { get; set; }
        public Nullable<int> id_manufacturer { get; set; }
        public Nullable<int> id_color { get; set; }
        public Nullable<double> product_capacity { get; set; }
        public Nullable<int> product_status { get; set; }
        public Nullable<decimal> product_price { get; set; }
        public string product_title { get; set; }
        public string product_details { get; set; }
        public Nullable<int> id_cpu { get; set; }
        public string product_gpu { get; set; }
        public Nullable<int> product_ram { get; set; }
        public Nullable<int> id_screensize { get; set; }
        public string product_version { get; set; }
        public string product_disk { get; set; }
        public string graphics_screen { get; set; }
        public string product_insurance { get; set; }
        public Nullable<int> id_device { get; set; }
        public Nullable<int> id_account { get; set; }
        public Nullable<int> id_shop { get; set; }
        public string product_images { get; set; }
    
        public virtual tbl_Account tbl_Account { get; set; }
        public virtual tbl_Color tbl_Color { get; set; }
        public virtual tbl_CPU tbl_CPU { get; set; }
        public virtual tbl_Device tbl_Device { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Images> tbl_Images { get; set; }
        public virtual tbl_Manufacturer tbl_Manufacturer { get; set; }
        public virtual tbl_Screensize tbl_Screensize { get; set; }
        public virtual tbl_Shop tbl_Shop { get; set; }
    }
}
