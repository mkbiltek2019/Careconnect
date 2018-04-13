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
    
    public partial class MarketingDocument
    {
        public MarketingDocument()
        {
            this.MarketingAttachments = new HashSet<MarketingAttachment>();
        }
    
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Nullable<int> DocumentTypeId { get; set; }
        public string Url { get; set; }
        public Nullable<bool> Trash { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string Description { get; set; }
        public Nullable<int> BusinessId { get; set; }
    
        public virtual LookupDocumentType LookupDocumentType { get; set; }
        public virtual LookupMarketingCategory LookupMarketingCategory { get; set; }
        public virtual ICollection<MarketingAttachment> MarketingAttachments { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual BusinessMaster BusinessMaster { get; set; }
    }
}
