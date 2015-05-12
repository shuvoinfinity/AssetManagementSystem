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
    
    public partial class AssetAssign
    {
        public int AssetAssingId { get; set; }
        public int UserId { get; set; }
        public int StockId { get; set; }
        public System.DateTime AssignDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string ConditionOut { get; set; }
        public string ConditionReturn { get; set; }
        public byte[] Remarks { get; set; }
    
        public virtual Stock Stock { get; set; }
        public virtual User User { get; set; }
    }
}