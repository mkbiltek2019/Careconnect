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
    
    public partial class ReportStaticColumnConfig
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> ColumnOrder { get; set; }
    
        public virtual LookupEnrolledService LookupEnrolledService { get; set; }
    }
}
