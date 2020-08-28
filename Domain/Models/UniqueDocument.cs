using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UniqueDocument
    {
        public int UniqueDocumentId { get; set; }
        public int EstablishmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public string UpdatedByUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual Establishment Establishment { get; set; }
        public bool IsSigned { get; set; }
    }
}
