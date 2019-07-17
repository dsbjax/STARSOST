//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STARSOST.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemMessageDictionary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemMessageDictionary()
        {
            this.SystemEventMessaages = new HashSet<SystemEventMessaage>();
        }
    
        public int MessageNumber { get; set; }
        public string MessageTitle { get; set; }
        public string Description { get; set; }
        public string MessageType { get; set; }
        public string ResourceType { get; set; }
        public string Cause { get; set; }
        public string Effect { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemEventMessaage> SystemEventMessaages { get; set; }
    }
}