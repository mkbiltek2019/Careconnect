//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBP.Business.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportFinance
    {
        public ReportFinance()
        {
            this.ReportColumnValues = new HashSet<ReportColumnValue>();
        }
    
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int ServiceId { get; set; }
        public int BusinessId { get; set; }
        public Nullable<System.DateTime> BilledDate { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<double> Charges { get; set; }
        public Nullable<double> PaidAmount { get; set; }
        public string ReportKey { get; set; }
        public Nullable<double> AdjustAmount { get; set; }
        public string AdjustReason { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual LookupEnrolledService LookupEnrolledService { get; set; }
        public virtual ICollection<ReportColumnValue> ReportColumnValues { get; set; }
        public virtual ReportMaster ReportMaster { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual BusinessMaster BusinessMaster { get; set; }
    }
}