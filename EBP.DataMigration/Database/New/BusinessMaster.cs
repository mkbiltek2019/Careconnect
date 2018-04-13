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
    
    public partial class BusinessMaster
    {
        public BusinessMaster()
        {
            this.Accounts = new HashSet<Account>();
            this.Departments = new HashSet<Department>();
            this.Leads = new HashSet<Lead>();
            this.LookupDocumentTypes = new HashSet<LookupDocumentType>();
            this.LookupMarketingCategories = new HashSet<LookupMarketingCategory>();
            this.LookupTaskTypes = new HashSet<LookupTaskType>();
            this.MarketingDocuments = new HashSet<MarketingDocument>();
            this.Practices = new HashSet<Practice>();
            this.RepGroups = new HashSet<RepGroup>();
            this.ReportColumns = new HashSet<ReportColumn>();
            this.ReportMasters = new HashSet<ReportMaster>();
            this.Roles = new HashSet<Role>();
            this.Tasks = new HashSet<Task>();
            this.UserColumnVisibilities = new HashSet<UserColumnVisibility>();
            this.UserPrivileges = new HashSet<UserPrivilege>();
            this.Users = new HashSet<User>();
            this.LookupEnrolledServices = new HashSet<LookupEnrolledService>();
        }
    
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public string RelativeUrl { get; set; }
        public string DomainUrl { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Status { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<LookupDocumentType> LookupDocumentTypes { get; set; }
        public virtual ICollection<LookupMarketingCategory> LookupMarketingCategories { get; set; }
        public virtual ICollection<LookupTaskType> LookupTaskTypes { get; set; }
        public virtual ICollection<MarketingDocument> MarketingDocuments { get; set; }
        public virtual ICollection<Practice> Practices { get; set; }
        public virtual ICollection<RepGroup> RepGroups { get; set; }
        public virtual ICollection<ReportColumn> ReportColumns { get; set; }
        public virtual ICollection<ReportMaster> ReportMasters { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<UserColumnVisibility> UserColumnVisibilities { get; set; }
        public virtual ICollection<UserPrivilege> UserPrivileges { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<LookupEnrolledService> LookupEnrolledServices { get; set; }
    }
}
