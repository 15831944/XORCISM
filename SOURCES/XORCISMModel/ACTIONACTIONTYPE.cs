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
    
    public partial class ACTIONACTIONTYPE
    {
        public int ActionActionTypeID { get; set; }
        public int ActionID { get; set; }
        public string ActionGUID { get; set; }
        public int ActionTypeID { get; set; }
        public string ActionTypeGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ACTION ACTION { get; set; }
        public virtual ACTIONTYPE ACTIONTYPE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}