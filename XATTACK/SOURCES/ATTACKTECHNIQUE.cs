//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XATTACKModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTACKTECHNIQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTACKTECHNIQUE()
        {
            this.ATTACKTECHNIQUEINDICATOR = new HashSet<ATTACKTECHNIQUEINDICATOR>();
            this.ATTACKTECHNIQUEREFERENCE = new HashSet<ATTACKTECHNIQUEREFERENCE>();
            this.ATTACKTECHNIQUETAG = new HashSet<ATTACKTECHNIQUETAG>();
            this.ATTACKTECHNIQUETOOL = new HashSet<ATTACKTECHNIQUETOOL>();
        }
    
        public int AttackTechniqueID { get; set; }
        public string AttackTechniqueGUID { get; set; }
        public Nullable<int> TechniqueID { get; set; }
        public string AttackTechniqueName { get; set; }
        public string AttackTechniqueDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTECHNIQUEINDICATOR> ATTACKTECHNIQUEINDICATOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTECHNIQUEREFERENCE> ATTACKTECHNIQUEREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTECHNIQUETAG> ATTACKTECHNIQUETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTECHNIQUETOOL> ATTACKTECHNIQUETOOL { get; set; }
    }
}