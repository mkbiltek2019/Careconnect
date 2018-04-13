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
    
    public partial class Provider
    {
        public Provider()
        {
            this.PracticeProviderLocationMappers = new HashSet<PracticeProviderLocationMapper>();
            this.PracticeProviderMappers = new HashSet<PracticeProviderMapper>();
            this.ReportMasters = new HashSet<ReportMaster>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string NPI { get; set; }
        public Nullable<int> DegreeId { get; set; }
        public bool IsActive { get; set; }
        public string ProviderEmail { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> OldId { get; set; }
    
        public virtual LookupDegree LookupDegree { get; set; }
        public virtual ICollection<PracticeProviderLocationMapper> PracticeProviderLocationMappers { get; set; }
        public virtual ICollection<PracticeProviderMapper> PracticeProviderMappers { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<ReportMaster> ReportMasters { get; set; }
    }
}