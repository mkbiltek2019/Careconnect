﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmgenexBusinessPortal.Models
{
    public class NotificationTypeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string NotificationKey { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public string CreatedUser { get; set; }
        public string Updateduser { get; set; }
    }
}