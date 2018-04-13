//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBP.NotificationApp.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Privilege
    {
        public Privilege()
        {
            this.DepartmentPrivileges = new HashSet<DepartmentPrivilege>();
            this.RolePrivileges = new HashSet<RolePrivilege>();
            this.UserPrivileges = new HashSet<UserPrivilege>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string PrivilegeKey { get; set; }
    
        public virtual ICollection<DepartmentPrivilege> DepartmentPrivileges { get; set; }
        public virtual ModulesMaster ModulesMaster { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<RolePrivilege> RolePrivileges { get; set; }
        public virtual ICollection<UserPrivilege> UserPrivileges { get; set; }
    }
}
