using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Risk
    {
        public int RiskId { get; set; }
        public int SingleDocumentId { get; set; }
        public string CreatedByUserId { get; set; }
        public string UpdatedByUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
