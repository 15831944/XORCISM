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
    
    public partial class THREATACTORINFRASTRUCTURE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THREATACTORINFRASTRUCTURE()
        {
            this.THREATACTORINFRASTRUCTUREFORTHREATACTOR = new HashSet<THREATACTORINFRASTRUCTUREFORTHREATACTOR>();
            this.THREATACTORINFRASTRUCTUREFORTHREATACTORTTP = new HashSet<THREATACTORINFRASTRUCTUREFORTHREATACTORTTP>();
        }
    
        public int ThreatActorInfrastructureID { get; set; }
        public string AttackerInfrastructureGUID { get; set; }
        public string AttackerInfrastructureName { get; set; }
        public string AttackerInfrastructureDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public System.DateTimeOffset timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORINFRASTRUCTUREFORTHREATACTOR> THREATACTORINFRASTRUCTUREFORTHREATACTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORINFRASTRUCTUREFORTHREATACTORTTP> THREATACTORINFRASTRUCTUREFORTHREATACTORTTP { get; set; }
    }
}