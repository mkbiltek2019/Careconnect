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
    
    public partial class PracticeProviderMapper
    {
        public int Id { get; set; }
        public int PracticeId { get; set; }
        public int ProviderId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual Practice Practice { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
