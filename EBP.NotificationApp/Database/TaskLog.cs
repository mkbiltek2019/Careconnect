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
    
    public partial class TaskLog
    {
        public int Id { get; set; }
        public Nullable<int> TaskId { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> AlertDate { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> TaskRequestTypeId { get; set; }
        public string TaskDescription { get; set; }
        public Nullable<int> PracticeId { get; set; }
        public Nullable<int> BusinessId { get; set; }
        public Nullable<int> PriorityTypeId { get; set; }
        public Nullable<System.DateTime> TargetDate { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }
        public Nullable<int> RequestedBy { get; set; }
        public Nullable<int> Status { get; set; }
        public bool IsActive { get; set; }
        public string AssignedTo { get; set; }
        public string Watchers { get; set; }
        public string Action { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string Files { get; set; }
    
        public virtual Practice Practice { get; set; }
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}
