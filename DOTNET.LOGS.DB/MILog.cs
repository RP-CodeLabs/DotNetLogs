//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOTNET.LOGS.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MILog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MILog()
        {
            this.MIAdditionalItemLogs = new HashSet<MIAdditionalItemLog>();
        }
    
        public int MILogsId { get; set; }
        public string Category { get; set; }
        public System.DateTime Logdatetime { get; set; }
        public Nullable<int> LogDetailId { get; set; }
        public string Action { get; set; }
    
        public virtual LogDetail LogDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MIAdditionalItemLog> MIAdditionalItemLogs { get; set; }
    }
}
