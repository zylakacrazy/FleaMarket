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
    
    public partial class tbl_Messages
    {
        public int id_messages { get; set; }
        public Nullable<int> id_channel { get; set; }
        public string messages { get; set; }
        public Nullable<System.DateTime> messages_time { get; set; }
    
        public virtual tbl_Channel tbl_Channel { get; set; }
    }
}