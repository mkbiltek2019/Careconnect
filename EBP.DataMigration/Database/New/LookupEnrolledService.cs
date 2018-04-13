//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBP.DataMigration.Database.New
{
    using System;
    using System.Collections.Generic;
    
    public partial class LookupEnrolledService
    {
        public LookupEnrolledService()
        {
            this.ReportColumns = new HashSet<ReportColumn>();
            this.ReportMasters = new HashSet<ReportMaster>();
            this.RepServiceMappers = new HashSet<RepServiceMapper>();
            this.UserColumnVisibilities = new HashSet<UserColumnVisibility>();
        }
    
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDecription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> OldId { get; set; }
    
        public virtual BusinessMaster BusinessMaster { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<ReportColumn> ReportColumns { get; set; }
        public virtual ICollection<ReportMaster> ReportMasters { get; set; }
        public virtual ICollection<RepServiceMapper> RepServiceMappers { get; set; }
        public virtual ICollection<UserColumnVisibility> UserColumnVisibilities { get; set; }
    }
}
