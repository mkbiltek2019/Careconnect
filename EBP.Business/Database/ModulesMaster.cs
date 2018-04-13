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
    
    public partial class ModulesMaster
    {
        public ModulesMaster()
        {
            this.Privileges = new HashSet<Privilege>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Privilege> Privileges { get; set; }
    }
}
