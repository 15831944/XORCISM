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
    
    public partial class ENCRYPTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENCRYPTION()
        {
            this.ENCRYPTIONREFERENCE = new HashSet<ENCRYPTIONREFERENCE>();
            this.FILEENCRYPTION = new HashSet<FILEENCRYPTION>();
            this.PACKAGINGENCRYPTION = new HashSet<PACKAGINGENCRYPTION>();
            this.SUBJECTPUBLICKEY = new HashSet<SUBJECTPUBLICKEY>();
            this.X509CERTIFICATE = new HashSet<X509CERTIFICATE>();
            this.X509SIGNATURE = new HashSet<X509SIGNATURE>();
        }
    
        public int EncryptionID { get; set; }
        public string encryption_mechanism { get; set; }
        public Nullable<int> EncryptionMechanismID { get; set; }
        public string encryption_mechanism_ref { get; set; }
        public string EncryptionDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual ENCRYPTIONMECHANISM ENCRYPTIONMECHANISM { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENCRYPTIONREFERENCE> ENCRYPTIONREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILEENCRYPTION> FILEENCRYPTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACKAGINGENCRYPTION> PACKAGINGENCRYPTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBJECTPUBLICKEY> SUBJECTPUBLICKEY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509CERTIFICATE> X509CERTIFICATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X509SIGNATURE> X509SIGNATURE { get; set; }
    }
}