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
    
    public partial class LookupTaskType
    {
        public LookupTaskType()
        {
            this.Tasks = new HashSet<Task>();
            this.TaskItemOrders = new HashSet<TaskItemOrder>();
            this.TaskItems = new HashSet<TaskItem>();
            this.TaskItems1 = new HashSet<TaskItem>();
        }
    
        public int Id { get; set; }
        public string TaskType { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int BusinessId { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<TaskItemOrder> TaskItemOrders { get; set; }
        public virtual ICollection<TaskItem> TaskItems { get; set; }
        public virtual ICollection<TaskItem> TaskItems1 { get; set; }
        public virtual BusinessMaster BusinessMaster { get; set; }
    }
}
