//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITAssetManagementSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maintenance
    {
        public Maintenance()
        {
            this.Stocks = new HashSet<Stock>();
        }
    
        public int MaintenanceId { get; set; }
        public System.DateTime MaintenanceDate { get; set; }
        public byte[] MaintenanceDetails { get; set; }
        public byte[] MaintenancePerformBy { get; set; }
        public Nullable<decimal> MaintenanceCost { get; set; }
    
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
