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
    
    public partial class Resturent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resturent()
        {
            this.Parsels = new HashSet<Parsel>();
        }
    
        public int Id { get; set; }
        public string RName { get; set; }
        public string Address { get; set; }
        public int LId { get; set; }
    
        public virtual LoginInfo LoginInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parsel> Parsels { get; set; }
    }
}