//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export
    {
        public int Emp_ID { get; set; }
        public int Client_ID { get; set; }
        public int Item_ID { get; set; }
        public Nullable<int> Export_ID { get; set; }
        public System.DateTime Export_Date { get; set; }
        public int Quantity { get; set; }
        public string Supplier_Name { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Item Item { get; set; }
    }
}
