//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHungerAgnmt.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parsel
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int PreservationTime { get; set; }
        public int TotalPacket { get; set; }
        public Nullable<int> Employee { get; set; }
        public string Status { get; set; }
        public int RId { get; set; }
    
        public virtual Resturent Resturent { get; set; }
        public virtual Emplyo Emplyo { get; set; }
    }
}