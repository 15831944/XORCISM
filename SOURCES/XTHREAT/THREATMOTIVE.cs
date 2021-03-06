//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTHREATModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class THREATMOTIVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THREATMOTIVE()
        {
            this.THREATMOTIVEFORTHREATACTOR = new HashSet<THREATMOTIVEFORTHREATACTOR>();
        }
    
        public int ThreatMotiveID { get; set; }
        public string ThreatMotiveGUID { get; set; }
        public string motive { get; set; }
        public string motiveDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntildate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATMOTIVEFORTHREATACTOR> THREATMOTIVEFORTHREATACTOR { get; set; }
    }
}
