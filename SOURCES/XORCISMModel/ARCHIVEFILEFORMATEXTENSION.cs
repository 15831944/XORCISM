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
    
    public partial class ARCHIVEFILEFORMATEXTENSION
    {
        public int ArchiveFileFormatExtensionID { get; set; }
        public int ArchiveFileFormatID { get; set; }
        public int FileExtensionID { get; set; }
        public string ArchiveFileFormatExtensionDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
    
        public virtual ARCHIVEFILEFORMAT ARCHIVEFILEFORMAT { get; set; }
        public virtual FILEEXTENSION FILEEXTENSION { get; set; }
    }
}
