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
    
    public partial class RadarSummaryReport
    {
        public int ReportID { get; set; }
        public string Radar { get; set; }
        public int ReportMessages { get; set; }
        public int Seconds { get; set; }
        public int Scans { get; set; }
        public int RadarOnly { get; set; }
        public int BeaconOnly { get; set; }
        public int RadarReinforcedBeacon { get; set; }
        public int InvalidMode2 { get; set; }
        public int InvalidMode3A { get; set; }
        public int InvalidModeC { get; set; }
        public int Correlated { get; set; }
        public int Uncorrelated { get; set; }
        public int ReflectionSurpressed { get; set; }
        public int MosaicFiltered { get; set; }
        public int TotalFiltered { get; set; }
        public int GeographicFiltered { get; set; }
        public int RunLength { get; set; }
        public int Confidence { get; set; }
        public int ErrorRatesSeconds { get; set; }
        public int InterfaceAPercentage { get; set; }
        public int InterfaceBPercentage { get; set; }
        public int TargetSummaryReportReportID { get; set; }
    
        public virtual TargetSummaryReport TargetSummaryReport { get; set; }
    }
}
