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
    
    public partial class tbl_Coin
    {
        public int id_coin { get; set; }
        public Nullable<decimal> coin_total { get; set; }
        public Nullable<System.DateTime> coin_date { get; set; }
        public string coin_details { get; set; }
        public Nullable<int> id_account { get; set; }
    
        public virtual tbl_Account tbl_Account { get; set; }
    }
}