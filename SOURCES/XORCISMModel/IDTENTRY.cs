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
    
    public partial class IDTENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IDTENTRY()
        {
            this.IDTENTRYLISTENTRIES = new HashSet<IDTENTRYLISTENTRIES>();
        }
    
        public int IDTEntryID { get; set; }
        public string Type_Attr { get; set; }
        public string Offset_High { get; set; }
        public string Offset_Low { get; set; }
        public string Offset_Middle { get; set; }
        public string Selector { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<int> CollectionToolID { get; set; }
    
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual TOOL TOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IDTENTRYLISTENTRIES> IDTENTRYLISTENTRIES { get; set; }
    }
}