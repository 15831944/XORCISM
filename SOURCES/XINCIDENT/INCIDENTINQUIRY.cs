//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XINCIDENTModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class INCIDENTINQUIRY
    {
        public int IncidentIQID { get; set; }
        public Nullable<int> IncidentInquiryIntentID { get; set; }
        public string purpose { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public string format { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public string lang { get; set; }
        public string restriction { get; set; }
        public string IODEFversion { get; set; }
        public string formatid { get; set; }
    }
}