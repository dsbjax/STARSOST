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
    
    public partial class TargetSummaryReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TargetSummaryReport()
        {
            this.RadarSummaryReports = new HashSet<RadarSummaryReport>();
        }
    
        public int ReportID { get; set; }
        public string Filename { get; set; }
        public System.DateTime ImportTimestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadarSummaryReport> RadarSummaryReports { get; set; }
    }
}