//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOVALModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OVALCOMPONENTGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OVALCOMPONENTGROUP()
        {
            this.OVALLITERALCOMPONENTFOROVALCOMPONENTGROUP = new HashSet<OVALLITERALCOMPONENTFOROVALCOMPONENTGROUP>();
            this.OVALOBJECTCOMPONENTFOROVALCOMPONENTGROUP = new HashSet<OVALOBJECTCOMPONENTFOROVALCOMPONENTGROUP>();
            this.OVALVARIABLECOMPONENTFOROVALCOMPONENTGROUP = new HashSet<OVALVARIABLECOMPONENTFOROVALCOMPONENTGROUP>();
        }
    
        public int OVALComponentGroupID { get; set; }
        public Nullable<int> OVALVariableID { get; set; }
        public Nullable<int> OVALFunctionID { get; set; }
        public string FunctionName { get; set; }
        public string FunctionOperation { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALLITERALCOMPONENTFOROVALCOMPONENTGROUP> OVALLITERALCOMPONENTFOROVALCOMPONENTGROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALOBJECTCOMPONENTFOROVALCOMPONENTGROUP> OVALOBJECTCOMPONENTFOROVALCOMPONENTGROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALVARIABLECOMPONENTFOROVALCOMPONENTGROUP> OVALVARIABLECOMPONENTFOROVALCOMPONENTGROUP { get; set; }
    }
}