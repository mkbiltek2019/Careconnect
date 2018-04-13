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
    
    public partial class Role
    {
        public Role()
        {
            this.RolePrivileges = new HashSet<RolePrivilege>();
            this.SalesRolePrivileges = new HashSet<SalesRolePrivilege>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Nullable<int> BusinessId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> OldId { get; set; }
    
        public virtual ICollection<RolePrivilege> RolePrivileges { get; set; }
        public virtual ICollection<SalesRolePrivilege> SalesRolePrivileges { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual BusinessMaster BusinessMaster { get; set; }
    }
}
