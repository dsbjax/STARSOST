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
    
    public partial class SystemEventMessaage
    {
        public int EventID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Source { get; set; }
        public string MessageType { get; set; }
        public int MessageNumber { get; set; }
        public string Message { get; set; }
    
        public virtual SystemMessageDictionary SystemMessageDictionary { get; set; }
    }
}
