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
    
    public partial class tbl_CPU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CPU()
        {
            this.tbl_Product = new HashSet<tbl_Product>();
        }
    
        public int id_cpu { get; set; }
        public string cpu_name { get; set; }
        public string cpu_manuf { get; set; }
        public string cpu_namemanuf { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Product> tbl_Product { get; set; }
    }
}
