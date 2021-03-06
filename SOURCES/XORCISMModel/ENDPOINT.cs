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
    
    public partial class ENDPOINT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENDPOINT()
        {
            this.EVENTENDPOINT = new HashSet<EVENTENDPOINT>();
            this.FINDING = new HashSet<FINDING>();
        }
    
        public int EndPointID { get; set; }
        public Nullable<int> AssetID { get; set; }
        public Nullable<int> DeviceID { get; set; }
        public Nullable<int> AddressID { get; set; }
        public Nullable<int> ProtocolID { get; set; }
        public string ProtocolName { get; set; }
        public Nullable<int> PortID { get; set; }
        public Nullable<int> PortNumber { get; set; }
        public string Service { get; set; }
        public string Version { get; set; }
        public string CPEName { get; set; }
        public Nullable<int> SessionID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
    
        public virtual ADDRESS ADDRESS { get; set; }
        public virtual ASSET ASSET { get; set; }
        public virtual DEVICE DEVICE { get; set; }
        public virtual PORT PORT { get; set; }
        public virtual PROTOCOL PROTOCOL { get; set; }
        public virtual SESSION SESSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTENDPOINT> EVENTENDPOINT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINDING> FINDING { get; set; }
    }
}
