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
    
    public partial class MEASURESOURCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEASURESOURCE()
        {
            this.CODE = new HashSet<CODE>();
            this.COLLECTIONMETHOD = new HashSet<COLLECTIONMETHOD>();
            this.DISCOVERYMETHOD = new HashSet<DISCOVERYMETHOD>();
            this.MEASURESOURCECONTRIBUTOR = new HashSet<MEASURESOURCECONTRIBUTOR>();
            this.MEASURESOURCETOOL = new HashSet<MEASURESOURCETOOL>();
            this.MEASURESOURCETOOLTYPE = new HashSet<MEASURESOURCETOOLTYPE>();
            this.OBSERVATIONMETHOD = new HashSet<OBSERVATIONMETHOD>();
            this.INFORMATIONSOURCETYPE = new HashSet<INFORMATIONSOURCETYPE>();
            this.PLATFORM = new HashSet<PLATFORM>();
            this.SYSTEM = new HashSet<SYSTEM>();
        }
    
        public int MeasureSourceID { get; set; }
        public Nullable<int> SourceClassID { get; set; }
        public string SourceClassName { get; set; }
        public string MeasureSourceName { get; set; }
        public Nullable<int> SourceTypeID { get; set; }
        public string SourceTypeName { get; set; }
        public string MeasureSourceDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CODE> CODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLLECTIONMETHOD> COLLECTIONMETHOD { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISCOVERYMETHOD> DISCOVERYMETHOD { get; set; }
        public virtual SOURCECLASS SOURCECLASS { get; set; }
        public virtual SOURCETYPE SOURCETYPE { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEASURESOURCECONTRIBUTOR> MEASURESOURCECONTRIBUTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEASURESOURCETOOL> MEASURESOURCETOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEASURESOURCETOOLTYPE> MEASURESOURCETOOLTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBSERVATIONMETHOD> OBSERVATIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATIONSOURCETYPE> INFORMATIONSOURCETYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORM> PLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSTEM> SYSTEM { get; set; }
    }
}
