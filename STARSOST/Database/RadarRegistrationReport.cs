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
    
    public partial class RadarRegistrationReport
    {
        public int ReportID { get; set; }
        public string Radar { get; set; }
        public string TestRadar { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int CurrentSampleSize { get; set; }
        public int AdaptedSampleSize { get; set; }
        public int RecommendedRange { get; set; }
        public int DifferenceRange { get; set; }
        public int RecommendedAzimuth { get; set; }
        public int DifferenceAzimuth { get; set; }
        public int RegistrationReportReportID { get; set; }
    
        public virtual RegistrationReport RegistrationReport { get; set; }
    }
}