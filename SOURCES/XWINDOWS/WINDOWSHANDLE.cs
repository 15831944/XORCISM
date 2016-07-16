//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWINDOWSModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WINDOWSHANDLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WINDOWSHANDLE()
        {
            this.WINDOWSHANDLELISTHANDLES = new HashSet<WINDOWSHANDLELISTHANDLES>();
            this.WINDOWSMUTEXHANDLE = new HashSet<WINDOWSMUTEXHANDLE>();
            this.WINDOWSTHREAD = new HashSet<WINDOWSTHREAD>();
            this.WINDOWSWAITABLETIMEROBJECT = new HashSet<WINDOWSWAITABLETIMEROBJECT>();
        }
    
        public int WindowsHandleID { get; set; }
        public Nullable<int> WindowsHandleObjectID { get; set; }
        public string WindowsHandleName { get; set; }
        public Nullable<int> HandleTypeID { get; set; }
        public Nullable<int> Object_Address { get; set; }
        public Nullable<int> Access_Mask { get; set; }
        public Nullable<int> Pointer_Count { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WINDOWSHANDLELISTHANDLES> WINDOWSHANDLELISTHANDLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WINDOWSMUTEXHANDLE> WINDOWSMUTEXHANDLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WINDOWSTHREAD> WINDOWSTHREAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WINDOWSWAITABLETIMEROBJECT> WINDOWSWAITABLETIMEROBJECT { get; set; }
    }
}