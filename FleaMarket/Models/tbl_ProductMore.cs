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
    
    public partial class tbl_ProductMore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ProductMore()
        {
            this.tbl_Images = new HashSet<tbl_Images>();
        }
    
        public int id_productmore { get; set; }
        public Nullable<int> id_device { get; set; }
        public Nullable<int> productmore_status { get; set; }
        public string productmore_insurance { get; set; }
        public Nullable<decimal> productmore_price { get; set; }
        public string productmore_title { get; set; }
        public string productmore_details { get; set; }
        public Nullable<int> id_account { get; set; }
        public Nullable<int> id_shop { get; set; }
    
        public virtual tbl_Account tbl_Account { get; set; }
        public virtual tbl_Device tbl_Device { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Images> tbl_Images { get; set; }
        public virtual tbl_Shop tbl_Shop { get; set; }
    }
}
