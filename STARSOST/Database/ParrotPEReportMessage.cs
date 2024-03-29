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
    
    public partial class ParrotPEReportMessage
    {
        public int MessageID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Radar { get; set; }
        public string Target { get; set; }
        public short Count { get; set; }
        public short AdaptedRange { get; set; }
        public short MeanRange { get; set; }
        public short StdDevRange { get; set; }
        public short AdaptedAzimuth { get; set; }
        public short MeanAzimuth { get; set; }
        public short StdDevAzimuth { get; set; }
        public short Reliability { get; set; }
        public bool Enabled { get; set; }
        public int ParrotPEReportReportID { get; set; }
    
        public virtual ParrotPEReport ParrotPEReport { get; set; }
    }
}
