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
    
    public partial class tbl_Channel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Channel()
        {
            this.tbl_Messages = new HashSet<tbl_Messages>();
        }
    
        public int id_channel { get; set; }
        public Nullable<int> sender { get; set; }
        public Nullable<int> receiver { get; set; }
    
        public virtual tbl_Account tbl_Account { get; set; }
        public virtual tbl_Account tbl_Account1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Messages> tbl_Messages { get; set; }
    }
}