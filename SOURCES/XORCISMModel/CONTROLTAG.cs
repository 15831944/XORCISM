//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTROLTAG
    {
        public int ControlTagID { get; set; }
        public Nullable<int> ControlID { get; set; }
        public string ControlGUID { get; set; }
        public Nullable<int> TagID { get; set; }
        public string TagGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual CONTROL CONTROL { get; set; }
        public virtual TAG TAG { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}